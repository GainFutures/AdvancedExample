using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Allocation blocks editing form. Loads, saves and edits allocation blocks
    /// </summary>
    public partial class AllocationBlocksForm : Form
    {
        /// <summary>
        ///     Allocation blocks form constructor
        /// </summary>
        public AllocationBlocksForm()
        {
            InitializeComponent();
            PrepareRulesCombo();
            PrepareAccountsCombo();
        }

        /// <summary>
        ///     Gets available accounts list from column's in-place editor combo box
        /// </summary>
        private IEnumerable<Account> AvailableAccounts
        {
            get { return (IEnumerable<Account>) accountIdDataGridViewComboBoxColumn.DataSource; }
        }

        /// <summary>
        ///     Gets current allocation block item
        /// </summary>
        private AllocationBlock SelectedBlock
        {
            get { return cbAB.SelectedItem as AllocationBlock; }
        }

        /// <summary>
        ///     Loads account list to column's in-place editor combo box
        /// </summary>
        private void PrepareAccountsCombo()
        {
            var accounts = new List<Account>(OECClient.Global.Accounts);
            accountIdDataGridViewComboBoxColumn.DataSource = accounts;
            accountIdDataGridViewComboBoxColumn.ValueMember = "ID";
            accountIdDataGridViewComboBoxColumn.DisplayMember = "Name";
        }

        /// <summary>
        ///     Fills Allocation Rules
        /// </summary>
        private void PrepareRulesCombo()
        {
            cbRule.DataSource = Enum.GetValues(typeof (AllocationRule));
            cbRule.SelectedItem = null;
        }

        /// <summary>
        ///     Loads existing allocaction blocks
        /// </summary>
        private void AllocationBlocksForm_Load(object sender, EventArgs e)
        {
            SetABListCombo(OECClient.Global.AllocationBlocks);
            UpdateDeleteAllocationBlockButtonStatus();
        }

        /// <summary>
        ///     Fills combo with loaded allocation blocks
        /// </summary>
        /// <param name="abList">Allocation block list</param>
        private void SetABListCombo(IEnumerable<AllocationBlock> abList)
        {
            cbAB.Items.Clear();

            foreach (AllocationBlock ab in abList)
            {
                var newAb = new AllocationBlock(ab.Name, ab.Rule);
                foreach (AllocationBlockItem abItem in ab.Items)
                    newAb.Add(abItem.Account, abItem.Lots);
                cbAB.Items.Add(newAb);
            }
            if (cbAB.Items.Count > 0)
                cbAB.SelectedIndex = 0;
        }

        /// <summary>
        ///     Disables delete button, if no more items to delete
        /// </summary>
        private void UpdateDeleteAllocationBlockButtonStatus()
        {
            btDeleteAB.Enabled = cbAB.Items.Count > 0;
        }

        /// <summary>
        ///     Validates and saves AllocationBlocks if OK button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllocationBlocksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                return;

            string errMsg;
            if (!ValidateAllocationBlocks(out errMsg))
            {
                MessageBox.Show(errMsg);
                e.Cancel = true;
                return;
            }

            try
            {
                OECClient.Global.SubmitAllocationBlocks(GetABListCombo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving allocation blocks.\n" + ex.Message);
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
        }

        /// <summary>
        ///     Validating allocation blocks being edited
        /// </summary>
        /// <param name="errMsg">Error message when validation is false</param>
        /// <returns>True if validation ok, otherwise false</returns>
        private bool ValidateAllocationBlocks(out string errMsg)
        {
            foreach (AllocationBlock ab in cbAB.Items)
            {
                if (ab.Items.Count < 2)
                {
                    errMsg = ab + " has less than 2 accounts";
                    return false;
                }
                foreach (AllocationBlockItem abItem in ab.Items)
                {
                    if (abItem.Lots < 1)
                    {
                        errMsg = ab + " - " + abItem + " not valid";
                        return false;
                    }
                }
            }
            errMsg = string.Empty;
            return true;
        }

        /// <summary>
        ///     Adding allocation block to list
        /// </summary>
        private void btAddAB_Click(object sender, EventArgs e)
        {
            if (cbAB.Text.Trim() == string.Empty || cbRule.SelectedItem == null)
                return;

            string name = cbAB.Text;

            if (cbAB.FindStringExact(name) > -1)
                return;

            var rule = (AllocationRule) cbRule.SelectedItem;

            try
            {
                var ab = new AllocationBlock(name, rule);

                cbAB.Items.Add(ab);
                cbAB.SelectedItem = ab;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding allocation blocks.\n" + ex.Message);
                return;
            }

            UpdateDeleteAllocationBlockButtonStatus();
        }

        /// <summary>
        ///     Reads allocation block list from combo
        /// </summary>
        /// <returns>Allocation block list</returns>
        private AllocationBlockList GetABListCombo()
        {
            var abList = new AllocationBlockList();
            foreach (AllocationBlock ab in cbAB.Items)
                abList.Add(ab);
            return abList;
        }

        /// <summary>
        ///     Rebinds items list for new selected allocation block
        /// </summary>
        private void cbAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedBlock == null)
                return;
            ReBindABItemList(SelectedBlock);
            cbRule.SelectedItem = SelectedBlock.Rule;
        }

        /// <summary>
        ///     Apply new selected rule
        /// </summary>
        private void cbRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedBlock == null)
                return;
            SelectedBlock.Rule = (AllocationRule) cbRule.SelectedItem;
        }

        /// <summary>
        ///     Deleting Allocation block
        /// </summary>
        private void btDeleteAB_Click(object sender, EventArgs e)
        {
            cbAB.Items.Remove(SelectedBlock);

            if (cbAB.Items.Count > 0)
            {
                cbAB.SelectedIndex = 0;
            }
            else
            {
                cbAB.Text = string.Empty;
            }

            ReBindABItemList(SelectedBlock);

            UpdateDeleteAllocationBlockButtonStatus();
        }

        /// <summary>
        ///     Bind items of new allocation block to item list grid
        /// </summary>
        /// <param name="newAB">New Allocation Block</param>
        private void ReBindABItemList(AllocationBlock newAB)
        {
            var bs = (BindingSource) dgABItems.DataSource;

            if (newAB != null)
            {
                bs.DataSource = null;
                bs.DataSource = newAB.Items;
            }
            else
            {
                bs.DataSource = null;
            }

            bs.ResetBindings(false);
        }

        /// <summary>
        ///     Adds new item to selected allocation block item list
        /// </summary>
        private void btAddItem_Click(object sender, EventArgs e)
        {
            if (SelectedBlock == null)
                return;

            Account account = GetNextAvailableAccount();

            if (account == null)
                return;

            SelectedBlock.Add(account, 1);

            ReBindABItemList(SelectedBlock);
            UpdateDeleteAllocationBlockButtonStatus();
        }

        /// <summary>
        ///     Gets next account that is not in list of already selected accounts
        /// </summary>
        /// <returns></returns>
        private Account GetNextAvailableAccount()
        {
            foreach (Account account in AvailableAccounts)
            {
                bool isExists = false;
                foreach (AllocationBlockItem abItem in SelectedBlock.Items)
                {
                    if (abItem.Account == account)
                    {
                        isExists = true;
                        break;
                    }
                }
                if (!isExists)
                    return account;
            }
            return null;
        }


        /// <summary>
        ///     Deletes selected item from item list of current selected allocation block
        /// </summary>
        private void btDeleteItem_Click(object sender, EventArgs e)
        {
            if (SelectedBlock == null)
                return;
            var bs = (BindingSource) dgABItems.DataSource;
            if (bs.Current != null)
                SelectedBlock.Items.Remove((AllocationBlockItem) bs.Current);
            ReBindABItemList(SelectedBlock);
        }

        /// <summary>
        ///     Avoid exception throw of datagrid, when in-place editor's combo has no match account (maybe deleted)
        /// </summary>
        private void dgABItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        /// <summary>
        ///     Validates lots column's cells for integer values
        /// </summary>
        private void dgABItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == lotDataGridViewTextBoxColumn.Index)
            {
                string value = e.FormattedValue.ToString();
                int lot;
                if (int.TryParse(value, out lot))
                    return;
                MessageBox.Show("Value must by of integer type");
                dgABItems[e.ColumnIndex, e.RowIndex].Value = 1;
            }
        }
    }
}
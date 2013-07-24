using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Program's main form
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly LoginForm _loginForm = new LoginForm();

        /// <summary>
        ///     Construct main form and preparing common events
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _loginForm.OnConnectionStatusChange += OnConnectionStatusChange;
            ordersControl.OnCurrentOrderChanged += orderDetailsControl1.CurrentOrderChangedEventHandler;
            chartsControl1.OnChartSelectedContractChanged += histogramControl1.ChartSelectedContractChangedEventHandler;
            osmOrdersControl.OnCurrentOrderChanged += osmOrderDetailsControl.CurrentOrderChangedEventHandler;

            OECClient.Global.OnError += OECClient_OnError;
            selectAccountToolStripMenuItem.Enabled = false;

            osmOrdersControl.PrepareEventHandlers();
        }

        /// <summary>
        ///     Displays error occured
        /// </summary>
        /// <param name="ex">Exception to display</param>
        private void OECClient_OnError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Occurs when connection status is changed
        /// </summary>
        /// <param name="newConnectionStatus">New connection status</param>
        private void OnConnectionStatusChange(ConnectionStatus newConnectionStatus)
        {
            lblConnectionStatus.Text = LoginForm.GetConnectionStatusInfo(newConnectionStatus);
            Update();

            selectAccountToolStripMenuItem.Enabled = OECClient.Global.CompleteConnected;

            if (OECClient.Global.CompleteConnected)
            {
                LoadAccounts();
                CheckCurrentAccount();
                CheckAllocationBlockWarnings();
            }
        }

        private void CheckAllocationBlockWarnings()
        {
            var warnings = new List<string>();
            foreach (AllocationBlock item in OECClient.Global.AllocationBlocks.Values)
                if (!string.IsNullOrEmpty(item.Warning))
                    warnings.Add(item.Warning);
            if (warnings.Count > 0)
                MessageBox.Show("Allocation blocks warnings:\n" + string.Join(Environment.NewLine, warnings.ToArray()));
        }

        /// <summary>
        ///     Loads accounts and allocation blocks into Account menu item's dropdown list
        /// </summary>
        private void LoadAccounts()
        {
            selectAccountToolStripMenuItem.DropDownItems.Clear();

            //load accounts
            foreach (Account account in OECClient.Global.Accounts)
                AddAccountMenuItem(account);

            // checks if allocation blocks available in this session
            if (OECClient.Global.WashAccounts.Count == 0)
                return;

            allocationBlocksToolStripMenuItem.Visible = true;

            if (OECClient.Global.AllocationBlocks.Count == 0)
                return;

            selectAccountToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

            foreach (AllocationBlock ab in OECClient.Global.AllocationBlocks)
                AddAccountMenuItem(ab);
        }

        /// <summary>
        ///     Mark current account or allocation block in Accounts menu item subitems
        /// </summary>
        private void CheckCurrentAccount()
        {
            Globals.CurrentAccountOrAB = OECClient.Global.Accounts.First;
            if (Globals.CurrentAccountOrAB != null)
            {
                ((ToolStripMenuItem) selectAccountToolStripMenuItem.DropDownItems[Globals.CurrentAccountOrAB.ToString()])
                    .Checked = true;
                UpdateCurrentAccount();
            }
        }

        /// <summary>
        ///     Adds account or AB into menu item's drop down list
        /// </summary>
        /// <param name="item"></param>
        private void AddAccountMenuItem(object item)
        {
            var menuItem = new ToolStripMenuItem(item.ToString()) {Tag = item, Name = item.ToString()};
            menuItem.Click += accountMenuItem_Click;

            selectAccountToolStripMenuItem.DropDownItems.Add(menuItem);
        }

        /// <summary>
        ///     Changes current selected account or AB when user clicks it in menu item's drop down list
        /// </summary>
        private void accountMenuItem_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = (ToolStripMenuItem) sender;

            if (clickedMenuItem.Checked)
                return;

            foreach (ToolStripItem menuItem in selectAccountToolStripMenuItem.DropDownItems)
            {
                var toolStripMenuItem = menuItem as ToolStripMenuItem;
                if (toolStripMenuItem != null)
                    toolStripMenuItem.Checked = false;
            }

            clickedMenuItem.Checked = true;

            Globals.CurrentAccountOrAB = clickedMenuItem.Tag;
            UpdateCurrentAccount();
        }

        /// <summary>
        ///     Updates current account info in status bar
        /// </summary>
        private void UpdateCurrentAccount()
        {
            lblAccountInfo.Text = "Current account: " + Globals.CurrentAccountOrAB;
        }

        /// <summary>
        ///     Showing Login Window on MainForm shown
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            _loginForm.ShowDialog();
        }

        /// <summary>
        ///     Handling login menu item click
        /// </summary>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loginForm.ShowDialog();
        }

        /// <summary>
        ///     Handling Exit menu item click
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Shows allocation blocks edit form
        /// </summary>
        private void allocationBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new AllocationBlocksForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadAccounts();
                CheckCurrentAccount();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OECClient.Global.Disconnect();
        }

        private void toolStripMenuItemShowLog_Click(object sender, EventArgs e)
        {
            LogForm.ShowLog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Contract ComboBox control, that shows current loaded contracts
    /// </summary>
    public class ContractCombo : ComboBox
    {
        /// <summary>
        ///     Selected Contract
        /// </summary>
        public Contract SelectedContract
        {
            get { return SelectedItem as Contract; }
            set { SelectedItem = value; }
        }

        protected override void OnFormat(ListControlConvertEventArgs e)
        {
            var contract = e.ListItem as Contract;
            e.Value = contract != null ? string.Format("{0} {1}", contract.Symbol, contract.Name) : string.Empty;
        }

        protected override void OnDropDown(EventArgs e)
        {
            if (OECClient.Global.Contracts != null)
                DataSource = OECClient.Global.Contracts.Values;
            base.OnDropDown(e);
        }
    }


    /// <summary>
    ///     Contract lookup combo box, that uses lookup resulst in drop down list
    /// </summary>
    public class ContractLookupCombo : ComboBox
    {
        private SymbolLookupCriteria _crit;

        /// <summary>
        ///     Selected Contract
        /// </summary>
        public Contract SelectedContract
        {
            get { return SelectedItem as Contract; }
            set { SelectedItem = value; }
        }

        /// <summary>
        ///     Contract kind used for results filtering
        /// </summary>
        public ContractKind ContractKind { get; set; }

        protected override void OnTextChanged(EventArgs e)
        {
            if (SelectedItem != null && Text == SelectedItem.ToString())
                return;

            if (string.IsNullOrEmpty(Text))
            {
                Items.Clear();
                try
                {
                    DroppedDown = false;
                }
                catch
                {
                }
                return;
            }

            _crit = new SymbolLookupCriteria {SearchText = Text, Mode = SymbolLookupMode.SymbolStartsWith};
            _crit.ContractKinds.Add(ContractKind);
            OECClient.Global.SymbolLookup(_crit);
        }

        protected override void OnCreateControl()
        {
            if (OECClient.Global != null)
                OECClient.Global.OnSymbolLookupReceived += Global_OnSymbolLookupReceived;
        }

        private void Global_OnSymbolLookupReceived(SymbolLookupCriteria symbolLookup, ContractList contracts)
        {
            if (_crit != null && _crit.ID != symbolLookup.ID || Text.ToUpper() != symbolLookup.SearchText)
                return;

            if (Items.Count == 0)
                DroppedDown = true;

            var lst = new List<Contract>(contracts);
            lst.Sort(new LookupContractSorter(Text));
            Items.Clear();
            lst.ForEach(c => Items.Add(c));
            SelectionStart = Text.Length;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{

    /// <summary>
    /// Represents API symbol lookup functionality
    /// </summary>
    public partial class SymbolLookup : BaseControl
    {
        private SymbolLookupCriteria _criteria;

        /// <summary>
        /// Construct symbol lookup control
        /// </summary>
        public SymbolLookup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prepare symbol lookup handler (for search results) and login complete handler (for filters initializing)
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            OECClient.Global.OnSymbolLookupReceived += GlobalSymbolLookupReceived;
            OECClient.Global.OnLoginComplete += InitializeFilters;
            if (OECClient.Global.CompleteConnected)
                InitializeFilters();
        }

        /// <summary>
        /// Initializing Exchange and ContractGroup filters, used for fitering symbol lookup results
        /// </summary>
        private void InitializeFilters()
        {
            cbExchangeFilter.Items.Clear();
            cbExchangeFilter.Items.Add("All");
            foreach (Exchange ex in OECClient.Global.Exchanges)
                cbExchangeFilter.Items.Add(ex.Name);
            cbExchangeFilter.SelectedIndex = 0;

            cbContractGroup.Items.Clear();
            cbContractGroup.Items.Add("All");
            foreach (ContractGroup group in OECClient.Global.ContractGroups)
                cbContractGroup.Items.Add(group);
            cbContractGroup.SelectedIndex = 0;
        }

        /// <summary>
        /// Fullfills results table once results are available
        /// </summary>
        /// <param name="symbolLookup"></param>
        /// <param name="contracts"></param>
        void GlobalSymbolLookupReceived(SymbolLookupCriteria symbolLookup, ContractList contracts)
        {
            if (_criteria == null || _criteria.ID != symbolLookup.ID)
                return;

            lvResults.Items.Clear();
            var contractList = new List<Contract>(contracts);
            contractList.Sort(new LookupContractSorter(symbolLookup.SearchText));
            foreach (Contract contract in contractList)
            {
                var item = new ListViewItem(contract.Symbol);
                item.SubItems.Add(contract.Name);
                item.SubItems.Add(contract.BaseContract.ContractKind.ToString());
                item.SubItems.Add(contract.Exchange.ToString());
                item.SubItems.Add(contract.ContractGroup.ToString());
                item.SubItems.Add(contract.StartTime.ToString());
                item.SubItems.Add(contract.StopTime.ToString());
                lvResults.Items.Add(item);
            }
        }

        /// <summary>
        /// Performs contracts lookup
        /// </summary>
        private void SearchClick(object sender, EventArgs e)
        {
            string searchText = edText.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Search text should not be empty");
                return;
            }
            if (!OECClient.Global.CompleteConnected)
            {
                MessageBox.Show("Not connected");
                return;
            }
            _criteria = new SymbolLookupCriteria
                               {
                                   SearchText = edText.Text,
                                   ContractGroup = cbContractGroup.SelectedItem as ContractGroup,
                                   Exchange = OECClient.Global.Exchanges[cbExchangeFilter.Text],
                                   DesiredResultCount = (int) edMaxResults.Value
                               };
            _criteria.ContractKinds.AddRange(GetSelectedContractKinds());
            try
            {
                OECClient.Global.SymbolLookup(_criteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured during lookup" + ex);
            }
            
        }

        /// <summary>
        /// Gathers values from contract kind checkboxes (Forex, Equity, Options)
        /// </summary>
        private IEnumerable<ContractKind> GetSelectedContractKinds()
        {
            if (chbFutures.Checked)
            {
                yield return ContractKind.Future;
                yield return ContractKind.FutureCompound;
                yield return ContractKind.GenericCompound;
            }
            if (chbForex.Checked)
            {
                yield return ContractKind.Forex;
            }
        }
    }

    class LookupContractSorter : IComparer<Contract>
    {
        private readonly string _searchText;

        public LookupContractSorter(string searchText)
        {
            _searchText = searchText;
        }

        public int Compare(Contract x, Contract y)
        {
            int res = GetSymbolLookupPriority(x, _searchText).CompareTo(GetSymbolLookupPriority(y, _searchText));
            if (res == 0)
                res = x.Symbol.CompareTo(y.Symbol);
            return res;
        }

        private static int GetSymbolLookupPriority(Contract c, string searchText)
        {
            string symbol = c.Symbol.ToUpper();
            if (symbol == searchText)
                return 0;
            if (symbol.StartsWith(searchText))
                return 1;
            string descr = c.Name.ToUpper();
            if (descr.StartsWith(searchText))
                return 2;
            if (symbol.Contains(searchText))
                return 3;
            if (descr.Contains(searchText))
                return 3;
            return 100;
        }
    }
}

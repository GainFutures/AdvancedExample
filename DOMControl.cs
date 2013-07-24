using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Contract DOM control. Displays DOM of contract
    /// </summary>
    public partial class DOMControl : SubscribeControl
    {
        private readonly Dictionary<Contract, object> _subscribedContracts = new Dictionary<Contract, object>(100);

        /// <summary>
        ///     DOM control constructor
        /// </summary>
        public DOMControl()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Prepares DOM changed event
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnDOMChanged += OnDOMChanged;
        }

        /// <summary>
        ///     Occurs when DOM for some contract changed. if this contract is selected contract, refresh DOM Grid
        /// </summary>
        /// <param name="contract">contract for which DOM is changed</param>
        private void OnDOMChanged(Contract contract)
        {
            Contract currentContract = cbSymbol.SelectedContract;

            if (currentContract == null || currentContract.ID != contract.ID)
                return;

            RefreshDOM(contract);
        }

        /// <summary>
        ///     Another contract selected, DOM grid will be refreshed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDOM(cbSymbol.SelectedContract);
        }

        /// <summary>
        ///     Refreshes DOM grid
        /// </summary>
        /// <param name="contract"></param>
        private void RefreshDOM(Contract contract)
        {
            if (contract == null)
            {
                dgDOMAsk.DataSource = dgDOMBid.DataSource = null;
                return;
            }

            RefreshSubscribeButtons(contract);

            if (!IsDOMAvailable(contract))
            {
                dgDOMAsk.DataSource = dgDOMBid.DataSource = null;
                return;
            }

            dgDOMAsk.DataSource = GetDOMAskEntryArrayFromDOM(contract.DOM);
            dgDOMBid.DataSource = GetDOMBidEntryArrayFromDOM(contract.DOM);
        }

        /// <summary>
        ///     Creates and fullfills array of Contract DOM Ask Entries, to simple represent it in DOM Ask Grid
        /// </summary>
        /// <param name="dom"></param>
        /// <returns></returns>
        private ContractDOMAskEntry[] GetDOMAskEntryArrayFromDOM(DOM dom)
        {
            int length = dom.AskLevels.Length;
            var entries = new ContractDOMAskEntry[length];

            for (int i = 0; i < length; i++)
                entries[i] = new ContractDOMAskEntry(dom.AskLevels[i], dom.AskSizes[i]);

            return entries;
        }

        /// <summary>
        ///     Creates and fullfills array of Contract DOM Bid Entries, to simple represent it in DOM Bid Grid
        /// </summary>
        /// <param name="dom"></param>
        /// <returns></returns>
        private ContractDOMBidEntry[] GetDOMBidEntryArrayFromDOM(DOM dom)
        {
            int length = dom.BidLevels.Length;
            var entries = new ContractDOMBidEntry[length];

            for (int i = 0; i < length; i++)
                entries[i] = new ContractDOMBidEntry(dom.BidLevels[i], dom.BidSizes[i]);

            return entries;
        }

        /// <summary>
        ///     Refreshes Subscribe and Unsubscribe buttons enable statuses
        /// </summary>
        /// <param name="contract"></param>
        private void RefreshSubscribeButtons(Contract contract)
        {
            btSubscribe.Enabled = !IsDOMAvailable(contract);
            btUnsubscribe.Enabled = !btSubscribe.Enabled;
        }

        /// <summary>
        ///     Determine if DOM for contract is not null, and contains data
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>True if DOM contains data, otherwise false</returns>
        private bool IsDOMAvailable(Contract contract)
        {
            return _subscribedContracts.ContainsKey(contract);
        }

        /// <summary>
        ///     Tries to subscribe contract for DOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubscribe_Click(object sender, EventArgs e)
        {
            Contract contract = cbSymbol.SelectedContract;
            if (contract == null)
                return;

            try
            {
                OECClient.Global.SubscribeDOM(contract);
                _subscribedContracts.Add(contract, null);
                RefreshSubscribeButtons(contract);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't subscribe contract for DOM. " + ex.Message);
            }
        }

        /// <summary>
        ///     Tries to unsubscribe contract for DOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUnsubscribe_Click(object sender, EventArgs e)
        {
            Contract contract = cbSymbol.SelectedContract;
            if (contract == null)
                return;

            try
            {
                OECClient.Global.UnsubscribeDOM(contract);
                _subscribedContracts.Remove(contract);
                dgDOMAsk.DataSource = dgDOMBid.DataSource = null;
                RefreshSubscribeButtons(contract);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't unsubscribe contract for DOM. " + ex.Message);
            }
        }
    }

    /// <summary>
    ///     Used for simple representation of DOM data Bids
    /// </summary>
    public class ContractDOMBidEntry
    {
        private readonly float _bidLevel = -1;

        private readonly float _bidSize;

        /// <summary>
        ///     Create instance of DOM data Bids entry
        /// </summary>
        /// <param name="bidLevel">Bid level</param>
        /// <param name="bidSize">Bid size</param>
        public ContractDOMBidEntry(float bidLevel, uint bidSize)
        {
            _bidLevel = bidLevel;
            _bidSize = bidSize;
        }

        /// <summary>
        ///     Bid level
        /// </summary>
        public float BidLevel
        {
            get { return _bidLevel; }
        }

        /// <summary>
        ///     Bid size
        /// </summary>
        public float BidSize
        {
            get { return _bidSize; }
        }
    }

    /// <summary>
    ///     Used for simple representation of DOM data Asks
    /// </summary>
    public class ContractDOMAskEntry
    {
        private readonly float _askLevel = -1;

        private readonly uint _askSize;

        /// <summary>
        ///     Create instance of DOM data Asks entry
        /// </summary>
        /// <param name="askLevel">Ask level</param>
        /// <param name="askSize">Ask size</param>
        public ContractDOMAskEntry(float askLevel, uint askSize)
        {
            _askLevel = askLevel;
            _askSize = askSize;
        }

        /// <summary>
        ///     Ask level
        /// </summary>
        public float AskLevel
        {
            get { return _askLevel; }
        }

        /// <summary>
        ///     Ask size
        /// </summary>
        public uint AskSize
        {
            get { return _askSize; }
        }
    }
}
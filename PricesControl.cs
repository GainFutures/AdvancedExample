using System;
using System.Windows.Forms;

namespace OEC.API.Example
{
    /// <summary>
    ///     Prices control. Displays quotes, provides subscribe/unsubscribe prices for contract functionality
    /// </summary>
    public partial class PricesControl : SubscribeControl
    {
        /// <summary>
        ///     Prices control constructor
        /// </summary>
        public PricesControl()
        {
            InitializeComponent();
            Caption = "Quotes";
        }

        /// <summary>
        ///     Prepares event handlers for Prices control.
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnPriceChanged += OnPriceChanged;
        }

        /// <summary>
        ///     Refresh quotes when price changed
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="price"></param>
        private void OnPriceChanged(Contract contract, Price price)
        {
            lvQuotes.BeginUpdate();

            string keyContract = contract.Symbol;

            ListViewItem item;
            if (lvQuotes.Items.ContainsKey(keyContract))
            {
                item = lvQuotes.Items[keyContract];
                while (item.SubItems.Count > 1)
                    item.SubItems.RemoveAt(1);
                AddSubItems(item, contract, price);
            }
            else
            {
                item = new ListViewItem {Name = keyContract, Focused = true, Tag = contract};
                    //first element empty, as key only
                AddSubItems(item, contract, price);
                lvQuotes.Items.Add(item);
            }

            lvQuotes.EndUpdate();
            RefreshSubscribeButtonStatus();
        }

        /// <summary>
        ///     Fullfills row of quotes detailed list view
        /// </summary>
        /// <param name="item"></param>
        /// <param name="contract"></param>
        /// <param name="price"></param>
        private void AddSubItems(ListViewItem item, Contract contract, Price price)
        {
            item.SubItems.Add(contract.ToString());
            item.SubItems.Add(contract.PriceToString(price.LastPrice));
            item.SubItems.Add(contract.PriceToString(price.LastVol));
            item.SubItems.Add(contract.PriceToString(price.AskPrice));
            item.SubItems.Add(contract.PriceToString(price.AskVol));
            item.SubItems.Add(contract.PriceToString(price.BidPrice));
            item.SubItems.Add(contract.PriceToString(price.BidVol));
        }


        /// <summary>
        ///     Perform subscribe on selected contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubscribe_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed || cbSymbol.SelectedContract == null)
                return;

            try
            {
                OECClient.Global.Subscribe(cbSymbol.SelectedContract);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't subscribe contract. " + ex.Message);
            }
        }

        /// <summary>
        ///     Perform unsubscribe from selected contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUnsubscribe_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed || cbSymbol.SelectedContract == null)
                return;

            try
            {
                OECClient.Global.Unsubscribe(cbSymbol.SelectedContract);
                lvQuotes.Items.RemoveByKey(cbSymbol.SelectedContract.Symbol);
                RefreshSubscribeButtonStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't unsubscribe contract. " + ex.Message);
            }
        }

        /// <summary>
        ///     Occurs when selected contract changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSymbol.SelectedContract == null)
                return;
            RefreshSubscribeButtonStatus();
        }

        /// <summary>
        ///     Refreshes Subscribe and Unsubscribe buttons statuses. If list of subscribed contracts contains selected contract,
        ///     then make Unsubscribe button available
        /// </summary>
        private void RefreshSubscribeButtonStatus()
        {
            btSubscribe.Enabled = cbSymbol.SelectedContract != null &&
                                  !lvQuotes.Items.ContainsKey(cbSymbol.SelectedContract.Symbol);
            btUnsubscribe.Enabled = !btSubscribe.Enabled;
        }

        /// <summary>
        ///     Matches the selected contract in the combo, when a user clicks on the DataGrid with quotes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvQuotes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            cbSymbol.SelectedItem = e.Item.Tag;
        }
    }
}
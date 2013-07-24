using System;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Provides visual controls for fullfilling Order.
    /// </summary>
    public partial class OrderDraftControl : BaseControl
    {
        /// <summary>
        ///     Creates Order draft control
        /// </summary>
        public OrderDraftControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Preparing login complete event handler
        /// </summary>
        protected override void PrepareControlEventHandlers()
        {
            base.PrepareControlEventHandlers();
            OECClient.Global.OnLoginComplete += OnLoginComplete;
        }


        /// <summary>
        ///     Makes some preparetions when login complete  succsessfull
        /// </summary>
        private void OnLoginComplete()
        {
            PrepareFlags();
            PrepareOrderTypes();
        }

        /// <summary>
        ///     Reads order side from radiobox
        /// </summary>
        /// <returns></returns>
        private OrderSide GetOrderSide()
        {
            if (rbBuy.Checked)
                return OrderSide.Buy;
            if (rbSell.Checked)
                return OrderSide.Sell;
            return OrderSide.None;
        }


        /// <summary>
        ///     Prepares Order types selection combo
        /// </summary>
        private void PrepareOrderTypes()
        {
            cbOrderType.Items.AddRange(new object[]
            {
                OrderType.Market,
                OrderType.Limit,
                OrderType.Stop,
                OrderType.StopLimit,
                OrderType.MarketOnOpen,
                OrderType.MarketOnClose,
                OrderType.MarketOnPitOpen,
                OrderType.MarketOnPitClose,
                OrderType.Iceberg
            });
        }

        /// <summary>
        ///     Prepares flag selection combo
        /// </summary>
        private void PrepareFlags()
        {
            cbFlags.Items.AddRange(new object[]
            {
                OrderFlags.None,
                OrderFlags.GTC,
                OrderFlags.FOK,
                OrderFlags.IOC
            });

            cbFlags.SelectedIndex = 0;
        }

        /// <summary>
        ///     Gets order draft data from UI controls
        /// </summary>
        /// <param name="draft">Existing order draft for modifying. If null, new order will be created. </param>
        /// <param name="comments">Order comments</param>
        /// <returns>Returns created or modified order draft. Returns null if impossible to read draft from UI</returns>
        protected OrderDraft GetOrderDraft(OrderDraft draft, string comments)
        {
            if (cbSymbol.SelectedContract == null)
                return null;

            int qty;
            if (!int.TryParse(cbQty.Text, out qty))
                return null;

            if (!rbBuy.Checked && !rbSell.Checked)
                return null;

            if (cbOrderType.SelectedItem == null)
                return null;

            if (cbFlags.SelectedItem == null)
                return null;

            if (!(draft is ModifyOrderDraft)) // if draft is not modify draft (but new order draft)
            {
                if (string.IsNullOrEmpty(comments))
                {
                    return null;
                }

                draft.Contract = cbSymbol.SelectedContract;
                Globals.SetDraftAccount(draft);
                draft.Flags = (OrderFlags) cbFlags.SelectedItem;
                draft.Side = GetOrderSide();
                draft.Comments = comments;
            }


            draft.Quantity = qty;

            int volume = 0;
            if (cbVolume.Text.Trim() != string.Empty)
                if (!int.TryParse(cbVolume.Text, out volume))
                    return null;

            double price = 0;
            double price2 = 0;
            if (edPrice.Text.Trim() != string.Empty)
                if (!double.TryParse(edPrice.Text, out price))
                    return null;
            if (edPrice2.Text.Trim() != string.Empty)
                if (!double.TryParse(edPrice2.Text, out price2))
                    return null;

            draft.ClearExtData();

            draft.Type = (OrderType) cbOrderType.SelectedItem;

            if ((OrderType) cbOrderType.SelectedItem == OrderType.Iceberg)
                draft.SetIcebergData(volume);

            draft.Start = cbTimeStart.Checked ? cbTimeStart.Value.ToUniversalTime() : Version.MinimumStart;
            draft.End = cbTimeEnd.Checked ? cbTimeEnd.Value.ToUniversalTime() : Version.MaximumEnd;
            draft.Price = price;
            draft.Price2 = price2;

            //checks invalid parts
            OrderParts invParts = draft.GetInvalidParts();
            if (invParts != OrderParts.None)
            {
                MessageBox.Show(string.Format("Check : {0}", invParts));
                return null;
            }

            return draft;
        }

        /// <summary>
        ///     Sets UI controls values from order item
        /// </summary>
        /// <param name="order">Order to take data from</param>
        protected void SetDraftFromOrder(Order order)
        {
            rbBuy.Checked = (order.Side == OrderSide.Buy);
            rbSell.Checked = (order.Side == OrderSide.Sell);
            cbQty.Text = order.Quantity.ToString();
            cbSymbol.SelectedContract = order.Contract;
            cbSymbol.Refresh();

            cbOrderType.SelectedItem = order.Type;
            cbFlags.SelectedItem = order.Flags;
            edPrice.Text = order.Price.ToString();
            edPrice2.Text = order.Price2.ToString();

            cbTimeStart.Checked = (order.Versions.Current.Start > Version.MinimumStart + TimeSpan.FromDays(1000));
            if (cbTimeStart.Checked)
                cbTimeStart.Value = order.Versions.Current.Start.ToLocalTime();

            cbTimeEnd.Checked = (order.Versions.Current.End < Version.MaximumEnd - TimeSpan.FromDays(1000));
            if (cbTimeEnd.Checked)
                cbTimeEnd.Value = order.Versions.Current.End.ToLocalTime();
        }

        /// <summary>
        ///     Clears controls
        /// </summary>
        protected void ClearOrderDraft()
        {
            rbBuy.Checked = false;
            rbSell.Checked = false;
            cbSymbol.SelectedContract = null;
            cbQty.Text = string.Empty;

            cbFlags.SelectedItem = null;
            cbOrderType.SelectedItem = 0;
            cbVolume.Text = string.Empty;
            edPrice.Text = string.Empty;
            edPrice2.Text = string.Empty;
            cbTimeEnd.Checked = cbTimeStart.Checked = false;
        }

        /// <summary>
        ///     Changes Price selection area, when Order type is reselected
        /// </summary>
        private void cbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            edPrice.Visible = edPrice2.Visible = cbVolume.Visible =
                lbPrice.Visible = lbPrice2.Visible = lbVolume.Visible = false;

            lbPrice.Text = "Stop";

            switch ((OrderType) cbOrderType.SelectedItem)
            {
                case OrderType.Limit:
                    lbPrice.Visible = edPrice.Visible = true;
                    lbPrice.Text = "Limit";
                    break;
                case OrderType.Stop:
                    lbPrice.Visible = edPrice.Visible = true;
                    lbPrice.Visible = edPrice.Visible = true;
                    lbPrice.Text = "Stop";
                    break;
                case OrderType.StopLimit:
                    lbPrice.Visible = lbPrice2.Visible = edPrice.Visible = edPrice2.Visible = true;
                    lbPrice.Text = "Stop";
                    lbPrice2.Text = "Limit";
                    break;
                case OrderType.Iceberg:
                    lbPrice.Visible = edPrice.Visible = lbVolume.Visible = cbVolume.Visible = true;
                    lbPrice.Text = "Limit";
                    break;
            }
        }

        /// <summary>
        ///     Sets current price to price control if subscribed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSymbol_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSymbol.SelectedContract == null)
                return;

            edPrice.Text = string.Empty;

            if (cbSymbol.SelectedContract.CurrentPrice != null)
                edPrice.Text = cbSymbol.SelectedContract.CurrentPrice.LastPrice.ToString();
        }
    }
}
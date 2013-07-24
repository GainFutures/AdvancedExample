using System;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Orders control. Provides submiting, modifiyng, canceling orders. Also OCO and Linked orders are supported
    /// </summary>
    public partial class OrdersControl : OrderDraftControl
    {
        /// <summary>
        ///     Orders control constructor
        /// </summary>
        public OrdersControl()
        {
            InitializeComponent();
            Caption = "Orders";
        }

        /// <summary>
        ///     Submit contract sending contract to server
        /// </summary>
        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;
            try
            {
                OrderDraft draft = GetOrderDraft(OECClient.Global.CreateDraft(), "Regular");
                if (draft == null)
                    return;

                if (
                    MessageBox.Show("Send order " + draft, "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) ==
                    DialogResult.No)
                    return;

                OECClient.Global.SendOrder(draft);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending order : " + ex.Message);
            }
        }

        /// <summary>
        ///     Clears controls, preparing new order, when New button clicked
        /// </summary>
        private void btNew_Click(object sender, EventArgs e)
        {
            ClearOrderDraft();
        }

        /// <summary>
        ///     Cancels selected order
        /// </summary>
        private void btCancel_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (orderList.SelectedOrder == null)
                return;

            Order order = orderList.SelectedOrder;

            if (
                MessageBox.Show("Cancel order #" + order.ID, "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            OECClient.Global.CancelOrder(order);
        }

        /// <summary>
        ///     Modifying selected order
        /// </summary>
        private void btModify_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (orderList.SelectedOrder == null)
                return;

            Order selectedOrder = orderList.SelectedOrder;

            ModifyOrderDraft selectedOrderDraft = OECClient.Global.CreateDraft(selectedOrder);

            OrderDraft newOrderDraft = GetOrderDraft(selectedOrderDraft, null);


            if (newOrderDraft == null)
                return;

            if (
                MessageBox.Show("Modify order '" + selectedOrder + "' with '" + newOrderDraft + "'", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            OECClient.Global.ModifyOrder(newOrderDraft);
        }

        /// <summary>
        ///     Occurs when current order changed
        /// </summary>
        public event CurrentOrderChangedEventHandler OnCurrentOrderChanged;

        /// <summary>
        ///     Occurs when current selected order is changed
        /// </summary>
        private void orderList_SelectedOrderChanged(Order currentOrder)
        {
            pnlOrderLinks.UpdateOrder(currentOrder);
            if (currentOrder != null)
            {
                SetDraftFromOrder(currentOrder);
                OnCurrentOrderChanged(currentOrder);
            }
        }

        /// <summary>
        ///     Sends OCO orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSendOCO_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            //Creating fist draft
            OrderDraft draft1 = GetOrderDraft(OECClient.Global.CreateDraft(), "OCO");
            if (draft1 == null)
                return;

            //First draft is of LMT
            double priceLimitLegPrice;
            if (!double.TryParse(edLimitLegPrice.Text, out priceLimitLegPrice))
                return;
            draft1.Type = OrderType.Limit;
            draft1.Price = priceLimitLegPrice;

            //Creating second draft
            OrderDraft draft2 = OECClient.Global.CreateDraft();
            draft2.Quantity = draft1.Quantity;
            draft2.Contract = draft1.Contract;
            draft2.Side = draft1.Side;
            Globals.SetDraftAccount(draft2);
            draft2.Comments = "OCO";

            //Second draft is of STP
            double priceStopLegPrice;
            if (!double.TryParse(edStopLegPrice.Text, out priceStopLegPrice))
                return;
            draft2.Type = OrderType.Stop;
            draft2.Price = priceStopLegPrice;

            if (
                MessageBox.Show("Send OCO orders \n" + draft1 + "\n" + draft2, "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            try
            {
                OECClient.Global.SendOCOOrders(new[] {draft1, draft2});
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending order : " + ex.Message);
            }
        }

        /// <summary>
        ///     Sends Linked orders
        /// </summary>
        private void btSendBracket_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            //Creating fist draft
            OrderDraft mainOrder = GetOrderDraft(OECClient.Global.CreateDraft(), "OSO");
            if (mainOrder == null)
                return;

            OrderDraft draft1 = OECClient.Global.CreateDraft();
            OrderDraft draft2 = OECClient.Global.CreateDraft();

            draft1.Quantity = draft2.Quantity = mainOrder.Quantity;
            draft1.Contract = draft2.Contract = mainOrder.Contract;

            Globals.SetDraftAccount(draft1);
            Globals.SetDraftAccount(draft2);

            bool isLimitOrderFullfilled = FullfillLimitDraft(mainOrder, draft1);

            bool isStopOrderFullfilled = FullfillStopDraft(mainOrder, draft2);

            if (!isLimitOrderFullfilled && !isStopOrderFullfilled)
                return;

            try
            {
                if (isLimitOrderFullfilled && isStopOrderFullfilled)
                {
                    if (
                        MessageBox.Show("Send linked orders \n" + mainOrder + "\n" + draft1 + "\n" + draft2,
                            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                        return;

                    OECClient.Global.SendLinkedOrders(mainOrder, draft1, draft2);
                }
                else
                {
                    OrderDraft oneDraft = isLimitOrderFullfilled ? draft1 : draft2;

                    if (
                        MessageBox.Show("Send linked orders \n" + mainOrder + "\n" + oneDraft, "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                        return;

                    OECClient.Global.SendLinkedOrders(mainOrder, oneDraft);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending orders : " + ex.Message);
            }
        }

        /// <summary>
        ///     Fullfills limit order for Bracket
        /// </summary>
        /// <param name="mainOrder">Main order of bracket</param>
        /// <param name="draft">order draft to fullfill</param>
        /// <returns>true if order fullfilled, otherwise false</returns>
        private bool FullfillLimitDraft(OrderDraft mainOrder, OrderDraft draft)
        {
            draft.Comments = "OSO";
            draft.Type = OrderType.Limit;
            double limitPriceFactor;
            if (!double.TryParse(edLimitFactor.Text, out limitPriceFactor))
            {
                return false;
            }

            draft.Side = GetOppositeSide(mainOrder);

            if (draft.Side == OrderSide.Buy)
                draft.Price = mainOrder.Price - limitPriceFactor;
            else
                draft.Price = mainOrder.Price + limitPriceFactor;

            return true;
        }

        /// <summary>
        ///     Fullfills stop order for Bracket
        /// </summary>
        /// <param name="mainOrder">Main order of bracket</param>
        /// <param name="draft">Order draft to fullfill</param>
        /// <returns>True if order fullfilled, otherwise false</returns>
        private bool FullfillStopDraft(OrderDraft mainOrder, OrderDraft draft)
        {
            draft.Comments = "OSO";
            draft.Type = OrderType.Stop;
            double stopPriceFactor;
            if (!double.TryParse(edStopFactor.Text, out stopPriceFactor))
            {
                return false;
            }

            draft.Side = GetOppositeSide(mainOrder);

            if (draft.Side == OrderSide.Buy)
                draft.Price = mainOrder.Price + stopPriceFactor;
            else
                draft.Price = mainOrder.Price - stopPriceFactor;

            return true;
        }

        /// <summary>
        ///     Gets opposite side from order
        /// </summary>
        /// <param name="mainOrder">Order</param>
        /// <returns>Opposide side of order</returns>
        private OrderSide GetOppositeSide(OrderDraft mainOrder)
        {
            if (mainOrder.Side == OrderSide.Sell)
                return OrderSide.Buy;
            return OrderSide.Sell;
        }

        /// <summary>
        ///     Handles order navigation event and updates order list to the navigated order.
        /// </summary>
        /// <param name="target">Target order</param>
        private void pnlOrderLinks_OrderLinkNavigated(Order target)
        {
            orderList.SelectedOrder = target;
        }
    }

    /// <summary>
    ///     Represents event handler
    /// </summary>
    /// <param name="currentOrder">New order</param>
    public delegate void CurrentOrderChangedEventHandler(Order currentOrder);
}
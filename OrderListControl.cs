using System;
using System.Windows.Forms;
using OEC.Data;

namespace OEC.API.Example
{
    /// <summary>
    ///     Order list control. Maintains list of current orders in system
    /// </summary>
    public partial class OrderListControl : UserControl
    {
        /// <summary>
        ///     Construct order list control
        /// </summary>
        public OrderListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Current selected order
        /// </summary>
        public Order SelectedOrder
        {
            get { return lvOrders.FocusedItem != null ? (Order) lvOrders.FocusedItem.Tag : null; }
            set
            {
                if (value == null)
                {
                    return;
                }

                foreach (object i in lvOrders.Items)
                {
                    var item = i as ListViewItem;
                    if (item != null)
                    {
                        var order = item.Tag as Order;

                        if (order != null)
                        {
                            if (order.ID == value.ID)
                            {
                                lvOrders.FocusedItem = item;
                            }
                            item.Selected = order.ID == value.ID;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Prepares events
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            if (OECClient.Global != null) //design mode exceptions
            {
                OECClient.Global.OnLoginComplete += UpdateOrders;
                OECClient.Global.OnOrderConfirmed += OECClient_OnOrderConfirmed;
                OECClient.Global.OnOrderFilled += OECClient_OnOrderFilled;
                OECClient.Global.OnOrderStateChanged += OECClient_OnOrderStateChanged;
                OECClient.Global.OnCommandUpdated += OECClient_OnCommandUpdated;
                if (OECClient.Global.CompleteConnected)
                    UpdateOrders();
            }
        }

        /// <summary>
        ///     Updates orders control
        /// </summary>
        public void UpdateOrders()
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            lvOrders.BeginUpdate();

            lvOrders.Items.Clear();
            foreach (Order order in OECClient.Global.Orders.Values)
            {
                if (order.IsOsmRoot)
                    continue;

                var item = new ListViewItem(order.ID.ToString()) {Tag = order};
                item.SubItems.Add(GetAccountOrAB(order));
                item.SubItems.Add(order.Side.ToString());
                item.SubItems.Add(order.Contract.ToString());
                item.SubItems.Add(order.Quantity.ToString());
                item.SubItems.Add(order.CurrentState.ToString());
                item.SubItems.Add(order.TypePriceString);
                item.SubItems.Add(order.Timestamp.ToLocalTime().ToString("HH:mm:ss.fff"));
                item.SubItems.Add(order.Comments);

                lvOrders.Items.Insert(0, item);
            }

            lvOrders.EndUpdate();

            if (lvOrders.Items.Count > 0 && SelectedOrderChanged != null)
                SelectedOrderChanged((Order) lvOrders.Items[0].Tag);
        }

        /// <summary>
        ///     Gets account or allocation block of orders, depends on which is specified
        /// </summary>
        /// <param name="order">Analized order</param>
        /// <returns>Returns string representation of allocation block or account</returns>
        public static string GetAccountOrAB(Order order)
        {
            if (order.Account != null)
                return order.Account.ToString();

            if (order.AllocationBlock != null)
                return order.AllocationBlock.ToString();

            return string.Empty;
        }

        /// <summary>
        ///     Updates Order control when command updated
        /// </summary>
        private void OECClient_OnCommandUpdated(Order order, Command command)
        {
            UpdateOrders();
        }

        /// <summary>
        ///     Updates Order control when state of order is changed
        /// </summary>
        private void OECClient_OnOrderStateChanged(Order order, OrderState oldOrderState)
        {
            UpdateOrders();
        }

        /// <summary>
        ///     Updates Order control when order is filled
        /// </summary>
        private void OECClient_OnOrderFilled(Order order, Fill fill)
        {
            UpdateOrders();
        }

        /// <summary>
        ///     Updates Order control when order is confirmed
        /// </summary>
        private void OECClient_OnOrderConfirmed(Order order, int oldOrderID)
        {
            UpdateOrders();
        }

        /// <summary>
        ///     Occurs when selected order changes
        /// </summary>
        public event CurrentOrderChangedEventHandler SelectedOrderChanged;

        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrderChanged != null)
                SelectedOrderChanged(SelectedOrder);
        }
    }
}
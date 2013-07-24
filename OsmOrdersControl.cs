using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OEC.API.OSM;
using OEC.API.OSM.Info;
using OEC.Data;
using AlgoParam = OEC.API.OSM.Info.AlgoParam;
using IAlgoParams = OEC.API.OSM.Info.IAlgoParams;

namespace OEC.API.Example
{
    /// <summary>
    ///     OSM orders control. Provides submiting, modifiyng and canceling OSM orders.
    /// </summary>
    public partial class OsmOrdersControl : OrderDraftControl
    {
        private const int ParamNameColumnIndex = 0;
        private const int ParamValueColumnIndex = 1;

        /// <summary>
        ///     Creates an instance of OsmOrdersControl.
        /// </summary>
        public OsmOrdersControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Occurs when current order changed
        /// </summary>
        public event CurrentOrderChangedEventHandler OnCurrentOrderChanged;

        /// <summary>
        ///     Prepares handlers for global API events.
        /// </summary>
        public void PrepareEventHandlers()
        {
            OECClient.Global.OnOrderConfirmed += OECClient_OnOrderConfirmed;
            OECClient.Global.OnOrderFilled += OECClient_OnOrderFilled;
            OECClient.Global.OnOrderStateChanged += OECClient_OnOrderStateChanged;
            OECClient.Global.OnCommandUpdated += OECClient_OnCommandUpdated;
            OECClient.Global.OnLoginComplete += OECClient_OnLoginComplete;
            OECClient.Global.OnDisconnected += OECClient_OnDisconnected;

            OECClient.Global.OnOsmAlgoListLoaded += OECClient_OnOsmAlgoListLoaded;
            OECClient.Global.OnOsmAlgoListUpdated += OECClient_OnOsmAlgoListUpdated;
        }

        /// <summary>
        ///     Clears controls when connection to OEC server is closed or lost.
        /// </summary>
        private void OECClient_OnDisconnected(bool unexpected)
        {
            FillAlgorithms(null);
            FillOrders(null);

            if (OnCurrentOrderChanged != null)
                OnCurrentOrderChanged(null);
        }

        /// <summary>
        ///     Requests updated list of OSM algorithms from the OEC server.
        /// </summary>
        private void OECClient_OnOsmAlgoListUpdated()
        {
            OECClient.Global.LoadOsmAlgoList();
        }

        /// <summary>
        ///     Updates the list of OSM algorithms when the list is loaded from OEC server.
        /// </summary>
        private void OECClient_OnOsmAlgoListLoaded(IAlgoList algoList)
        {
            lvOrders.SelectedItems.Clear();
            FillAlgorithms(algoList.Items);
        }

        /// <summary>
        ///     Updates the list of orders.
        ///     Requests a list of available OSM algorithms from OEC server.
        /// </summary>
        private void OECClient_OnLoginComplete()
        {
            FillAlgorithms(null);
            FillOrders(OECClient.Global.Orders.Values);

            OECClient.Global.LoadOsmAlgoList();
        }

        /// <summary>
        ///     Fills orders ListView control.
        /// </summary>
        private void FillOrders(IEnumerable<Order> orders)
        {
            try
            {
                lvOrders.BeginUpdate();

                lvOrders.Items.Clear();

                if (orders == null)
                    return;

                foreach (Order order in orders)
                {
                    if (!order.IsOsmRoot)
                        continue;

                    var item = new ListViewItem();
                    FillOrderItem(item, order);
                    lvOrders.Items.Insert(0, item);
                }
            }
            finally
            {
                lvOrders.EndUpdate();
            }
        }

        /// <summary>
        ///     Finds an item in orders ListView control for the specified order ID.
        /// </summary>
        private ListViewItem FindOrderItem(int orderId)
        {
            foreach (object i in lvOrders.Items)
            {
                var item = (ListViewItem) i;
                var order = (Order) item.Tag;
                if (order.ID == orderId)
                    return item;
            }

            return null;
        }

        /// <summary>
        ///     Updates order item in the order ListView control.
        ///     Raises an event current order changed.
        /// </summary>
        private void UpdateOrder(Order order)
        {
            ListViewItem item = FindOrderItem(order.ID);
            if (item == null)
                return;

            FillOrderItem(item, order);

            if (OnCurrentOrderChanged != null)
                OnCurrentOrderChanged(order);
        }

        /// <summary>
        ///     Updates order item in the order ListView control when some command event occurs for an order.
        /// </summary>
        private void OECClient_OnCommandUpdated(Order order, Command command)
        {
            if (!order.IsOsmRoot)
                return;

            UpdateOrder(order);
        }

        /// <summary>
        ///     Updates order item in the order ListView control when order state is changed.
        /// </summary>
        private void OECClient_OnOrderStateChanged(Order order, OrderState oldOrderState)
        {
            if (!order.IsOsmRoot)
                return;

            UpdateOrder(order);
        }

        /// <summary>
        ///     Updates order item in the order ListView control when a fill is received for an order.
        /// </summary>
        private void OECClient_OnOrderFilled(Order order, Fill fill)
        {
            if (!order.IsOsmRoot)
                return;

            UpdateOrder(order);
        }

        /// <summary>
        ///     Adds new order to the order ListView control after the order confirmed by OEC server.
        /// </summary>
        private void OECClient_OnOrderConfirmed(Order order, int oldOrderID)
        {
            if (!order.IsOsmRoot)
                return;

            var item = new ListViewItem();
            FillOrderItem(item, order);
            lvOrders.Items.Insert(0, item);
        }

        /// <summary>
        ///     Fills the specified subitems with the specified texts.
        /// </summary>
        private static void FillSubItems(ListViewItem.ListViewSubItemCollection subItems, IEnumerable<string> texts)
        {
            int i = 0;
            foreach (string text in texts)
            {
                if (subItems.Count > i)
                    subItems[i].Text = text;
                else
                    subItems.Add(text);

                ++i;
            }
        }

        /// <summary>
        ///     Fills the specified ListViewItem by order properties.
        /// </summary>
        private static void FillOrderItem(ListViewItem item, Order order)
        {
            if (item == null || order == null)
                return;

            item.Tag = order;

            FillSubItems(item.SubItems, new[]
            {
                order.ID.ToString(),
                OrderListControl.GetAccountOrAB(order),
                order.Side.ToString(),
                order.Contract.ToString(),
                order.Quantity.ToString(),
                order.CurrentState.ToString(),
                order.TypePriceString,
                order.Timestamp.ToLocalTime().ToString("HH:mm:ss.fff"),
                order.Comments
            });
        }


        /// <summary>
        ///     Fills ComboBox control of OSM algorithms.
        /// </summary>
        private void FillAlgorithms(IEnumerable<IAlgo> algorithms)
        {
            cbOsmAlgo.Enabled = true;
            cbOsmAlgo.Items.Clear();

            FillAlgoParams(null as IAlgoParams);
            FillAlgoOrderFlags(null);
            FillAlgoOrderTypes(null);

            if (algorithms == null)
                return;

            foreach (IAlgo algo in algorithms)
            {
                cbOsmAlgo.Items.Add(algo.AlgoName);
            }

            if (cbOsmAlgo.Items.Count > 0)
                cbOsmAlgo.SelectedIndex = 0;
        }

        /// <summary>
        ///     Fills ListView control of OSM algo params.
        /// </summary>
        private void FillAlgoParams(IEnumerable<AlgoParam> algoParams)
        {
            lvOsmAlgoParams.Items.Clear();

            if (algoParams == null)
                return;

            foreach (AlgoParam param in algoParams)
            {
                if (!param.Enabled)
                    continue;

                var item = new ListViewItem();
                FillAlgoParamItem(item, param.Name, param.DataDomain.Default.StringValue);

                lvOsmAlgoParams.Items.Add(item);
            }

            lvOsmAlgoParams.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        ///     Fills ListView control of OSM algo params.
        /// </summary>
        private void FillAlgoParams(IEnumerable<IAlgoParam> algoParams)
        {
            lvOsmAlgoParams.Items.Clear();

            if (algoParams == null)
                return;

            foreach (IAlgoParam param in algoParams)
            {
                var item = new ListViewItem();
                FillAlgoParamItem(item, param.Name, param.StringValue);

                lvOsmAlgoParams.Items.Add(item);
            }

            lvOsmAlgoParams.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        ///     Fills an item of OSM algo params ListView.
        /// </summary>
        private static void FillAlgoParamItem(ListViewItem item, string name, string value)
        {
            item.ToolTipText = "Double-click to edit OSM algo param.";
            FillSubItems(item.SubItems, new[] {name, value});
        }

        /// <summary>
        ///     Fills ComboBox control of OSM algo order types.
        /// </summary>
        private void FillAlgoOrderTypes(IEnumerable<OrderType> orderTypes)
        {
            cbOrderType.Items.Clear();

            if (orderTypes == null)
                return;

            foreach (OrderType type in orderTypes)
            {
                cbOrderType.Items.Add(type);
            }

            if (cbOrderType.Items.Count > 0)
                cbOrderType.SelectedIndex = 0;
        }

        /// <summary>
        ///     Fills ComboBox control of OSM algo order flags.
        /// </summary>
        private void FillAlgoOrderFlags(IEnumerable<OrderFlags> orderFlags)
        {
            cbFlags.Items.Clear();

            if (orderFlags == null)
                return;

            foreach (OrderFlags flag in orderFlags)
            {
                cbFlags.Items.Add(flag);
            }

            if (cbFlags.Items.Count > 0)
                cbFlags.SelectedIndex = 0;
        }

        /// <summary>
        ///     Updates the selected OSM algorithm and its related data (parameters, order types and order flags).
        /// </summary>
        private void cbOsmAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAlgoParams(null as IAlgoParams);
            FillAlgoOrderTypes(null);
            FillAlgoOrderFlags(null);

            if (cbOsmAlgo.SelectedItem == null)
                return;

            var algoName = (string) cbOsmAlgo.SelectedItem;
            IAlgo algoInfo = OECClient.Global.OsmAlgoList[algoName];

            FillAlgoParams(algoInfo.Params);
            FillAlgoOrderTypes(algoInfo.OrderTypes);
            FillAlgoOrderFlags(algoInfo.OrderFlags);
        }

        /// <summary>
        ///     Displays a dialog for editing the value of the selected OSM algo param.
        /// </summary>
        private void lvOsmAlgoParams_DoubleClick(object sender, EventArgs e)
        {
            if (cbOsmAlgo.SelectedItem == null)
                return;

            if (lvOsmAlgoParams.SelectedItems.Count != 1)
                return;

            var algoName = (string) cbOsmAlgo.SelectedItem;
            IAlgo algoInfo = OECClient.Global.OsmAlgoList[algoName];

            ListViewItem item = lvOsmAlgoParams.SelectedItems[0];
            string paramName = item.SubItems[ParamNameColumnIndex].Text;
            string paramValue = item.SubItems[ParamValueColumnIndex].Text;

            AlgoParam paramInfo = algoInfo.Params[paramName];
            paramValue = EditAlgoParamValue(paramInfo, paramValue);

            FillAlgoParamItem(item, paramName, paramValue);
        }

        /// <summary>
        ///     Edits the specified value of an OSM algo param.
        /// </summary>
        private string EditAlgoParamValue(AlgoParam paramInfo, string paramValue)
        {
            var dlg = new OsmAlgoParamDlg(paramInfo, paramValue);
            return dlg.ShowDialog() == DialogResult.OK ? dlg.ParamValue : paramValue;
        }

        /// <summary>
        ///     Assigns OSM instructions from UI as extended data of an order to the specified draft.
        /// </summary>
        private void AssignOsmExtData(OrderDraft draft)
        {
            if (cbOsmAlgo.SelectedItem == null)
                return;

            var algoName = (string) cbOsmAlgo.SelectedItem;
            IAlgo algoInfo = OECClient.Global.OsmAlgoList[algoName];

            var algoParams = new AlgoParams();
            foreach (object i in lvOsmAlgoParams.Items)
            {
                var item = (ListViewItem) i;

                string paramName = item.SubItems[ParamNameColumnIndex].Text;
                string paramValue = item.SubItems[ParamValueColumnIndex].Text;

                algoParams.AddParam(new OSM.AlgoParam(paramName, paramValue));
            }

            draft.ExtData = new RootOrder(algoInfo.AlgoName, algoParams);
            algoInfo.ValidateRootDraft(draft);
        }

        /// <summary>
        ///     Creates an OSM order draft and submits new OSM order.
        /// </summary>
        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            try
            {
                OrderDraft draft = GetOrderDraft(OECClient.Global.CreateDraft(), "OSM");
                if (draft == null)
                    return;

                AssignOsmExtData(draft);

                string s = "Send order " + draft + Environment.NewLine +
                           (draft.ExtData != null ? draft.ExtData.ToString() : string.Empty);
                if (MessageBox.Show(s, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
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
            if (OECClient.Global.ConnectionClosed)
                return;

            lvOrders.SelectedItems.Clear();
            ClearOrderDraft();
            FillAlgorithms(OECClient.Global.OsmAlgoList.Items);
        }

        /// <summary>
        ///     Creates an OSM modification draft and sends modify command.
        /// </summary>
        private void btModify_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (lvOrders.SelectedItems.Count != 1)
                return;

            ListViewItem item = lvOrders.SelectedItems[0];
            var order = (Order) item.Tag;

            OrderDraft draft = OECClient.Global.CreateDraft(order);
            draft = GetOrderDraft(draft, null);

            if (draft == null)
                return;

            AssignOsmExtData(draft);

            string s = "Modify order '" + order + "'" + Environment.NewLine +
                       (order.ExtData != null ? order.ExtData.ToString() : string.Empty) + Environment.NewLine +
                       Environment.NewLine +
                       " with " + Environment.NewLine + Environment.NewLine +
                       "'" + draft + "'" + Environment.NewLine +
                       (draft.ExtData != null ? draft.ExtData.ToString() : string.Empty);

            if (MessageBox.Show(s, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            OECClient.Global.ModifyOrder(draft);
        }

        /// <summary>
        ///     Updates UI controls from the selected order and switches UI into order modification mode.
        /// </summary>
        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (lvOrders.SelectedItems.Count != 1)
            {
                FillAlgorithms(OECClient.Global.OsmAlgoList.Items);

                if (OnCurrentOrderChanged != null)
                    OnCurrentOrderChanged(null);

                return;
            }

            ListViewItem item = lvOrders.SelectedItems[0];
            var order = (Order) item.Tag;

            var extData = order.ExtData as RootOrder;

            if (extData != null)
            {
                cbOsmAlgo.SelectedItem = extData.AlgoName;
                cbOsmAlgo.Enabled = false;

                FillAlgoParams(extData.AlgoParams);
            }

            SetDraftFromOrder(order);

            if (OnCurrentOrderChanged != null)
                OnCurrentOrderChanged(order);
        }

        /// <summary>
        ///     Cancels selected order
        /// </summary>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            if (lvOrders.SelectedItems.Count != 1)
                return;

            ListViewItem item = lvOrders.SelectedItems[0];
            var order = (Order) item.Tag;

            if (
                MessageBox.Show("Cancel OSM order #" + order.ID, "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            OECClient.Global.CancelOrder(order);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OEC.API;

namespace TraderLight
{
    public partial class OrdersOCOControl : TraderLight.OrderSimpleDraftControl
    {
        public OrdersOCOControl()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            //Creating fist draft
            OrderDraft draft1 = GetOrderDraft();
            if (draft1 == null)
                return;

            //Creating second draft
            OrderDraft draft2 = OECClient.Global.CreateDraft();
            draft2.Quantity = draft1.Quantity;
            draft2.Contract = draft1.Contract;
            draft2.Side = draft1.Side;
            draft2.Account = OECClient.Global.Accounts.First;

            //First draft is of LMT
            double priceFirstLegLimit = double.NaN;
            if (!double.TryParse(edFirstLegLimit.Text, out priceFirstLegLimit))
                return;
            draft1.Price = priceFirstLegLimit;
            draft1.Type = OEC.Data.OrderType.Limit;

            //Second draft is of LMT or STOP LMT
            //fullfills stop price
            double priceSecondLegStop = double.NaN;            
            if (!double.TryParse(edSecondLegStop.Text, out priceSecondLegStop))
                return;
            draft2.Price = priceSecondLegStop;

            //fullfils limit price if order is of STOP LMT type
            if (edSecondLegLimit.Text.Trim() == string.Empty)
                draft2.Type = OEC.Data.OrderType.Stop;
            else
            {
                draft2.Type = OEC.Data.OrderType.StopLimit;

                double priceSecondLegLimit = double.NaN;
                if (!double.TryParse(edSecondLegLimit.Text, out priceSecondLegLimit))
                        return;

                draft2.Price2 = priceSecondLegLimit;
            }

            if (MessageBox.Show("Send OCO orders \n" + draft1.ToString() + "\n" + draft2.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            try
            {
                
                

                OECClient.Global.SendOCOOrders(new OrderDraft[] { draft1, draft2 });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending order : " + ex.Message);
            }
        }


        /*
        #region advanced orders
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            OrderDraft draft = GetOrderDraft(OECClient.Global.CreateDraft());
            if (draft == null)
                return;

            lbOrderList.Items.Add(draft);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lbOrderList.Items.Clear();
        }

        private void btSendOCO_Click(object sender, EventArgs e)
        {
            if (lbOrderList.Items.Count < 2 || OECClient.Global.ConnectionClosed)
                return;
            string orders = GetOrderNames();
            if (MessageBox.Show("Send OCO orders \n" + orders, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;
            try
            {
                OECClient.Global.SendOCOOrders(GetOrdersArray(0));
                lbOrderList.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending order : " + ex.Message);
            }
        }

        private void btSendLinked_Click(object sender, EventArgs e)
        {
            if (lbOrderList.Items.Count < 2 || OECClient.Global.ConnectionClosed)
                return;
            string orders = GetOrderNames();
            if (MessageBox.Show("Send Linked orders \n" + orders, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;
            try
            {
                OECClient.Global.SendLinkedOrders((OrderDraft)lbOrderList.Items[0], GetOrdersArray(1));
                lbOrderList.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending order : " + ex.Message);
            }
        }

        private OrderDraft[] GetOrdersArray(int index)
        {
            OrderDraft[] arr = new OrderDraft[lbOrderList.Items.Count - index];
            for (int i = 0; i < lbOrderList.Items.Count - index; i++)
                arr[i] = (OrderDraft)lbOrderList.Items[i + index];
            return arr;
        }

        private string GetOrderNames()
        {
            string orders = string.Empty;
            foreach (object order in lbOrderList.Items)
            {
                orders += ((OrderDraft)order).ToString() + "\n";
            }
            return orders;
        }

        #endregion
        */
    }
}


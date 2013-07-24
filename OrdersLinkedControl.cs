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
    public partial class OrdersLinkedControl : TraderLight.OrderDraftControl
    {
        public OrdersLinkedControl()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (OECClient.Global.ConnectionClosed)
                return;

            //Creating fist draft
            OrderDraft mainOrder = GetOrderDraft();
            if (mainOrder == null)
                return;

            OrderDraft draft1 = OECClient.Global.CreateDraft();
            OrderDraft draft2 = OECClient.Global.CreateDraft();
            draft1.Account = draft2.Account = OECClient.Global.Accounts.First;

            draft1.Quantity = draft2.Quantity = mainOrder.Quantity;
            draft1.Contract = draft2.Contract = mainOrder.Contract;
            
            bool isLimitOrderFullfilled = FullfillLimitDraft(mainOrder, draft1);

            bool isStopOrderFullfilled = FullfillStopDraft(mainOrder, draft2);

            if (!isLimitOrderFullfilled && !isStopOrderFullfilled)
                return;

            try
            {
                if (isLimitOrderFullfilled && isStopOrderFullfilled)
                {
                    if (MessageBox.Show("Send linked orders \n" + mainOrder.ToString() + "\n" + draft1.ToString() + "\n" + draft2.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                        return;

                    OECClient.Global.SendLinkedOrders(mainOrder, draft1, draft2);
                }
                else
                {
                    OrderDraft oneDraft = isLimitOrderFullfilled ? draft1 : draft2;

                    if (MessageBox.Show("Send linked orders \n" + mainOrder.ToString() + "\n" + oneDraft.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
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

        private bool FullfillLimitDraft(OrderDraft mainOrder, OrderDraft draft)
        {
            draft.Type = OEC.Data.OrderType.Limit;
            double limitPriceFactor = double.NaN;
            if (!double.TryParse(edLimitFactor.Text, out limitPriceFactor))
            {
                return false;
            }

            draft.Side = GetOppositeSide(mainOrder);

            if (draft.Side == OEC.Data.OrderSide.Buy)
                draft.Price = mainOrder.Price - limitPriceFactor;
            else
                draft.Price = mainOrder.Price + limitPriceFactor;

            return true;
        }

        private bool FullfillStopDraft(OrderDraft mainOrder, OrderDraft draft)
        {
            draft.Type = OEC.Data.OrderType.Stop;
            double stopPriceFactor = double.NaN;
            if (!double.TryParse(edStopFactor.Text, out stopPriceFactor))
            {
                return false;
            }

            draft.Side = GetOppositeSide(mainOrder);

            if (draft.Side == OEC.Data.OrderSide.Buy)
                draft.Price = mainOrder.Price + stopPriceFactor;
            else
                draft.Price = mainOrder.Price - stopPriceFactor;

            return true;
        }

        private OEC.Data.OrderSide GetOppositeSide(OrderDraft mainOrder)
        {
            if (mainOrder.Side == OEC.Data.OrderSide.Sell)
                return OEC.Data.OrderSide.Buy;
            else
                return OEC.Data.OrderSide.Sell;
        }

    }
}


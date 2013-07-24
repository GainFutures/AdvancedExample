using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OEC.API;
using OEC.Data;

namespace TraderLight
{
    public partial class OrderSimpleDraftControl : TraderLight.BaseControl
    {
        public OrderSimpleDraftControl()
        {
            InitializeComponent();
        }


        protected override void PrepareControlEventHandlers()
        {
            OECClient.Global.OnLoginComplete += new OnLoginCompleteEvent(OnLoginComplete);
        }

        /// <summary>
        /// Makes some preparetions when login complete  succsessfull
        /// </summary>
        void OnLoginComplete()
        {
            PrepareContracts();
        }

        /// <summary>
        /// Prepares existing contracts combo
        /// </summary>
        private void PrepareContracts()
        {
            IList<ContractListEntry> contracts = OECContracts.ConvertFromOECContractList();

            cbSymbol.ValueMember = "Symbol";
            cbSymbol.DisplayMember = "Name";
            cbSymbol.DropDownWidth = 200;
            cbSymbol.DataSource = contracts;

            cbSymbol.Text = string.Empty;
        }

        /// <summary>
        /// Returns Order Draft with fullfilled Contract, Side and Quantity
        /// </summary>
        /// <returns>Fullfilled OrderDraft, null if order draft doesn't fullfilled completely</returns>
        protected OrderDraft GetOrderDraft()
        {   
            if (cbSymbol.SelectedItem == null)
                return null;

            int qty = 0;
            if (!int.TryParse(cbQty.Text, out qty))
                return null;

            if (!rbBuy.Checked && !rbSell.Checked)
                return null;

            OrderDraft draft = OECClient.Global.CreateDraft();
                        
            draft.Side = GetOrderSide();

            draft.Quantity = qty;
            draft.Contract = ((ContractListEntry)cbSymbol.SelectedItem).Contract;
            draft.Account = OECClient.Global.Accounts.First;

            return draft;
        }

        /// <summary>
        /// Reads order side from radiobox
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

        protected void SetDraftFromOrder(Order order)
        {
            rbBuy.Checked = (order.Side == OrderSide.Buy);
            rbSell.Checked = (order.Side == OrderSide.Sell);
            cbQty.Text = order.Quantity.ToString();
            cbSymbol.SelectedItem = null;
            cbSymbol.SelectedValue = order.Contract.Symbol;
            cbSymbol.Refresh();
        }

        protected void ClearOrderDraft()
        {
            rbBuy.Checked = false;
            rbSell.Checked = false;
            cbSymbol.SelectedItem = null;
            cbQty.Text = string.Empty;
        }
    }
}


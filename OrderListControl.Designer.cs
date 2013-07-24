namespace OEC.API.Example
{
    partial class OrderListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lvOrders = new System.Windows.Forms.ListView();
            this.columnOrderId = new System.Windows.Forms.ColumnHeader();
            this.columnAccount = new System.Windows.Forms.ColumnHeader();
            this.columnSide = new System.Windows.Forms.ColumnHeader();
            this.columnSymbol = new System.Windows.Forms.ColumnHeader();
            this.columnQty = new System.Windows.Forms.ColumnHeader();
            this.columnOrderState = new System.Windows.Forms.ColumnHeader();
            this.columnPriceString = new System.Windows.Forms.ColumnHeader();
            this.columnTime = new System.Windows.Forms.ColumnHeader();
            this.columnComment = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// lvOrders
			// 
			this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderId,
            this.columnAccount,
            this.columnSide,
            this.columnSymbol,
            this.columnQty,
            this.columnOrderState,
            this.columnPriceString,
            this.columnTime,
            this.columnComment});
			this.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvOrders.FullRowSelect = true;
			this.lvOrders.HideSelection = false;
			this.lvOrders.Location = new System.Drawing.Point(0, 0);
			this.lvOrders.MultiSelect = false;
			this.lvOrders.Name = "lvOrders";
			this.lvOrders.Size = new System.Drawing.Size(616, 331);
			this.lvOrders.TabIndex = 10;
			this.lvOrders.UseCompatibleStateImageBehavior = false;
			this.lvOrders.View = System.Windows.Forms.View.Details;
			this.lvOrders.SelectedIndexChanged += new System.EventHandler(this.lvOrders_SelectedIndexChanged);
			// 
			// columnOrderId
			// 
			this.columnOrderId.Text = "Order ID";
			// 
			// columnAccount
			// 
			this.columnAccount.Text = "Account";
			// 
			// columnSide
			// 
			this.columnSide.Text = "Side";
			// 
			// columnSymbol
			// 
			this.columnSymbol.Text = "Symbol";
			// 
			// columnQty
			// 
			this.columnQty.Text = "Qty";
			// 
			// columnOrderState
			// 
			this.columnOrderState.Text = "Order state";
			this.columnOrderState.Width = 70;
			// 
			// columnPriceString
			// 
			this.columnPriceString.Text = "Price";
			this.columnPriceString.Width = 100;
			// 
			// columnTime
			// 
			this.columnTime.Text = "Time";
			this.columnTime.Width = 98;
			// 
			// columnComment
			// 
			this.columnComment.Text = "Comment";
			this.columnComment.Width = 202;
			// 
			// OrderListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lvOrders);
			this.Name = "OrderListControl";
			this.Size = new System.Drawing.Size(616, 331);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader columnOrderId;
        private System.Windows.Forms.ColumnHeader columnAccount;
        private System.Windows.Forms.ColumnHeader columnSide;
        private System.Windows.Forms.ColumnHeader columnSymbol;
        private System.Windows.Forms.ColumnHeader columnQty;
        private System.Windows.Forms.ColumnHeader columnOrderState;
        private System.Windows.Forms.ColumnHeader columnPriceString;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnComment;
    }
}

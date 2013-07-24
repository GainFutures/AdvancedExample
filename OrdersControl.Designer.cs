namespace OEC.API.Example
{
    partial class OrdersControl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.SplitContainer splitContainer1;
			this.orderList = new OEC.API.Example.OrderListControl();
			this.pnlOrderLinks = new OEC.API.Example.OrderLinksControl();
			this.btSubmit = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			this.btNew = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.edLimitLegPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btSendOCO = new System.Windows.Forms.Button();
			this.edStopLegPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.edStopFactor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.edLimitFactor = new System.Windows.Forms.TextBox();
			this.btSendBracket = new System.Windows.Forms.Button();
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			splitContainer1.Location = new System.Drawing.Point(3, 173);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(this.orderList);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(this.pnlOrderLinks);
			splitContainer1.Size = new System.Drawing.Size(736, 281);
			splitContainer1.SplitterDistance = 525;
			splitContainer1.TabIndex = 12;
			// 
			// orderList
			// 
			this.orderList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderList.Location = new System.Drawing.Point(0, 0);
			this.orderList.Name = "orderList";
			this.orderList.Size = new System.Drawing.Size(525, 281);
			this.orderList.TabIndex = 12;
			this.orderList.SelectedOrderChanged += new OEC.API.Example.CurrentOrderChangedEventHandler(this.orderList_SelectedOrderChanged);
			// 
			// pnlOrderLinks
			// 
			this.pnlOrderLinks.Caption = "Order Links";
			this.pnlOrderLinks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOrderLinks.Location = new System.Drawing.Point(0, 0);
			this.pnlOrderLinks.Name = "pnlOrderLinks";
			this.pnlOrderLinks.Size = new System.Drawing.Size(207, 281);
			this.pnlOrderLinks.TabIndex = 0;
			this.pnlOrderLinks.OrderLinkNavigated += new OEC.API.Example.OrderLinkNavigatedEventHandler(this.pnlOrderLinks_OrderLinkNavigated);
			// 
			// btSubmit
			// 
			this.btSubmit.Location = new System.Drawing.Point(286, 135);
			this.btSubmit.Name = "btSubmit";
			this.btSubmit.Size = new System.Drawing.Size(66, 26);
			this.btSubmit.TabIndex = 6;
			this.btSubmit.Text = "Submit";
			this.btSubmit.UseVisualStyleBackColor = true;
			this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCancel.Location = new System.Drawing.Point(6, 460);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(91, 24);
			this.btCancel.TabIndex = 10;
			this.btCancel.Text = "Cancel order";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// btModify
			// 
			this.btModify.Location = new System.Drawing.Point(358, 134);
			this.btModify.Name = "btModify";
			this.btModify.Size = new System.Drawing.Size(66, 26);
			this.btModify.TabIndex = 7;
			this.btModify.Text = "Modify";
			this.btModify.UseVisualStyleBackColor = true;
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
			// 
			// btNew
			// 
			this.btNew.Location = new System.Drawing.Point(430, 134);
			this.btNew.Name = "btNew";
			this.btNew.Size = new System.Drawing.Size(66, 26);
			this.btNew.TabIndex = 8;
			this.btNew.Text = "New";
			this.btNew.UseVisualStyleBackColor = true;
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.edLimitLegPrice);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.btSendOCO);
			this.groupBox3.Controls.Add(this.edStopLegPrice);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(506, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(233, 73);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			// 
			// edLimitLegPrice
			// 
			this.edLimitLegPrice.Location = new System.Drawing.Point(69, 16);
			this.edLimitLegPrice.Name = "edLimitLegPrice";
			this.edLimitLegPrice.Size = new System.Drawing.Size(55, 20);
			this.edLimitLegPrice.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 13);
			this.label6.TabIndex = 41;
			this.label6.Text = "Limit";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btSendOCO
			// 
			this.btSendOCO.Location = new System.Drawing.Point(132, 25);
			this.btSendOCO.Name = "btSendOCO";
			this.btSendOCO.Size = new System.Drawing.Size(94, 26);
			this.btSendOCO.TabIndex = 2;
			this.btSendOCO.Text = "Send OCO";
			this.btSendOCO.UseVisualStyleBackColor = true;
			this.btSendOCO.Click += new System.EventHandler(this.btSendOCO_Click);
			// 
			// edStopLegPrice
			// 
			this.edStopLegPrice.Location = new System.Drawing.Point(69, 42);
			this.edStopLegPrice.Name = "edStopLegPrice";
			this.edStopLegPrice.Size = new System.Drawing.Size(55, 20);
			this.edStopLegPrice.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 37;
			this.label7.Text = "Stop";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.edStopFactor);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.edLimitFactor);
			this.groupBox4.Controls.Add(this.btSendBracket);
			this.groupBox4.Location = new System.Drawing.Point(506, 95);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(233, 74);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			// 
			// edStopFactor
			// 
			this.edStopFactor.Location = new System.Drawing.Point(69, 42);
			this.edStopFactor.Name = "edStopFactor";
			this.edStopFactor.Size = new System.Drawing.Size(55, 20);
			this.edStopFactor.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 46);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 38;
			this.label9.Text = "Stop factor";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 37;
			this.label8.Text = "Limit factor";
			// 
			// edLimitFactor
			// 
			this.edLimitFactor.Location = new System.Drawing.Point(69, 16);
			this.edLimitFactor.Name = "edLimitFactor";
			this.edLimitFactor.Size = new System.Drawing.Size(55, 20);
			this.edLimitFactor.TabIndex = 0;
			// 
			// btSendBracket
			// 
			this.btSendBracket.Location = new System.Drawing.Point(132, 25);
			this.btSendBracket.Name = "btSendBracket";
			this.btSendBracket.Size = new System.Drawing.Size(94, 26);
			this.btSendBracket.TabIndex = 2;
			this.btSendBracket.Text = "Send Bracket";
			this.btSendBracket.UseVisualStyleBackColor = true;
			this.btSendBracket.Click += new System.EventHandler(this.btSendBracket_Click);
			// 
			// OrdersControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Caption = "Orders";
			this.Controls.Add(splitContainer1);
			this.Controls.Add(this.btNew);
			this.Controls.Add(this.btModify);
			this.Controls.Add(this.btSubmit);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btCancel);
			this.Name = "OrdersControl";
			this.Size = new System.Drawing.Size(747, 487);
			this.Controls.SetChildIndex(this.btCancel, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.groupBox4, 0);
			this.Controls.SetChildIndex(this.btSubmit, 0);
			this.Controls.SetChildIndex(this.btModify, 0);
			this.Controls.SetChildIndex(this.btNew, 0);
			this.Controls.SetChildIndex(splitContainer1, 0);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btSendOCO;
        private System.Windows.Forms.TextBox edStopLegPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSendBracket;
        private System.Windows.Forms.TextBox edLimitFactor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edStopFactor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edLimitLegPrice;
		private System.Windows.Forms.Label label6;
		private OrderListControl orderList;
		private OrderLinksControl pnlOrderLinks;
    }
}

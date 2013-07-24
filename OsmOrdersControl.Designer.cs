namespace OEC.API.Example
{
	partial class OsmOrdersControl
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
			this.btnCancelOrder = new System.Windows.Forms.Button();
			this.btNew = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			this.btSubmit = new System.Windows.Forms.Button();
			this.gbOsm = new System.Windows.Forms.GroupBox();
			this.lvOsmAlgoParams = new System.Windows.Forms.ListView();
			this.colParamName = new System.Windows.Forms.ColumnHeader();
			this.colParamValue = new System.Windows.Forms.ColumnHeader();
			this.label6 = new System.Windows.Forms.Label();
			this.cbOsmAlgo = new System.Windows.Forms.ComboBox();
			this.gbOsm.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvOrders
			// 
			this.lvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
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
			this.lvOrders.FullRowSelect = true;
			this.lvOrders.HideSelection = false;
			this.lvOrders.Location = new System.Drawing.Point(3, 175);
			this.lvOrders.MultiSelect = false;
			this.lvOrders.Name = "lvOrders";
			this.lvOrders.Size = new System.Drawing.Size(741, 279);
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
			// btnCancelOrder
			// 
			this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancelOrder.Location = new System.Drawing.Point(6, 460);
			this.btnCancelOrder.Name = "btnCancelOrder";
			this.btnCancelOrder.Size = new System.Drawing.Size(91, 24);
			this.btnCancelOrder.TabIndex = 11;
			this.btnCancelOrder.Text = "Cancel order";
			this.btnCancelOrder.UseVisualStyleBackColor = true;
			this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
			// 
			// btNew
			// 
			this.btNew.Location = new System.Drawing.Point(430, 134);
			this.btNew.Name = "btNew";
			this.btNew.Size = new System.Drawing.Size(66, 26);
			this.btNew.TabIndex = 14;
			this.btNew.Text = "New";
			this.btNew.UseVisualStyleBackColor = true;
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btModify
			// 
			this.btModify.Location = new System.Drawing.Point(358, 134);
			this.btModify.Name = "btModify";
			this.btModify.Size = new System.Drawing.Size(66, 26);
			this.btModify.TabIndex = 13;
			this.btModify.Text = "Modify";
			this.btModify.UseVisualStyleBackColor = true;
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
			// 
			// btSubmit
			// 
			this.btSubmit.Location = new System.Drawing.Point(286, 135);
			this.btSubmit.Name = "btSubmit";
			this.btSubmit.Size = new System.Drawing.Size(66, 26);
			this.btSubmit.TabIndex = 12;
			this.btSubmit.Text = "Submit";
			this.btSubmit.UseVisualStyleBackColor = true;
			this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
			// 
			// gbOsm
			// 
			this.gbOsm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbOsm.Controls.Add(this.lvOsmAlgoParams);
			this.gbOsm.Controls.Add(this.label6);
			this.gbOsm.Controls.Add(this.cbOsmAlgo);
			this.gbOsm.Location = new System.Drawing.Point(506, 16);
			this.gbOsm.Name = "gbOsm";
			this.gbOsm.Size = new System.Drawing.Size(238, 153);
			this.gbOsm.TabIndex = 17;
			this.gbOsm.TabStop = false;
			// 
			// lvOsmAlgoParams
			// 
			this.lvOsmAlgoParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lvOsmAlgoParams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colParamName,
            this.colParamValue});
			this.lvOsmAlgoParams.FullRowSelect = true;
			this.lvOsmAlgoParams.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvOsmAlgoParams.HideSelection = false;
			this.lvOsmAlgoParams.Location = new System.Drawing.Point(6, 44);
			this.lvOsmAlgoParams.MultiSelect = false;
			this.lvOsmAlgoParams.Name = "lvOsmAlgoParams";
			this.lvOsmAlgoParams.ShowItemToolTips = true;
			this.lvOsmAlgoParams.Size = new System.Drawing.Size(226, 103);
			this.lvOsmAlgoParams.TabIndex = 19;
			this.lvOsmAlgoParams.UseCompatibleStateImageBehavior = false;
			this.lvOsmAlgoParams.View = System.Windows.Forms.View.Details;
			this.lvOsmAlgoParams.DoubleClick += new System.EventHandler(this.lvOsmAlgoParams_DoubleClick);
			// 
			// colParamName
			// 
			this.colParamName.Text = "Name";
			// 
			// colParamValue
			// 
			this.colParamValue.Text = "Value";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Algo:";
			// 
			// cbOsmAlgo
			// 
			this.cbOsmAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cbOsmAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOsmAlgo.FormattingEnabled = true;
			this.cbOsmAlgo.Location = new System.Drawing.Point(43, 17);
			this.cbOsmAlgo.Name = "cbOsmAlgo";
			this.cbOsmAlgo.Size = new System.Drawing.Size(189, 21);
			this.cbOsmAlgo.TabIndex = 17;
			this.cbOsmAlgo.SelectedIndexChanged += new System.EventHandler(this.cbOsmAlgo_SelectedIndexChanged);
			// 
			// OsmOrdersControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Caption = "OSM Orders";
			this.Controls.Add(this.gbOsm);
			this.Controls.Add(this.btNew);
			this.Controls.Add(this.btModify);
			this.Controls.Add(this.btSubmit);
			this.Controls.Add(this.btnCancelOrder);
			this.Controls.Add(this.lvOrders);
			this.Name = "OsmOrdersControl";
			this.Size = new System.Drawing.Size(747, 487);
			this.Controls.SetChildIndex(this.lvOrders, 0);
			this.Controls.SetChildIndex(this.btnCancelOrder, 0);
			this.Controls.SetChildIndex(this.btSubmit, 0);
			this.Controls.SetChildIndex(this.btModify, 0);
			this.Controls.SetChildIndex(this.btNew, 0);
			this.Controls.SetChildIndex(this.gbOsm, 0);
			this.gbOsm.ResumeLayout(false);
			this.gbOsm.PerformLayout();
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
		private System.Windows.Forms.Button btnCancelOrder;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.Button btSubmit;
		private System.Windows.Forms.GroupBox gbOsm;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbOsmAlgo;
		private System.Windows.Forms.ListView lvOsmAlgoParams;
		private System.Windows.Forms.ColumnHeader colParamName;
		private System.Windows.Forms.ColumnHeader colParamValue;
	}
}

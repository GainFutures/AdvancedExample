namespace OEC.API.Example
{

    partial class OrderDraftControl
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edPrice = new System.Windows.Forms.TextBox();
			this.cbFlags = new System.Windows.Forms.ComboBox();
			this.lbPrice = new System.Windows.Forms.Label();
			this.cbOrderType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbPrice2 = new System.Windows.Forms.Label();
			this.lbVolume = new System.Windows.Forms.Label();
			this.edPrice2 = new System.Windows.Forms.TextBox();
			this.cbVolume = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbTimeEnd = new System.Windows.Forms.DateTimePicker();
			this.cbTimeStart = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBoxSide = new System.Windows.Forms.GroupBox();
			this.rbSell = new System.Windows.Forms.RadioButton();
			this.rbBuy = new System.Windows.Forms.RadioButton();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.cbQty = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbSymbol = new System.Windows.Forms.Label();
			this.cbSymbol = new OEC.API.Example.ContractCombo();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBoxSide.SuspendLayout();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edPrice);
			this.groupBox1.Controls.Add(this.cbFlags);
			this.groupBox1.Controls.Add(this.lbPrice);
			this.groupBox1.Controls.Add(this.cbOrderType);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbPrice2);
			this.groupBox1.Controls.Add(this.lbVolume);
			this.groupBox1.Controls.Add(this.edPrice2);
			this.groupBox1.Controls.Add(this.cbVolume);
			this.groupBox1.Location = new System.Drawing.Point(3, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 47);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// edPrice
			// 
			this.edPrice.Location = new System.Drawing.Point(338, 16);
			this.edPrice.Name = "edPrice";
			this.edPrice.Size = new System.Drawing.Size(55, 20);
			this.edPrice.TabIndex = 2;
			// 
			// cbFlags
			// 
			this.cbFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFlags.FormattingEnabled = true;
			this.cbFlags.Location = new System.Drawing.Point(234, 16);
			this.cbFlags.Name = "cbFlags";
			this.cbFlags.Size = new System.Drawing.Size(63, 21);
			this.cbFlags.TabIndex = 1;
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Location = new System.Drawing.Point(303, 19);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(29, 13);
			this.lbPrice.TabIndex = 2;
			this.lbPrice.Text = "Stop";
			// 
			// cbOrdertype
			// 
			this.cbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOrderType.FormattingEnabled = true;
			this.cbOrderType.Location = new System.Drawing.Point(43, 16);
			this.cbOrderType.Name = "cbOrdertype";
			this.cbOrderType.Size = new System.Drawing.Size(152, 21);
			this.cbOrderType.TabIndex = 0;
			this.cbOrderType.SelectedIndexChanged += new System.EventHandler(this.cbOrderType_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Flag";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type";
			// 
			// lbPrice2
			// 
			this.lbPrice2.Location = new System.Drawing.Point(389, 19);
			this.lbPrice2.Name = "lbPrice2";
			this.lbPrice2.Size = new System.Drawing.Size(41, 13);
			this.lbPrice2.TabIndex = 3;
			this.lbPrice2.Text = "Limit";
			this.lbPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbVolume
			// 
			this.lbVolume.AutoSize = true;
			this.lbVolume.Location = new System.Drawing.Point(389, 19);
			this.lbVolume.Name = "lbVolume";
			this.lbVolume.Size = new System.Drawing.Size(42, 13);
			this.lbVolume.TabIndex = 4;
			this.lbVolume.Text = "Volume";
			// 
			// edPrice2
			// 
			this.edPrice2.Location = new System.Drawing.Point(436, 16);
			this.edPrice2.Name = "edPrice2";
			this.edPrice2.Size = new System.Drawing.Size(55, 20);
			this.edPrice2.TabIndex = 3;
			// 
			// cbVolume
			// 
			this.cbVolume.FormattingEnabled = true;
			this.cbVolume.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "50",
            "100"});
			this.cbVolume.Location = new System.Drawing.Point(436, 16);
			this.cbVolume.Name = "cbVolume";
			this.cbVolume.Size = new System.Drawing.Size(55, 21);
			this.cbVolume.TabIndex = 8;
			this.cbVolume.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbTimeEnd);
			this.groupBox2.Controls.Add(this.cbTimeStart);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(3, 122);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(277, 47);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// cbTimeEnd
			// 
			this.cbTimeEnd.Checked = false;
			this.cbTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.cbTimeEnd.Location = new System.Drawing.Point(163, 16);
			this.cbTimeEnd.Name = "cbTimeEnd";
			this.cbTimeEnd.ShowCheckBox = true;
			this.cbTimeEnd.ShowUpDown = true;
			this.cbTimeEnd.Size = new System.Drawing.Size(98, 20);
			this.cbTimeEnd.TabIndex = 1;
			// 
			// cbTimeStart
			// 
			this.cbTimeStart.Checked = false;
			this.cbTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.cbTimeStart.Location = new System.Drawing.Point(33, 16);
			this.cbTimeStart.Name = "cbTimeStart";
			this.cbTimeStart.ShowCheckBox = true;
			this.cbTimeStart.ShowUpDown = true;
			this.cbTimeStart.Size = new System.Drawing.Size(99, 20);
			this.cbTimeStart.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Start";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(137, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "End";
			// 
			// groupBoxSide
			// 
			this.groupBoxSide.Controls.Add(this.rbSell);
			this.groupBoxSide.Controls.Add(this.rbBuy);
			this.groupBoxSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxSide.Location = new System.Drawing.Point(3, 16);
			this.groupBoxSide.Name = "groupBoxSide";
			this.groupBoxSide.Size = new System.Drawing.Size(123, 47);
			this.groupBoxSide.TabIndex = 0;
			this.groupBoxSide.TabStop = false;
			// 
			// rbSell
			// 
			this.rbSell.AutoSize = true;
			this.rbSell.Location = new System.Drawing.Point(64, 19);
			this.rbSell.Name = "rbSell";
			this.rbSell.Size = new System.Drawing.Size(42, 17);
			this.rbSell.TabIndex = 1;
			this.rbSell.Text = "Sell";
			this.rbSell.UseVisualStyleBackColor = true;
			// 
			// rbBuy
			// 
			this.rbBuy.AutoSize = true;
			this.rbBuy.Location = new System.Drawing.Point(15, 19);
			this.rbBuy.Name = "rbBuy";
			this.rbBuy.Size = new System.Drawing.Size(43, 17);
			this.rbBuy.TabIndex = 0;
			this.rbBuy.Text = "Buy";
			this.rbBuy.UseVisualStyleBackColor = true;
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.cbQty);
			this.groupBox.Controls.Add(this.label2);
			this.groupBox.Controls.Add(this.lbSymbol);
			this.groupBox.Controls.Add(this.cbSymbol);
			this.groupBox.Location = new System.Drawing.Point(132, 16);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(368, 47);
			this.groupBox.TabIndex = 1;
			this.groupBox.TabStop = false;
			// 
			// cbQty
			// 
			this.cbQty.FormattingEnabled = true;
			this.cbQty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "50",
            "100"});
			this.cbQty.Location = new System.Drawing.Point(38, 16);
			this.cbQty.Name = "cbQty";
			this.cbQty.Size = new System.Drawing.Size(49, 21);
			this.cbQty.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Qty";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbSymbol
			// 
			this.lbSymbol.Location = new System.Drawing.Point(107, 17);
			this.lbSymbol.Name = "lbSymbol";
			this.lbSymbol.Size = new System.Drawing.Size(41, 19);
			this.lbSymbol.TabIndex = 7;
			this.lbSymbol.Text = "Symbol";
			this.lbSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbSymbol
			// 
			this.cbSymbol.FormattingEnabled = true;
			this.cbSymbol.Location = new System.Drawing.Point(154, 16);
			this.cbSymbol.Name = "cbSymbol";
			this.cbSymbol.SelectedContract = null;
			this.cbSymbol.Size = new System.Drawing.Size(208, 21);
			this.cbSymbol.TabIndex = 4;
            this.cbSymbol.SelectedValueChanged += cbSymbol_SelectedValueChanged;
			// 
			// OrderDraftControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.groupBoxSide);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "OrderDraftControl";
			this.Size = new System.Drawing.Size(569, 314);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox, 0);
			this.Controls.SetChildIndex(this.groupBoxSide, 0);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBoxSide.ResumeLayout(false);
			this.groupBoxSide.PerformLayout();
			this.groupBox.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox edPrice;
		private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.ComboBox cbVolume;
        private System.Windows.Forms.TextBox edPrice2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker cbTimeEnd;
        private System.Windows.Forms.DateTimePicker cbTimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxSide;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSymbol;
        private ContractCombo cbSymbol;
		protected System.Windows.Forms.ComboBox cbOrderType;
		protected System.Windows.Forms.ComboBox cbFlags;
    }
}

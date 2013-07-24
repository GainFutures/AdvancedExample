namespace TraderLight
{
    partial class OrderSimpleDraftControl
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
            this.groupBoxSide = new System.Windows.Forms.GroupBox();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbQty = new System.Windows.Forms.ComboBox();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSymbol = new System.Windows.Forms.Label();
            this.groupBoxSide.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSide
            // 
            this.groupBoxSide.Controls.Add(this.rbSell);
            this.groupBoxSide.Controls.Add(this.rbBuy);
            this.groupBoxSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSide.Location = new System.Drawing.Point(18, 26);
            this.groupBoxSide.Name = "groupBoxSide";
            this.groupBoxSide.Size = new System.Drawing.Size(123, 47);
            this.groupBoxSide.TabIndex = 25;
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
            this.groupBox.Controls.Add(this.cbSymbol);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.lbSymbol);
            this.groupBox.Location = new System.Drawing.Point(147, 26);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(368, 47);
            this.groupBox.TabIndex = 26;
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
            this.cbQty.TabIndex = 5;
            // 
            // cbSymbol
            // 
            this.cbSymbol.DropDownWidth = 200;
            this.cbSymbol.Location = new System.Drawing.Point(154, 16);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(208, 21);
            this.cbSymbol.TabIndex = 8;
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
            // OrderSimpleDraftControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.groupBoxSide);
            this.Controls.Add(this.groupBox);
            this.Name = "OrderSimpleDraftControl";
            this.Size = new System.Drawing.Size(536, 110);
            this.Controls.SetChildIndex(this.groupBox, 0);
            this.Controls.SetChildIndex(this.groupBoxSide, 0);
            this.groupBoxSide.ResumeLayout(false);
            this.groupBoxSide.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSide;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbQty;
        private System.Windows.Forms.ComboBox cbSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSymbol;
    }
}

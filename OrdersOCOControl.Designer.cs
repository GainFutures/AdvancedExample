namespace TraderLight
{
    partial class OrdersOCOControl
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
            this.edSecondLegStop = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPrice2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edFirstLegLimit = new System.Windows.Forms.TextBox();
            this.edSecondLegLimit = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edSecondLegStop
            // 
            this.edSecondLegStop.Location = new System.Drawing.Point(135, 103);
            this.edSecondLegStop.Name = "edSecondLegStop";
            this.edSecondLegStop.Size = new System.Drawing.Size(97, 20);
            this.edSecondLegStop.TabIndex = 27;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(100, 106);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(29, 13);
            this.lbPrice.TabIndex = 25;
            this.lbPrice.Text = "Stop";
            // 
            // lbPrice2
            // 
            this.lbPrice2.Location = new System.Drawing.Point(230, 106);
            this.lbPrice2.Name = "lbPrice2";
            this.lbPrice2.Size = new System.Drawing.Size(41, 13);
            this.lbPrice2.TabIndex = 26;
            this.lbPrice2.Text = "Limit";
            this.lbPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(99, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Limit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Order #1 Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Order #2 Price";
            // 
            // edFirstLegLimit
            // 
            this.edFirstLegLimit.Location = new System.Drawing.Point(135, 74);
            this.edFirstLegLimit.Name = "edFirstLegLimit";
            this.edFirstLegLimit.Size = new System.Drawing.Size(97, 20);
            this.edFirstLegLimit.TabIndex = 33;
            // 
            // edSecondLegLimit
            // 
            this.edSecondLegLimit.Location = new System.Drawing.Point(277, 103);
            this.edSecondLegLimit.Name = "edSecondLegLimit";
            this.edSecondLegLimit.Size = new System.Drawing.Size(97, 20);
            this.edSecondLegLimit.TabIndex = 34;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(7, 135);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 35;
            this.btSend.Text = "Send OCO";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // OrdersOCOControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "OCO Orders";
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.edSecondLegLimit);
            this.Controls.Add(this.edFirstLegLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edSecondLegStop);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbPrice2);
            this.Name = "OrdersOCOControl";
            this.Size = new System.Drawing.Size(382, 167);
            this.Controls.SetChildIndex(this.lbPrice2, 0);
            this.Controls.SetChildIndex(this.lbPrice, 0);
            this.Controls.SetChildIndex(this.edSecondLegStop, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.edFirstLegLimit, 0);
            this.Controls.SetChildIndex(this.edSecondLegLimit, 0);
            this.Controls.SetChildIndex(this.btSend, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edSecondLegStop;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edFirstLegLimit;
        private System.Windows.Forms.TextBox edSecondLegLimit;
        private System.Windows.Forms.Button btSend;

    }
}

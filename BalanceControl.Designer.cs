namespace OEC.API.Example
{
    partial class BalanceControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOpenPL = new System.Windows.Forms.Label();
            this.lbRealizedPL = new System.Windows.Forms.Label();
            this.lbTotalPL = new System.Windows.Forms.Label();
            this.lbNetLiq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Open P/L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Realized P/L";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total P/L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Net Liq";
            // 
            // lbOpenPL
            // 
            this.lbOpenPL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOpenPL.Location = new System.Drawing.Point(90, 23);
            this.lbOpenPL.Name = "lbOpenPL";
            this.lbOpenPL.Size = new System.Drawing.Size(86, 13);
            this.lbOpenPL.TabIndex = 10;
            this.lbOpenPL.Text = "0";
            // 
            // lbRealizedPL
            // 
            this.lbRealizedPL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRealizedPL.Location = new System.Drawing.Point(90, 46);
            this.lbRealizedPL.Name = "lbRealizedPL";
            this.lbRealizedPL.Size = new System.Drawing.Size(86, 13);
            this.lbRealizedPL.TabIndex = 11;
            this.lbRealizedPL.Text = "0";
            // 
            // lbTotalPL
            // 
            this.lbTotalPL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotalPL.Location = new System.Drawing.Point(90, 70);
            this.lbTotalPL.Name = "lbTotalPL";
            this.lbTotalPL.Size = new System.Drawing.Size(86, 13);
            this.lbTotalPL.TabIndex = 12;
            this.lbTotalPL.Text = "0";
            // 
            // lbNetLiq
            // 
            this.lbNetLiq.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNetLiq.Location = new System.Drawing.Point(261, 34);
            this.lbNetLiq.Name = "lbNetLiq";
            this.lbNetLiq.Size = new System.Drawing.Size(86, 13);
            this.lbNetLiq.TabIndex = 13;
            this.lbNetLiq.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cash";
            // 
            // lbCash
            // 
            this.lbCash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCash.Location = new System.Drawing.Point(261, 58);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(86, 13);
            this.lbCash.TabIndex = 15;
            this.lbCash.Text = "0";
            // 
            // BalanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "Balance";
            this.Controls.Add(this.lbCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOpenPL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNetLiq);
            this.Controls.Add(this.lbTotalPL);
            this.Controls.Add(this.lbRealizedPL);
            this.Name = "BalanceControl";
            this.Size = new System.Drawing.Size(450, 157);
            this.Controls.SetChildIndex(this.lbRealizedPL, 0);
            this.Controls.SetChildIndex(this.lbTotalPL, 0);
            this.Controls.SetChildIndex(this.lbNetLiq, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbOpenPL, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbCash, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOpenPL;
        private System.Windows.Forms.Label lbRealizedPL;
        private System.Windows.Forms.Label lbTotalPL;
        private System.Windows.Forms.Label lbNetLiq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCash;
    }
}

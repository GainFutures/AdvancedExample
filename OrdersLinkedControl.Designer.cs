namespace TraderLight
{
    partial class OrdersLinkedControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.edLimitFactor = new System.Windows.Forms.TextBox();
            this.edStopFactor = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Limit factor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stop factor";
            // 
            // edLimitFactor
            // 
            this.edLimitFactor.Location = new System.Drawing.Point(73, 136);
            this.edLimitFactor.Name = "edLimitFactor";
            this.edLimitFactor.Size = new System.Drawing.Size(100, 20);
            this.edLimitFactor.TabIndex = 29;
            // 
            // edStopFactor
            // 
            this.edStopFactor.Location = new System.Drawing.Point(73, 162);
            this.edStopFactor.Name = "edStopFactor";
            this.edStopFactor.Size = new System.Drawing.Size(100, 20);
            this.edStopFactor.TabIndex = 30;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(7, 191);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 31;
            this.btSend.Text = "SendLinked";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // OrdersLinkedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "Linked Orders";
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edStopFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.edLimitFactor);
            this.Name = "OrdersLinkedControl";
            this.Size = new System.Drawing.Size(528, 228);
            this.Controls.SetChildIndex(this.edLimitFactor, 0);
            this.Controls.SetChildIndex(this.btSend, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edStopFactor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edLimitFactor;
        private System.Windows.Forms.TextBox edStopFactor;
        private System.Windows.Forms.Button btSend;
    }
}

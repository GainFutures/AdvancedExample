namespace OEC.API.Example
{
    partial class SubscribeControl
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
            this.btUnsubscribe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSubscribe = new System.Windows.Forms.Button();
            this.cbSymbol = new OEC.API.Example.ContractCombo();
            this.SuspendLayout();
            // 
            // btUnsubscribe
            // 
            this.btUnsubscribe.Location = new System.Drawing.Point(266, 18);
            this.btUnsubscribe.Name = "btUnsubscribe";
            this.btUnsubscribe.Size = new System.Drawing.Size(75, 23);
            this.btUnsubscribe.TabIndex = 2;
            this.btUnsubscribe.Text = "Unsubscribe";
            this.btUnsubscribe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contract";
            // 
            // btSubscribe
            // 
            this.btSubscribe.Location = new System.Drawing.Point(185, 18);
            this.btSubscribe.Name = "btSubscribe";
            this.btSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btSubscribe.TabIndex = 1;
            this.btSubscribe.Text = "Subscribe";
            this.btSubscribe.UseVisualStyleBackColor = true;
            // 
            // cbSymbol
            // 
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(56, 19);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbSymbol.TabIndex = 8;
            // 
            // SubscribeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.cbSymbol);
            this.Controls.Add(this.btUnsubscribe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSubscribe);
            this.Name = "SubscribeControl";
            this.Size = new System.Drawing.Size(348, 240);
            this.Controls.SetChildIndex(this.btSubscribe, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btUnsubscribe, 0);
            this.Controls.SetChildIndex(this.cbSymbol, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Unsubscribe button
        /// </summary>
        public System.Windows.Forms.Button btUnsubscribe;

        /// <summary>
        /// Subscribe button
        /// </summary>
        public System.Windows.Forms.Button btSubscribe;
        internal ContractCombo cbSymbol;
    }
}

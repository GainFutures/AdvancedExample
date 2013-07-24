namespace OEC.API.Example
{
    partial class EventLogControl
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
            this.edLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edLog
            // 
            this.edLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.edLog.Location = new System.Drawing.Point(3, 16);
            this.edLog.Multiline = true;
            this.edLog.Name = "edLog";
            this.edLog.ReadOnly = true;
            this.edLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edLog.Size = new System.Drawing.Size(312, 147);
            this.edLog.TabIndex = 2;
            // 
            // EventLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "Events Log";
            this.Controls.Add(this.edLog);
            this.Name = "EventLogControl";
            this.Size = new System.Drawing.Size(318, 166);
            this.Controls.SetChildIndex(this.edLog, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edLog;


    }
}

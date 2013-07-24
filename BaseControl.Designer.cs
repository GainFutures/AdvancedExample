namespace OEC.API.Example
{
    partial class BaseControl
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
            this.lbCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCaption
            // 
            this.lbCaption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCaption.Location = new System.Drawing.Point(0, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(320, 13);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "label1";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCaption);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(320, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCaption;
    }
}

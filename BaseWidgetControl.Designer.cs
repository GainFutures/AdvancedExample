namespace TraderLight
{
    partial class BaseWidgetControl
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
            this.lbName = new System.Windows.Forms.Label();
            this.pbSizer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSizer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(512, 17);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Caption";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseDown);
            this.lbName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseMove);
            this.lbName.MouseCaptureChanged += new System.EventHandler(this.lbName_MouseCaptureChanged);
            // 
            // pbSizer
            // 
            this.pbSizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSizer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbSizer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSizer.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pbSizer.Location = new System.Drawing.Point(502, 169);
            this.pbSizer.Name = "pbSizer";
            this.pbSizer.Size = new System.Drawing.Size(10, 11);
            this.pbSizer.TabIndex = 5;
            this.pbSizer.TabStop = false;
            this.pbSizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbSizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbSizer.MouseCaptureChanged += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            // 
            // BaseWidgetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbSizer);
            this.Controls.Add(this.lbName);
            this.Name = "BaseWidgetControl";
            this.Size = new System.Drawing.Size(512, 180);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BaseWidgetControl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbSizer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pbSizer;
    }
}

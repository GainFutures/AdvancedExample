namespace OEC.API.Example
{
    partial class NewsControl
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
            this.lbNews = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbNews
            // 
            this.lbNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNews.FormattingEnabled = true;
            this.lbNews.Location = new System.Drawing.Point(0, 15);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(315, 147);
            this.lbNews.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(315, 15);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 151);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 2);
            this.panel2.TabIndex = 10;
            // 
            // NewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "News";
            this.Controls.Add(this.lbNews);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Name = "NewsControl";
            this.Size = new System.Drawing.Size(318, 166);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.lbNews, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNews;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
    }
}

namespace OEC.API.Example
{

    partial class PricesControl
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
            this.lvQuotes = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cbSymbol
            // 
            this.cbSymbol.TabIndex = 0;
            this.cbSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSymbol_SelectedIndexChanged);
            // 
            // btUnsubscribe
            // 
            this.btUnsubscribe.Enabled = false;
            this.btUnsubscribe.TabIndex = 2;
            this.btUnsubscribe.Click += new System.EventHandler(this.btUnsubscribe_Click);
            // 
            // btSubscribe
            // 
            this.btSubscribe.Enabled = false;
            this.btSubscribe.TabIndex = 1;
            this.btSubscribe.Click += new System.EventHandler(this.btSubscribe_Click);
            // 
            // lvQuotes
            // 
            this.lvQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvQuotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvQuotes.FullRowSelect = true;
            this.lvQuotes.Location = new System.Drawing.Point(3, 47);
            this.lvQuotes.MultiSelect = false;
            this.lvQuotes.Name = "lvQuotes";
            this.lvQuotes.Size = new System.Drawing.Size(432, 155);
            this.lvQuotes.TabIndex = 3;
            this.lvQuotes.UseCompatibleStateImageBehavior = false;
            this.lvQuotes.View = System.Windows.Forms.View.Details;
            this.lvQuotes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvQuotes_ItemSelectionChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 7;
            this.columnHeader8.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Symbol";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Last Price";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Last Vol";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Ask Price";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Ask Vol";
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Bid Price";
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 6;
            this.columnHeader7.Text = "Bid Vol";
            // 
            // PricesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "Quotes";
            this.Controls.Add(this.lvQuotes);
            this.Name = "PricesControl";
            this.Size = new System.Drawing.Size(439, 205);
            this.Controls.SetChildIndex(this.lvQuotes, 0);
            this.Controls.SetChildIndex(this.cbSymbol, 0);
            this.Controls.SetChildIndex(this.btSubscribe, 0);
            this.Controls.SetChildIndex(this.btUnsubscribe, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvQuotes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;


    }
}

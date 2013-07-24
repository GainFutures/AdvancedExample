namespace OEC.API.Example
{
    partial class DOMControl
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgDOMAsk = new System.Windows.Forms.DataGridView();
			this.askLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.askSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractDOMAskEntryBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.dgDOMBid = new System.Windows.Forms.DataGridView();
			this.bidLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bidSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractDOMBidEntryBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize) (this.dgDOMAsk)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.contractDOMAskEntryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.dgDOMBid)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.contractDOMBidEntryBindingSource)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbSymbol
			// 
			this.cbSymbol.SelectedIndexChanged += new System.EventHandler( this.cbSymbol_SelectedIndexChanged );
			// 
			// btUnsubscribe
			// 
			this.btUnsubscribe.Enabled = false;
			this.btUnsubscribe.Click += new System.EventHandler( this.btUnsubscribe_Click );
			// 
			// btSubscribe
			// 
			this.btSubscribe.Enabled = false;
			this.btSubscribe.Click += new System.EventHandler( this.btSubscribe_Click );
			// 
			// dgDOMAsk
			// 
			this.dgDOMAsk.AutoGenerateColumns = false;
			this.dgDOMAsk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDOMAsk.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.askLevelDataGridViewTextBoxColumn,
            this.askSizeDataGridViewTextBoxColumn} );
			this.dgDOMAsk.DataSource = this.contractDOMAskEntryBindingSource;
			this.dgDOMAsk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgDOMAsk.Location = new System.Drawing.Point( 0, 0 );
			this.dgDOMAsk.Name = "dgDOMAsk";
			this.dgDOMAsk.RowHeadersVisible = false;
			this.dgDOMAsk.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgDOMAsk.Size = new System.Drawing.Size( 171, 241 );
			this.dgDOMAsk.TabIndex = 0;
			// 
			// askLevelDataGridViewTextBoxColumn
			// 
			this.askLevelDataGridViewTextBoxColumn.DataPropertyName = "AskLevel";
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = null;
			this.askLevelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.askLevelDataGridViewTextBoxColumn.HeaderText = "AskLevel";
			this.askLevelDataGridViewTextBoxColumn.Name = "askLevelDataGridViewTextBoxColumn";
			this.askLevelDataGridViewTextBoxColumn.ReadOnly = true;
			this.askLevelDataGridViewTextBoxColumn.Width = 70;
			// 
			// askSizeDataGridViewTextBoxColumn
			// 
			this.askSizeDataGridViewTextBoxColumn.DataPropertyName = "AskSize";
			this.askSizeDataGridViewTextBoxColumn.HeaderText = "AskSize";
			this.askSizeDataGridViewTextBoxColumn.Name = "askSizeDataGridViewTextBoxColumn";
			this.askSizeDataGridViewTextBoxColumn.ReadOnly = true;
			this.askSizeDataGridViewTextBoxColumn.Width = 70;
			// 
			// contractDOMAskEntryBindingSource
			// 
			this.contractDOMAskEntryBindingSource.DataSource = typeof( OEC.API.Example.ContractDOMAskEntry );
			// 
			// dgDOMBid
			// 
			this.dgDOMBid.AutoGenerateColumns = false;
			this.dgDOMBid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDOMBid.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.bidLevelDataGridViewTextBoxColumn,
            this.bidSizeDataGridViewTextBoxColumn} );
			this.dgDOMBid.DataSource = this.contractDOMBidEntryBindingSource;
			this.dgDOMBid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgDOMBid.Location = new System.Drawing.Point( 0, 0 );
			this.dgDOMBid.Name = "dgDOMBid";
			this.dgDOMBid.RowHeadersVisible = false;
			this.dgDOMBid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgDOMBid.Size = new System.Drawing.Size( 178, 241 );
			this.dgDOMBid.TabIndex = 0;
			// 
			// bidLevelDataGridViewTextBoxColumn
			// 
			this.bidLevelDataGridViewTextBoxColumn.DataPropertyName = "BidLevel";
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.bidLevelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.bidLevelDataGridViewTextBoxColumn.HeaderText = "BidLevel";
			this.bidLevelDataGridViewTextBoxColumn.Name = "bidLevelDataGridViewTextBoxColumn";
			this.bidLevelDataGridViewTextBoxColumn.ReadOnly = true;
			this.bidLevelDataGridViewTextBoxColumn.Width = 70;
			// 
			// bidSizeDataGridViewTextBoxColumn
			// 
			this.bidSizeDataGridViewTextBoxColumn.DataPropertyName = "BidSize";
			this.bidSizeDataGridViewTextBoxColumn.HeaderText = "BidSize";
			this.bidSizeDataGridViewTextBoxColumn.Name = "bidSizeDataGridViewTextBoxColumn";
			this.bidSizeDataGridViewTextBoxColumn.ReadOnly = true;
			this.bidSizeDataGridViewTextBoxColumn.Width = 70;
			// 
			// contractDOMBidEntryBindingSource
			// 
			this.contractDOMBidEntryBindingSource.DataSource = typeof( OEC.API.Example.ContractDOMBidEntry );
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point( 3, 47 );
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add( this.dgDOMAsk );
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add( this.dgDOMBid );
			this.splitContainer1.Size = new System.Drawing.Size( 353, 241 );
			this.splitContainer1.SplitterDistance = 171;
			this.splitContainer1.TabIndex = 11;
			// 
			// DOMControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Caption = "DOM";
			this.Controls.Add( this.splitContainer1 );
			this.Name = "DOMControl";
			this.Size = new System.Drawing.Size( 359, 291 );
			this.Controls.SetChildIndex( this.cbSymbol, 0 );
			this.Controls.SetChildIndex( this.btSubscribe, 0 );
			this.Controls.SetChildIndex( this.btUnsubscribe, 0 );
			this.Controls.SetChildIndex( this.splitContainer1, 0 );
			((System.ComponentModel.ISupportInitialize) (this.dgDOMAsk)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.contractDOMAskEntryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.dgDOMBid)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.contractDOMBidEntryBindingSource)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout( false );
			this.splitContainer1.Panel2.ResumeLayout( false );
			this.splitContainer1.ResumeLayout( false );
			this.ResumeLayout( false );
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDOMAsk;
        private System.Windows.Forms.DataGridView dgDOMBid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn askLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn askSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractDOMAskEntryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractDOMBidEntryBindingSource;
    }
}

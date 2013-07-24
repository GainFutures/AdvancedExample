namespace OEC.API.Example
{
    partial class AveragePositionsControl
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
			this.dgAvgPositions = new System.Windows.Forms.DataGridView();
			this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.boughtNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.boughtAvgPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soldNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soldAvgPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.netPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OpenPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RealizedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.avgPositionListEntryBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.btExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) (this.dgAvgPositions)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.avgPositionListEntryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgAvgPositions
			// 
			this.dgAvgPositions.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgAvgPositions.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)) );
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgAvgPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgAvgPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAvgPositions.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.contractDataGridViewTextBoxColumn,
            this.boughtNumDataGridViewTextBoxColumn,
            this.boughtAvgPriceDataGridViewTextBoxColumn,
            this.soldNumDataGridViewTextBoxColumn,
            this.soldAvgPriceDataGridViewTextBoxColumn,
            this.netPosDataGridViewTextBoxColumn,
            this.TotalPnL,
            this.OpenPnL,
            this.RealizedPnL} );
			this.dgAvgPositions.DataSource = this.avgPositionListEntryBindingSource;
			this.dgAvgPositions.Location = new System.Drawing.Point( 3, 16 );
			this.dgAvgPositions.Name = "dgAvgPositions";
			this.dgAvgPositions.RowHeadersVisible = false;
			this.dgAvgPositions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgAvgPositions.Size = new System.Drawing.Size( 504, 138 );
			this.dgAvgPositions.TabIndex = 0;
			this.dgAvgPositions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler( this.dgAvgPositions_CellFormatting );
			// 
			// contractDataGridViewTextBoxColumn
			// 
			this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
			this.contractDataGridViewTextBoxColumn.HeaderText = "Symbol";
			this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
			this.contractDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractDataGridViewTextBoxColumn.Width = 60;
			// 
			// boughtNumDataGridViewTextBoxColumn
			// 
			this.boughtNumDataGridViewTextBoxColumn.DataPropertyName = "BoughtNum";
			this.boughtNumDataGridViewTextBoxColumn.HeaderText = "Bought#";
			this.boughtNumDataGridViewTextBoxColumn.Name = "boughtNumDataGridViewTextBoxColumn";
			this.boughtNumDataGridViewTextBoxColumn.ReadOnly = true;
			this.boughtNumDataGridViewTextBoxColumn.Width = 70;
			// 
			// boughtAvgPriceDataGridViewTextBoxColumn
			// 
			this.boughtAvgPriceDataGridViewTextBoxColumn.DataPropertyName = "BoughtAvgPrice";
			this.boughtAvgPriceDataGridViewTextBoxColumn.HeaderText = "Avg Buy Price";
			this.boughtAvgPriceDataGridViewTextBoxColumn.Name = "boughtAvgPriceDataGridViewTextBoxColumn";
			this.boughtAvgPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// soldNumDataGridViewTextBoxColumn
			// 
			this.soldNumDataGridViewTextBoxColumn.DataPropertyName = "SoldNum";
			this.soldNumDataGridViewTextBoxColumn.HeaderText = "Sold#";
			this.soldNumDataGridViewTextBoxColumn.Name = "soldNumDataGridViewTextBoxColumn";
			this.soldNumDataGridViewTextBoxColumn.ReadOnly = true;
			this.soldNumDataGridViewTextBoxColumn.Width = 70;
			// 
			// soldAvgPriceDataGridViewTextBoxColumn
			// 
			this.soldAvgPriceDataGridViewTextBoxColumn.DataPropertyName = "SoldAvgPrice";
			this.soldAvgPriceDataGridViewTextBoxColumn.HeaderText = "Avg Sell Price";
			this.soldAvgPriceDataGridViewTextBoxColumn.Name = "soldAvgPriceDataGridViewTextBoxColumn";
			this.soldAvgPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// netPosDataGridViewTextBoxColumn
			// 
			this.netPosDataGridViewTextBoxColumn.DataPropertyName = "NetPos";
			this.netPosDataGridViewTextBoxColumn.HeaderText = "Net Pos";
			this.netPosDataGridViewTextBoxColumn.Name = "netPosDataGridViewTextBoxColumn";
			this.netPosDataGridViewTextBoxColumn.ReadOnly = true;
			this.netPosDataGridViewTextBoxColumn.Width = 60;
			// 
			// TotalPnL
			// 
			this.TotalPnL.DataPropertyName = "TotalPnL";
			this.TotalPnL.HeaderText = "TotalPnL";
			this.TotalPnL.Name = "TotalPnL";
			this.TotalPnL.ReadOnly = true;
			this.TotalPnL.Width = 60;
			// 
			// OpenPnL
			// 
			this.OpenPnL.DataPropertyName = "OpenPnL";
			this.OpenPnL.HeaderText = "OpenPnL";
			this.OpenPnL.Name = "OpenPnL";
			this.OpenPnL.ReadOnly = true;
			this.OpenPnL.Width = 60;
			// 
			// RealizedPnL
			// 
			this.RealizedPnL.DataPropertyName = "RealizedPnL";
			this.RealizedPnL.HeaderText = "RealizedPnL";
			this.RealizedPnL.Name = "RealizedPnL";
			this.RealizedPnL.ReadOnly = true;
			this.RealizedPnL.Width = 60;
			// 
			// avgPositionListEntryBindingSource
			// 
			this.avgPositionListEntryBindingSource.DataSource = typeof( OEC.API.Example.AvgPositionListEntry );
			// 
			// btExit
			// 
			this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btExit.Location = new System.Drawing.Point( 3, 154 );
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size( 75, 21 );
			this.btExit.TabIndex = 1;
			this.btExit.Text = "Exit Position";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler( this.btExit_Click );
			// 
			// AveragePositionsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Caption = "Average Position";
			this.Controls.Add( this.btExit );
			this.Controls.Add( this.dgAvgPositions );
			this.Name = "AveragePositionsControl";
			this.Size = new System.Drawing.Size( 510, 178 );
			this.Controls.SetChildIndex( this.dgAvgPositions, 0 );
			this.Controls.SetChildIndex( this.btExit, 0 );
			((System.ComponentModel.ISupportInitialize) (this.dgAvgPositions)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.avgPositionListEntryBindingSource)).EndInit();
			this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAvgPositions;
        private System.Windows.Forms.BindingSource avgPositionListEntryBindingSource;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boughtNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boughtAvgPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldAvgPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealizedPnL;
    }
}

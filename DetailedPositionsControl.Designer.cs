namespace TraderLight
{
    partial class DetailedPositionsControl
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
            this.dgDetPositions = new System.Windows.Forms.DataGridView();
            this.detPositionListEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btExitPosition = new System.Windows.Forms.Button();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boughtAvgPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldAvgPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealizedPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detPositionListEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetPositions
            // 
            this.dgDetPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetPositions.AutoGenerateColumns = false;
            this.dgDetPositions.ColumnHeadersHeight = 20;
            this.dgDetPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDetPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractDataGridViewTextBoxColumn,
            this.boughtAvgPriceDataGridViewTextBoxColumn,
            this.soldAvgPriceDataGridViewTextBoxColumn,
            this.Amount,
            this.RealizedPnL,
            this.OpenPnL,
            this.TotalPnL});
            this.dgDetPositions.DataSource = this.detPositionListEntryBindingSource;
            this.dgDetPositions.Location = new System.Drawing.Point(3, 16);
            this.dgDetPositions.Name = "dgDetPositions";
            this.dgDetPositions.RowHeadersVisible = false;
            this.dgDetPositions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetPositions.Size = new System.Drawing.Size(399, 126);
            this.dgDetPositions.TabIndex = 1;
            // 
            // detPositionListEntryBindingSource
            // 
            this.detPositionListEntryBindingSource.DataSource = typeof(TraderLight.DetPositionListEntry);
            // 
            // btExitPosition
            // 
            this.btExitPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExitPosition.Location = new System.Drawing.Point(3, 148);
            this.btExitPosition.Name = "btExitPosition";
            this.btExitPosition.Size = new System.Drawing.Size(75, 23);
            this.btExitPosition.TabIndex = 2;
            this.btExitPosition.Text = "Exit position";
            this.btExitPosition.UseVisualStyleBackColor = true;
            this.btExitPosition.Click += new System.EventHandler(this.btExitPosition_Click);
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            this.contractDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractDataGridViewTextBoxColumn.Width = 60;
            // 
            // boughtAvgPriceDataGridViewTextBoxColumn
            // 
            this.boughtAvgPriceDataGridViewTextBoxColumn.DataPropertyName = "BoughtAvgPrice";
            this.boughtAvgPriceDataGridViewTextBoxColumn.HeaderText = "Avg. Buy Price";
            this.boughtAvgPriceDataGridViewTextBoxColumn.Name = "boughtAvgPriceDataGridViewTextBoxColumn";
            this.boughtAvgPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldAvgPriceDataGridViewTextBoxColumn
            // 
            this.soldAvgPriceDataGridViewTextBoxColumn.DataPropertyName = "SoldAvgPrice";
            this.soldAvgPriceDataGridViewTextBoxColumn.HeaderText = "Avg. Sell Price";
            this.soldAvgPriceDataGridViewTextBoxColumn.Name = "soldAvgPriceDataGridViewTextBoxColumn";
            this.soldAvgPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 60;
            // 
            // RealizedPnL
            // 
            this.RealizedPnL.DataPropertyName = "RealizedPnL";
            this.RealizedPnL.HeaderText = "RealizedPnL";
            this.RealizedPnL.Name = "RealizedPnL";
            this.RealizedPnL.ReadOnly = true;
            this.RealizedPnL.Width = 70;
            // 
            // OpenPnL
            // 
            this.OpenPnL.DataPropertyName = "OpenPnL";
            this.OpenPnL.HeaderText = "OpenPnL";
            this.OpenPnL.Name = "OpenPnL";
            this.OpenPnL.ReadOnly = true;
            this.OpenPnL.Width = 60;
            // 
            // TotalPnL
            // 
            this.TotalPnL.DataPropertyName = "TotalPnL";
            this.TotalPnL.HeaderText = "TotalPnL";
            this.TotalPnL.Name = "TotalPnL";
            this.TotalPnL.ReadOnly = true;
            this.TotalPnL.Width = 60;
            // 
            // DetailedPositionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Caption = "Detailed Positions";
            this.Controls.Add(this.btExitPosition);
            this.Controls.Add(this.dgDetPositions);
            this.Name = "DetailedPositionsControl";
            this.Size = new System.Drawing.Size(405, 174);
            this.Controls.SetChildIndex(this.dgDetPositions, 0);
            this.Controls.SetChildIndex(this.btExitPosition, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detPositionListEntryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetPositions;
        private System.Windows.Forms.BindingSource detPositionListEntryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boughtNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btExitPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boughtAvgPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldAvgPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealizedPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPnL;
    }
}

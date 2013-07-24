namespace OEC.API.Example
{
	partial class TickViewControl
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
			this.components = new System.ComponentModel.Container();
			this.dgTicks = new System.Windows.Forms.DataGridView();
			this.tickEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSymbol = new OEC.API.Example.ContractCombo();
			this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bidPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.askPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgTicks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tickEntryBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgTicks
			// 
			this.dgTicks.AutoGenerateColumns = false;
			this.dgTicks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgTicks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTicks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.bidPriceDataGridViewTextBoxColumn,
            this.askPriceDataGridViewTextBoxColumn});
			this.dgTicks.DataSource = this.tickEntryBindingSource;
			this.dgTicks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgTicks.Location = new System.Drawing.Point(0, 47);
			this.dgTicks.Name = "dgTicks";
			this.dgTicks.RowHeadersVisible = false;
			this.dgTicks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgTicks.Size = new System.Drawing.Size(560, 255);
			this.dgTicks.TabIndex = 2;
			// 
			// tickEntryBindingSource
			// 
			this.tickEntryBindingSource.DataSource = typeof(OEC.API.Example.TickEntry);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbSymbol);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 34);
			this.panel1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Contract";
			// 
			// cbSymbol
			// 
			this.cbSymbol.FormattingEnabled = true;
			this.cbSymbol.Location = new System.Drawing.Point(67, 6);
			this.cbSymbol.Name = "cbSymbol";
			this.cbSymbol.SelectedContract = null;
			this.cbSymbol.Size = new System.Drawing.Size(121, 21);
			this.cbSymbol.TabIndex = 10;
			this.cbSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSymbol_SelectedIndexChanged);
			// 
			// timeStampDataGridViewTextBoxColumn
			// 
			this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
			this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
			this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
			this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// volumeDataGridViewTextBoxColumn
			// 
			this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
			this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
			this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
			this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bidPriceDataGridViewTextBoxColumn
			// 
			this.bidPriceDataGridViewTextBoxColumn.DataPropertyName = "BidPrice";
			this.bidPriceDataGridViewTextBoxColumn.HeaderText = "BidPrice";
			this.bidPriceDataGridViewTextBoxColumn.Name = "bidPriceDataGridViewTextBoxColumn";
			this.bidPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// askPriceDataGridViewTextBoxColumn
			// 
			this.askPriceDataGridViewTextBoxColumn.DataPropertyName = "AskPrice";
			this.askPriceDataGridViewTextBoxColumn.HeaderText = "AskPrice";
			this.askPriceDataGridViewTextBoxColumn.Name = "askPriceDataGridViewTextBoxColumn";
			this.askPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// TickViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Caption = "Tick View";
			this.Controls.Add(this.dgTicks);
			this.Controls.Add(this.panel1);
			this.Name = "TickViewControl";
			this.Size = new System.Drawing.Size(560, 302);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.dgTicks, 0);
			((System.ComponentModel.ISupportInitialize)(this.dgTicks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tickEntryBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgTicks;
		private System.Windows.Forms.BindingSource tickEntryBindingSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private ContractCombo cbSymbol;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bidPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn askPriceDataGridViewTextBoxColumn;
	}
}

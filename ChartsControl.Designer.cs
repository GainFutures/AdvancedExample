namespace OEC.API.Example
{
    partial class ChartsControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cbTimeScale = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSymbol = new OEC.API.Example.ContractCombo();
			this.chart = new OEC.API.Example.OLHCChart();
			this.dgBars = new System.Windows.Forms.DataGridView();
			this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgBars)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barEntryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cbTimeScale);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbSymbol);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(685, 35);
			this.panel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(286, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "min.";
			// 
			// cbTimeScale
			// 
			this.cbTimeScale.FormattingEnabled = true;
			this.cbTimeScale.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60",
            "120",
            "240"});
			this.cbTimeScale.Location = new System.Drawing.Point(231, 6);
			this.cbTimeScale.Name = "cbTimeScale";
			this.cbTimeScale.Size = new System.Drawing.Size(49, 21);
			this.cbTimeScale.TabIndex = 1;
			this.cbTimeScale.Text = "30";
			this.cbTimeScale.SelectedIndexChanged += new System.EventHandler(this.cbTimeScale_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(196, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Step";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Contract";
			// 
			// cbSymbol
			// 
			this.cbSymbol.FormattingEnabled = true;
			this.cbSymbol.Location = new System.Drawing.Point(58, 6);
			this.cbSymbol.Name = "cbSymbol";
			this.cbSymbol.SelectedContract = null;
			this.cbSymbol.Size = new System.Drawing.Size(121, 21);
			this.cbSymbol.TabIndex = 6;
			this.cbSymbol.SelectedIndexChanged += new System.EventHandler(this.cbContracts_SelectedIndexChanged);
			// 
			// chart
			// 
			this.chart.BackColor = System.Drawing.Color.Silver;
			this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart.Location = new System.Drawing.Point(0, 48);
			this.chart.Name = "chart";
			this.chart.Size = new System.Drawing.Size(685, 241);
			this.chart.TabIndex = 0;
			// 
			// dgBars
			// 
			this.dgBars.AutoGenerateColumns = false;
			this.dgBars.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgBars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn});
			this.dgBars.DataSource = this.barEntryBindingSource;
			this.dgBars.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgBars.Location = new System.Drawing.Point(0, 295);
			this.dgBars.Name = "dgBars";
			this.dgBars.RowHeadersVisible = false;
			this.dgBars.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgBars.Size = new System.Drawing.Size(685, 100);
			this.dgBars.TabIndex = 1;
			// 
			// timeStampDataGridViewTextBoxColumn
			// 
			this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
			dataGridViewCellStyle1.Format = "F";
			dataGridViewCellStyle1.NullValue = null;
			this.timeStampDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
			this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
			this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
			this.timeStampDataGridViewTextBoxColumn.Width = 150;
			// 
			// openDataGridViewTextBoxColumn
			// 
			this.openDataGridViewTextBoxColumn.DataPropertyName = "Open";
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.openDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.openDataGridViewTextBoxColumn.HeaderText = "Open";
			this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
			this.openDataGridViewTextBoxColumn.ReadOnly = true;
			this.openDataGridViewTextBoxColumn.Width = 80;
			// 
			// closeDataGridViewTextBoxColumn
			// 
			this.closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.closeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.closeDataGridViewTextBoxColumn.HeaderText = "Close";
			this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
			this.closeDataGridViewTextBoxColumn.ReadOnly = true;
			this.closeDataGridViewTextBoxColumn.Width = 80;
			// 
			// highDataGridViewTextBoxColumn
			// 
			this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = null;
			this.highDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.highDataGridViewTextBoxColumn.HeaderText = "High";
			this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
			this.highDataGridViewTextBoxColumn.ReadOnly = true;
			this.highDataGridViewTextBoxColumn.Width = 80;
			// 
			// lowDataGridViewTextBoxColumn
			// 
			this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = null;
			this.lowDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
			this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
			this.lowDataGridViewTextBoxColumn.ReadOnly = true;
			this.lowDataGridViewTextBoxColumn.Width = 80;
			// 
			// barEntryBindingSource
			// 
			this.barEntryBindingSource.DataSource = typeof(OEC.API.Example.BarEntry);
			// 
			// splitter1
			// 
			this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 289);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(685, 6);
			this.splitter1.TabIndex = 5;
			this.splitter1.TabStop = false;
			// 
			// ChartsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Caption = "Charts";
			this.Controls.Add(this.chart);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.dgBars);
			this.Controls.Add(this.panel1);
			this.Name = "ChartsControl";
			this.Size = new System.Drawing.Size(685, 395);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.dgBars, 0);
			this.Controls.SetChildIndex(this.splitter1, 0);
			this.Controls.SetChildIndex(this.chart, 0);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgBars)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barEntryBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTimeScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private OLHCChart chart;
        private System.Windows.Forms.DataGridView dgBars;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource barEntryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private ContractCombo cbSymbol;
    }
}

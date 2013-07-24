namespace OEC.API.Example
{
    partial class HistogramControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.histogramChart = new OEC.API.Example.HistogramChart();
            this.dgHistogram = new System.Windows.Forms.DataGridView();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 4);
            this.panel1.TabIndex = 1;
            // 
            // histogramChart
            // 
            this.histogramChart.AutoScroll = true;
            this.histogramChart.BackColor = System.Drawing.Color.Silver;
            this.histogramChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogramChart.Location = new System.Drawing.Point(0, 17);
            this.histogramChart.Name = "histogramChart";
            this.histogramChart.Size = new System.Drawing.Size(440, 303);
            this.histogramChart.TabIndex = 2;
            // 
            // dgHistogram
            // 
            this.dgHistogram.AutoGenerateColumns = false;
            this.dgHistogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHistogram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistogram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dgHistogram.DataSource = this.histEntryBindingSource;
            this.dgHistogram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgHistogram.Location = new System.Drawing.Point(0, 326);
            this.dgHistogram.Name = "dgHistogram";
            this.dgHistogram.RowHeadersVisible = false;
            this.dgHistogram.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHistogram.Size = new System.Drawing.Size(440, 97);
            this.dgHistogram.TabIndex = 5;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
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
            // histEntryBindingSource
            // 
            this.histEntryBindingSource.DataSource = typeof(OEC.API.Example.HistEntry);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 320);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(440, 6);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // HistogramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "Histogram";
            this.Controls.Add(this.histogramChart);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgHistogram);
            this.Controls.Add(this.panel1);
            this.Name = "HistogramControl";
            this.Size = new System.Drawing.Size(440, 423);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgHistogram, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.histogramChart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histEntryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private HistogramChart histogramChart;
        private System.Windows.Forms.DataGridView dgHistogram;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource histEntryBindingSource;
    }
}

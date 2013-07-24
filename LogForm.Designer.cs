namespace OEC.API.Example
{
	partial class LogForm
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
			this.logBox = new System.Windows.Forms.ListBox();
			this.btClear = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.chbCore = new System.Windows.Forms.CheckBox();
			this.chbTransport = new System.Windows.Forms.CheckBox();
			this.chbPriceFeed = new System.Windows.Forms.CheckBox();
			this.chbApplication = new System.Windows.Forms.CheckBox();
			this.edIndexNum = new System.Windows.Forms.NumericUpDown();
			this.edInterval = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.edIndexNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// logBox
			// 
			this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logBox.FormattingEnabled = true;
			this.logBox.Location = new System.Drawing.Point(12, 49);
			this.logBox.Name = "logBox";
			this.logBox.Size = new System.Drawing.Size(824, 225);
			this.logBox.TabIndex = 0;
			// 
			// btClear
			// 
			this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btClear.Location = new System.Drawing.Point(15, 287);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 23);
			this.btClear.TabIndex = 1;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// btClose
			// 
			this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btClose.Location = new System.Drawing.Point(761, 287);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 23);
			this.btClose.TabIndex = 2;
			this.btClose.Text = "Close";
			this.btClose.UseVisualStyleBackColor = true;
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// chbCore
			// 
			this.chbCore.AutoSize = true;
			this.chbCore.Checked = true;
			this.chbCore.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbCore.Enabled = false;
			this.chbCore.Location = new System.Drawing.Point(25, 20);
			this.chbCore.Name = "chbCore";
			this.chbCore.Size = new System.Drawing.Size(48, 17);
			this.chbCore.TabIndex = 3;
			this.chbCore.Text = "Core";
			this.chbCore.UseVisualStyleBackColor = true;
			// 
			// chbTransport
			// 
			this.chbTransport.AutoSize = true;
			this.chbTransport.Checked = true;
			this.chbTransport.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbTransport.Location = new System.Drawing.Point(83, 20);
			this.chbTransport.Name = "chbTransport";
			this.chbTransport.Size = new System.Drawing.Size(71, 17);
			this.chbTransport.TabIndex = 4;
			this.chbTransport.Text = "Transport";
			this.chbTransport.UseVisualStyleBackColor = true;
			this.chbTransport.CheckedChanged += new System.EventHandler(this.chbTransport_CheckedChanged);
			// 
			// chbPriceFeed
			// 
			this.chbPriceFeed.AutoSize = true;
			this.chbPriceFeed.Checked = true;
			this.chbPriceFeed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbPriceFeed.Location = new System.Drawing.Point(164, 20);
			this.chbPriceFeed.Name = "chbPriceFeed";
			this.chbPriceFeed.Size = new System.Drawing.Size(77, 17);
			this.chbPriceFeed.TabIndex = 5;
			this.chbPriceFeed.Text = "Price Feed";
			this.chbPriceFeed.UseVisualStyleBackColor = true;
			this.chbPriceFeed.CheckedChanged += new System.EventHandler(this.chbTransport_CheckedChanged);
			// 
			// chbApplication
			// 
			this.chbApplication.AutoSize = true;
			this.chbApplication.Checked = true;
			this.chbApplication.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbApplication.Location = new System.Drawing.Point(251, 20);
			this.chbApplication.Name = "chbApplication";
			this.chbApplication.Size = new System.Drawing.Size(78, 17);
			this.chbApplication.TabIndex = 6;
			this.chbApplication.Text = "Application";
			this.chbApplication.UseVisualStyleBackColor = true;
			this.chbApplication.CheckedChanged += new System.EventHandler(this.chbTransport_CheckedChanged);
			// 
			// edIndexNum
			// 
			this.edIndexNum.Location = new System.Drawing.Point(493, 19);
			this.edIndexNum.Name = "edIndexNum";
			this.edIndexNum.Size = new System.Drawing.Size(33, 20);
			this.edIndexNum.TabIndex = 7;
			this.edIndexNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.edIndexNum.ValueChanged += new System.EventHandler(this.edIndexNum_ValueChanged);
			// 
			// edInterval
			// 
			this.edInterval.Location = new System.Drawing.Point(699, 19);
			this.edInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.edInterval.Name = "edInterval";
			this.edInterval.Size = new System.Drawing.Size(36, 20);
			this.edInterval.TabIndex = 8;
			this.edInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.edInterval.ValueChanged += new System.EventHandler(this.edIndexNum_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(342, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Price feed logging: Log every:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(532, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "message, but not more often than: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(741, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "sec";
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 321);
			this.Controls.Add(this.edInterval);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edIndexNum);
			this.Controls.Add(this.chbApplication);
			this.Controls.Add(this.chbPriceFeed);
			this.Controls.Add(this.chbTransport);
			this.Controls.Add(this.chbCore);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.logBox);
			this.Name = "LogForm";
			this.Text = "API Log";
			((System.ComponentModel.ISupportInitialize)(this.edIndexNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox logBox;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.CheckBox chbCore;
		private System.Windows.Forms.CheckBox chbTransport;
		private System.Windows.Forms.CheckBox chbPriceFeed;
		private System.Windows.Forms.CheckBox chbApplication;
		private System.Windows.Forms.NumericUpDown edIndexNum;
		private System.Windows.Forms.NumericUpDown edInterval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}
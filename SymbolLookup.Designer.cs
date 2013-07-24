namespace OEC.API.Example
{
    partial class SymbolLookup
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
            this.edText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btSearch = new System.Windows.Forms.Button();
            this.cbContractGroup = new System.Windows.Forms.ComboBox();
            this.cbExchangeFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbFutures = new System.Windows.Forms.CheckBox();
            this.chbForex = new System.Windows.Forms.CheckBox();
            this.edMaxResults = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxResults)).BeginInit();
            this.SuspendLayout();
            // 
            // edText
            // 
            this.edText.Location = new System.Drawing.Point(62, 29);
            this.edText.Name = "edText";
            this.edText.Size = new System.Drawing.Size(234, 20);
            this.edText.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search:";
            // 
            // lvResults
            // 
            this.lvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvResults.Location = new System.Drawing.Point(3, 85);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(592, 173);
            this.lvResults.TabIndex = 9;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Symbol";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kind";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Exchange";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Group";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Start";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "End";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(436, 56);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(63, 23);
            this.btSearch.TabIndex = 12;
            this.btSearch.Text = "Lookup";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.SearchClick);
            // 
            // cbContractGroup
            // 
            this.cbContractGroup.DropDownHeight = 180;
            this.cbContractGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractGroup.DropDownWidth = 120;
            this.cbContractGroup.FormattingEnabled = true;
            this.cbContractGroup.IntegralHeight = false;
            this.cbContractGroup.Location = new System.Drawing.Point(62, 56);
            this.cbContractGroup.Name = "cbContractGroup";
            this.cbContractGroup.Size = new System.Drawing.Size(82, 21);
            this.cbContractGroup.TabIndex = 33;
            // 
            // cbExchangeFilter
            // 
            this.cbExchangeFilter.DropDownHeight = 180;
            this.cbExchangeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExchangeFilter.DropDownWidth = 120;
            this.cbExchangeFilter.FormattingEnabled = true;
            this.cbExchangeFilter.IntegralHeight = false;
            this.cbExchangeFilter.Location = new System.Drawing.Point(214, 56);
            this.cbExchangeFilter.Name = "cbExchangeFilter";
            this.cbExchangeFilter.Size = new System.Drawing.Size(82, 21);
            this.cbExchangeFilter.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Exchange:";
            // 
            // chbFutures
            // 
            this.chbFutures.AutoSize = true;
            this.chbFutures.Checked = true;
            this.chbFutures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFutures.Location = new System.Drawing.Point(311, 31);
            this.chbFutures.Name = "chbFutures";
            this.chbFutures.Size = new System.Drawing.Size(61, 17);
            this.chbFutures.TabIndex = 39;
            this.chbFutures.Text = "Futures";
            this.chbFutures.UseVisualStyleBackColor = true;
            // 
            // chbForex
            // 
            this.chbForex.AutoSize = true;
            this.chbForex.Checked = true;
            this.chbForex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbForex.Location = new System.Drawing.Point(378, 31);
            this.chbForex.Name = "chbForex";
            this.chbForex.Size = new System.Drawing.Size(52, 17);
            this.chbForex.TabIndex = 40;
            this.chbForex.Text = "Forex";
            this.chbForex.UseVisualStyleBackColor = true;
            // 
            // edMaxResults
            // 
            this.edMaxResults.Location = new System.Drawing.Point(378, 57);
            this.edMaxResults.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edMaxResults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edMaxResults.Name = "edMaxResults";
            this.edMaxResults.Size = new System.Drawing.Size(43, 20);
            this.edMaxResults.TabIndex = 43;
            this.edMaxResults.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Max Results:";
            // 
            // SymbolLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Symbol Lookup";
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edMaxResults);
            this.Controls.Add(this.chbForex);
            this.Controls.Add(this.chbFutures);
            this.Controls.Add(this.cbContractGroup);
            this.Controls.Add(this.cbExchangeFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.edText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvResults);
            this.MinimumSize = new System.Drawing.Size(507, 130);
            this.Name = "SymbolLookup";
            this.Size = new System.Drawing.Size(598, 261);
            this.Controls.SetChildIndex(this.lvResults, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edText, 0);
            this.Controls.SetChildIndex(this.btSearch, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cbExchangeFilter, 0);
            this.Controls.SetChildIndex(this.cbContractGroup, 0);
            this.Controls.SetChildIndex(this.chbFutures, 0);
            this.Controls.SetChildIndex(this.chbForex, 0);
            this.Controls.SetChildIndex(this.edMaxResults, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.edMaxResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ComboBox cbContractGroup;
        private System.Windows.Forms.ComboBox cbExchangeFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbFutures;
        private System.Windows.Forms.CheckBox chbForex;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.NumericUpDown edMaxResults;
        private System.Windows.Forms.Label label2;
    }
}

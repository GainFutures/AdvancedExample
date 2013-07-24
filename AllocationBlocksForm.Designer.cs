namespace OEC.API.Example
{
    partial class AllocationBlocksForm
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
            this.cbAB = new System.Windows.Forms.ComboBox();
            this.btAddAB = new System.Windows.Forms.Button();
            this.btDeleteAB = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.btDeleteItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgABItems = new System.Windows.Forms.DataGridView();
            this.accountIdDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serAllocationBlockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbRule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgABItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serAllocationBlockItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAB
            // 
            this.cbAB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAB.FormattingEnabled = true;
            this.cbAB.Location = new System.Drawing.Point(53, 6);
            this.cbAB.Name = "cbAB";
            this.cbAB.Size = new System.Drawing.Size(155, 21);
            this.cbAB.TabIndex = 0;
            this.cbAB.SelectedIndexChanged += new System.EventHandler(this.cbAB_SelectedIndexChanged);
            // 
            // btAddAB
            // 
            this.btAddAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddAB.Location = new System.Drawing.Point(214, 21);
            this.btAddAB.Name = "btAddAB";
            this.btAddAB.Size = new System.Drawing.Size(75, 23);
            this.btAddAB.TabIndex = 2;
            this.btAddAB.Text = "Add";
            this.btAddAB.UseVisualStyleBackColor = true;
            this.btAddAB.Click += new System.EventHandler(this.btAddAB_Click);
            // 
            // btDeleteAB
            // 
            this.btDeleteAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteAB.Location = new System.Drawing.Point(295, 21);
            this.btDeleteAB.Name = "btDeleteAB";
            this.btDeleteAB.Size = new System.Drawing.Size(75, 23);
            this.btDeleteAB.TabIndex = 3;
            this.btDeleteAB.Text = "Delete";
            this.btDeleteAB.UseVisualStyleBackColor = true;
            this.btDeleteAB.Click += new System.EventHandler(this.btDeleteAB_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddItem.Location = new System.Drawing.Point(11, 217);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(25, 23);
            this.btAddItem.TabIndex = 1;
            this.btAddItem.Text = "+";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // btDeleteItem
            // 
            this.btDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteItem.Location = new System.Drawing.Point(42, 217);
            this.btDeleteItem.Name = "btDeleteItem";
            this.btDeleteItem.Size = new System.Drawing.Size(25, 23);
            this.btDeleteItem.TabIndex = 2;
            this.btDeleteItem.Text = "-";
            this.btDeleteItem.UseVisualStyleBackColor = true;
            this.btDeleteItem.Click += new System.EventHandler(this.btDeleteItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgABItems);
            this.groupBox1.Controls.Add(this.btDeleteItem);
            this.groupBox1.Controls.Add(this.btAddItem);
            this.groupBox1.Location = new System.Drawing.Point(6, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 253);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // dgABItems
            // 
            this.dgABItems.AllowUserToAddRows = false;
            this.dgABItems.AllowUserToDeleteRows = false;
            this.dgABItems.AllowUserToResizeRows = false;
            this.dgABItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgABItems.AutoGenerateColumns = false;
            this.dgABItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgABItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewComboBoxColumn,
            this.lotDataGridViewTextBoxColumn});
            this.dgABItems.DataSource = this.serAllocationBlockItemBindingSource;
            this.dgABItems.Location = new System.Drawing.Point(11, 19);
            this.dgABItems.Name = "dgABItems";
            this.dgABItems.Size = new System.Drawing.Size(353, 192);
            this.dgABItems.TabIndex = 0;
            this.dgABItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgABItems_CellValidating);
            this.dgABItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgABItems_DataError);
            // 
            // accountIdDataGridViewComboBoxColumn
            // 
            this.accountIdDataGridViewComboBoxColumn.DataPropertyName = "Account";
            this.accountIdDataGridViewComboBoxColumn.HeaderText = "Account";
            this.accountIdDataGridViewComboBoxColumn.Name = "accountIdDataGridViewComboBoxColumn";
            this.accountIdDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accountIdDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lotDataGridViewTextBoxColumn
            // 
            this.lotDataGridViewTextBoxColumn.DataPropertyName = "Lots";
            this.lotDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn.Name = "lotDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(203, 334);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(295, 334);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // cbRule
            // 
            this.cbRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRule.FormattingEnabled = true;
            this.cbRule.Location = new System.Drawing.Point(53, 34);
            this.cbRule.Name = "cbRule";
            this.cbRule.Size = new System.Drawing.Size(155, 21);
            this.cbRule.TabIndex = 1;
            this.cbRule.SelectedIndexChanged += new System.EventHandler(this.cbRule_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rule";
            // 
            // AllocationBlocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 365);
            this.Controls.Add(this.cbRule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDeleteAB);
            this.Controls.Add(this.btAddAB);
            this.Controls.Add(this.cbAB);
            this.MinimumSize = new System.Drawing.Size(333, 261);
            this.Name = "AllocationBlocksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Allocation Blocks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllocationBlocksForm_FormClosing);
            this.Load += new System.EventHandler(this.AllocationBlocksForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgABItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serAllocationBlockItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAB;
        private System.Windows.Forms.Button btAddAB;
        private System.Windows.Forms.Button btDeleteAB;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Button btDeleteItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbRule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgABItems;
        private System.Windows.Forms.BindingSource serAllocationBlockItemBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn accountIdDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn;
    }
}
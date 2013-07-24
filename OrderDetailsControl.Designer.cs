namespace OEC.API.Example
{
    partial class OrderDetailsControl
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
			this.dgOrderDetails = new System.Windows.Forms.DataGridView();
			this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailsEntryBindingSource = new System.Windows.Forms.BindingSource( this.components );
			((System.ComponentModel.ISupportInitialize) (this.dgOrderDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.orderDetailsEntryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgOrderDetails
			// 
			this.dgOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOrderDetails.AutoGenerateColumns = false;
			this.dgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOrderDetails.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn} );
			this.dgOrderDetails.DataSource = this.orderDetailsEntryBindingSource;
			this.dgOrderDetails.Location = new System.Drawing.Point( 3, 16 );
			this.dgOrderDetails.Name = "dgOrderDetails";
			this.dgOrderDetails.RowHeadersVisible = false;
			this.dgOrderDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgOrderDetails.Size = new System.Drawing.Size( 581, 170 );
			this.dgOrderDetails.TabIndex = 1;
			// 
			// timeStampDataGridViewTextBoxColumn
			// 
			this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
			dataGridViewCellStyle1.Format = "HH:mm:ss.fff";
			dataGridViewCellStyle1.NullValue = null;
			this.timeStampDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.timeStampDataGridViewTextBoxColumn.HeaderText = "Time Stamp";
			this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
			this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 60;
			// 
			// actionDataGridViewTextBoxColumn
			// 
			this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
			this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
			this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
			this.actionDataGridViewTextBoxColumn.ReadOnly = true;
			this.actionDataGridViewTextBoxColumn.Width = 70;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.descriptionDataGridViewTextBoxColumn.Width = 160;
			// 
			// commentDataGridViewTextBoxColumn
			// 
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.ReadOnly = true;
			this.commentDataGridViewTextBoxColumn.Width = 250;
			// 
			// orderDetailsEntryBindingSource
			// 
			this.orderDetailsEntryBindingSource.DataSource = typeof( OEC.API.Example.OrderDetailsEntry );
			// 
			// OrderDetailsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Caption = "Order details";
			this.Controls.Add( this.dgOrderDetails );
			this.Name = "OrderDetailsControl";
			this.Size = new System.Drawing.Size( 589, 189 );
			this.Controls.SetChildIndex( this.dgOrderDetails, 0 );
			((System.ComponentModel.ISupportInitialize) (this.dgOrderDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.orderDetailsEntryBindingSource)).EndInit();
			this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderDetails;
        private System.Windows.Forms.BindingSource orderDetailsEntryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

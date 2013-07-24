namespace OEC.API.Example
{
	partial class OsmAlgoParamDlg
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.edName = new System.Windows.Forms.TextBox();
			this.edDataType = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edUnits = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edEnabled = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edModifiable = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edDefaultValue = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edValue = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnValidateValue = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(158, 324);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(88, 25);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(252, 324);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 25);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edName
			// 
			this.edName.Location = new System.Drawing.Point(99, 20);
			this.edName.Name = "edName";
			this.edName.ReadOnly = true;
			this.edName.Size = new System.Drawing.Size(241, 20);
			this.edName.TabIndex = 4;
			// 
			// edDataType
			// 
			this.edDataType.Location = new System.Drawing.Point(99, 203);
			this.edDataType.Name = "edDataType";
			this.edDataType.ReadOnly = true;
			this.edDataType.Size = new System.Drawing.Size(241, 20);
			this.edDataType.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Data Type:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edUnits
			// 
			this.edUnits.Location = new System.Drawing.Point(99, 229);
			this.edUnits.Name = "edUnits";
			this.edUnits.ReadOnly = true;
			this.edUnits.Size = new System.Drawing.Size(241, 20);
			this.edUnits.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 232);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Units:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edDescription
			// 
			this.edDescription.Location = new System.Drawing.Point(99, 46);
			this.edDescription.Multiline = true;
			this.edDescription.Name = "edDescription";
			this.edDescription.ReadOnly = true;
			this.edDescription.Size = new System.Drawing.Size(241, 99);
			this.edDescription.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Description:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edEnabled
			// 
			this.edEnabled.Location = new System.Drawing.Point(99, 151);
			this.edEnabled.Name = "edEnabled";
			this.edEnabled.ReadOnly = true;
			this.edEnabled.Size = new System.Drawing.Size(241, 20);
			this.edEnabled.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(45, 154);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Enabled:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edModifiable
			// 
			this.edModifiable.Location = new System.Drawing.Point(99, 177);
			this.edModifiable.Name = "edModifiable";
			this.edModifiable.ReadOnly = true;
			this.edModifiable.Size = new System.Drawing.Size(241, 20);
			this.edModifiable.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Modifiable:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edDefaultValue
			// 
			this.edDefaultValue.Location = new System.Drawing.Point(99, 255);
			this.edDefaultValue.Name = "edDefaultValue";
			this.edDefaultValue.ReadOnly = true;
			this.edDefaultValue.Size = new System.Drawing.Size(241, 20);
			this.edDefaultValue.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 258);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Default Value:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edValue
			// 
			this.edValue.Location = new System.Drawing.Point(99, 281);
			this.edValue.Name = "edValue";
			this.edValue.Size = new System.Drawing.Size(241, 20);
			this.edValue.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(57, 284);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Value:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnValidateValue
			// 
			this.btnValidateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnValidateValue.Location = new System.Drawing.Point(6, 324);
			this.btnValidateValue.Name = "btnValidateValue";
			this.btnValidateValue.Size = new System.Drawing.Size(88, 25);
			this.btnValidateValue.TabIndex = 1;
			this.btnValidateValue.Text = "Validate value";
			this.btnValidateValue.UseVisualStyleBackColor = true;
			this.btnValidateValue.Click += new System.EventHandler(this.btnValidateValue_Click);
			// 
			// OsmAlgoParamDlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(347, 356);
			this.Controls.Add(this.btnValidateValue);
			this.Controls.Add(this.edValue);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edDefaultValue);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edModifiable);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edEnabled);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edUnits);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edDataType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OsmAlgoParamDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "OSM Algo Param";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OsmAlgoParamDlg_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edName;
		private System.Windows.Forms.TextBox edDataType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edUnits;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edEnabled;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edModifiable;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edDefaultValue;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edValue;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnValidateValue;
	}
}
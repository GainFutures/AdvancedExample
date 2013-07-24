namespace OEC.API.Example
{
	partial class OrderLinksControl
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
			if (disposing && (components != null)) {
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
			this.pnlLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// pnlLayout
			// 
			this.pnlLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLayout.AutoScroll = true;
			this.pnlLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.pnlLayout.Location = new System.Drawing.Point(0, 16);
			this.pnlLayout.Name = "pnlLayout";
			this.pnlLayout.Size = new System.Drawing.Size(320, 152);
			this.pnlLayout.TabIndex = 1;
			// 
			// OrderLinksControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Caption = "Order Links";
			this.Controls.Add(this.pnlLayout);
			this.Name = "OrderLinksControl";
			this.Controls.SetChildIndex(this.pnlLayout, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel pnlLayout;
	}
}

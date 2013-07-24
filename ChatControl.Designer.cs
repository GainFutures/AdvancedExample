namespace OEC.API.Example
{
    partial class ChatControl
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
            this.lbMessagesLog = new System.Windows.Forms.ListBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSend = new System.Windows.Forms.Button();
            this.edMessage = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMessagesLog
            // 
            this.lbMessagesLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessagesLog.FormattingEnabled = true;
            this.lbMessagesLog.Location = new System.Drawing.Point(0, 15);
            this.lbMessagesLog.Name = "lbMessagesLog";
            this.lbMessagesLog.Size = new System.Drawing.Size(230, 108);
            this.lbMessagesLog.TabIndex = 0;
            // 
            // lbUsers
            // 
            this.lbUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(233, 15);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(85, 108);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbUsers_Format);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSend);
            this.panel1.Controls.Add(this.edMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 32);
            this.panel1.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(267, 5);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(50, 22);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // edMessage
            // 
            this.edMessage.Location = new System.Drawing.Point(3, 6);
            this.edMessage.Name = "edMessage";
            this.edMessage.Size = new System.Drawing.Size(261, 20);
            this.edMessage.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(230, 15);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 119);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 2);
            this.panel2.TabIndex = 5;
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caption = "Chat";
            this.Controls.Add(this.lbMessagesLog);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(318, 166);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lbUsers, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            this.Controls.SetChildIndex(this.lbMessagesLog, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMessagesLog;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox edMessage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
    }
}

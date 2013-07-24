namespace OEC.API.Example
{
    partial class MainForm
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblAccountInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiDisconnect = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allocationBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPageMessages = new System.Windows.Forms.TabPage();
			this.splitContainerMessages = new System.Windows.Forms.SplitContainer();
			this.chatControl = new OEC.API.Example.ChatControl();
			this.newsControl1 = new OEC.API.Example.NewsControl();
			this.tabPageCharts = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.chartsControl1 = new OEC.API.Example.ChartsControl();
			this.histogramControl1 = new OEC.API.Example.HistogramControl();
			this.tabPageQuotes = new System.Windows.Forms.TabPage();
			this.splitContainerQuotes = new System.Windows.Forms.SplitContainer();
			this.pricesControl1 = new OEC.API.Example.PricesControl();
			this.domControl1 = new OEC.API.Example.DOMControl();
			this.tabPagePositions = new System.Windows.Forms.TabPage();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.balanceControl1 = new OEC.API.Example.BalanceControl();
			this.averagePositionsControl1 = new OEC.API.Example.AveragePositionsControl();
			this.tabPageOrders = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ordersControl = new OEC.API.Example.OrdersControl();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.orderDetailsControl1 = new OEC.API.Example.OrderDetailsControl();
			this.eventLogControl1 = new OEC.API.Example.EventLogControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageOsmOrders = new System.Windows.Forms.TabPage();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.osmOrdersControl = new OEC.API.Example.OsmOrdersControl();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.osmOrderDetailsControl = new OEC.API.Example.OrderDetailsControl();
			this.eventLogControl2 = new OEC.API.Example.EventLogControl();
			this.tabPageSymbolLookup = new System.Windows.Forms.TabPage();
			this.symbolLookup1 = new OEC.API.Example.SymbolLookup();
			this.splitContainer7 = new System.Windows.Forms.SplitContainer();
			this.splitContainer8 = new System.Windows.Forms.SplitContainer();
			this.eventLogControl3 = new OEC.API.Example.EventLogControl();
			this.tickViewTabPage = new System.Windows.Forms.TabPage();
			this.tickViewControl1 = new OEC.API.Example.TickViewControl();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemShowLog = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tabPageMessages.SuspendLayout();
			this.splitContainerMessages.Panel1.SuspendLayout();
			this.splitContainerMessages.Panel2.SuspendLayout();
			this.splitContainerMessages.SuspendLayout();
			this.tabPageCharts.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabPageQuotes.SuspendLayout();
			this.splitContainerQuotes.Panel1.SuspendLayout();
			this.splitContainerQuotes.Panel2.SuspendLayout();
			this.splitContainerQuotes.SuspendLayout();
			this.tabPagePositions.SuspendLayout();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.tabPageOrders.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageOsmOrders.SuspendLayout();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			this.tabPageSymbolLookup.SuspendLayout();
			this.splitContainer7.Panel1.SuspendLayout();
			this.splitContainer7.Panel2.SuspendLayout();
			this.splitContainer7.SuspendLayout();
			this.splitContainer8.Panel1.SuspendLayout();
			this.splitContainer8.Panel2.SuspendLayout();
			this.splitContainer8.SuspendLayout();
			this.tickViewTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnectionStatus,
            this.lblAccountInfo});
			this.statusStrip1.Location = new System.Drawing.Point(0, 679);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblConnectionStatus
			// 
			this.lblConnectionStatus.AutoSize = false;
			this.lblConnectionStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.lblConnectionStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.lblConnectionStatus.Name = "lblConnectionStatus";
			this.lblConnectionStatus.Size = new System.Drawing.Size(100, 17);
			this.lblConnectionStatus.Text = "Disconnected";
			// 
			// lblAccountInfo
			// 
			this.lblAccountInfo.AutoSize = false;
			this.lblAccountInfo.Name = "lblAccountInfo";
			this.lblAccountInfo.Size = new System.Drawing.Size(685, 17);
			this.lblAccountInfo.Spring = true;
			this.lblAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.accountsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.tiDisconnect,
            this.toolStripSeparator1,
            this.toolStripMenuItemShowLog,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItem1.Text = "File";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loginToolStripMenuItem.Text = "Connect...";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
			// 
			// tiDisconnect
			// 
			this.tiDisconnect.Name = "tiDisconnect";
			this.tiDisconnect.Size = new System.Drawing.Size(152, 22);
			this.tiDisconnect.Text = "Disconnect";
			this.tiDisconnect.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// accountsToolStripMenuItem
			// 
			this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAccountToolStripMenuItem,
            this.allocationBlocksToolStripMenuItem});
			this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
			this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.accountsToolStripMenuItem.Text = "Accounts";
			// 
			// selectAccountToolStripMenuItem
			// 
			this.selectAccountToolStripMenuItem.Name = "selectAccountToolStripMenuItem";
			this.selectAccountToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.selectAccountToolStripMenuItem.Text = "Select Account";
			// 
			// allocationBlocksToolStripMenuItem
			// 
			this.allocationBlocksToolStripMenuItem.Name = "allocationBlocksToolStripMenuItem";
			this.allocationBlocksToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.allocationBlocksToolStripMenuItem.Text = "Allocation Blocks...";
			this.allocationBlocksToolStripMenuItem.Visible = false;
			this.allocationBlocksToolStripMenuItem.Click += new System.EventHandler(this.allocationBlocksToolStripMenuItem_Click);
			// 
			// tabPageMessages
			// 
			this.tabPageMessages.Controls.Add(this.splitContainerMessages);
			this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
			this.tabPageMessages.Name = "tabPageMessages";
			this.tabPageMessages.Size = new System.Drawing.Size(792, 629);
			this.tabPageMessages.TabIndex = 2;
			this.tabPageMessages.Text = "Messages";
			this.tabPageMessages.UseVisualStyleBackColor = true;
			// 
			// splitContainerMessages
			// 
			this.splitContainerMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMessages.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMessages.Name = "splitContainerMessages";
			this.splitContainerMessages.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMessages.Panel1
			// 
			this.splitContainerMessages.Panel1.Controls.Add(this.chatControl);
			// 
			// splitContainerMessages.Panel2
			// 
			this.splitContainerMessages.Panel2.Controls.Add(this.newsControl1);
			this.splitContainerMessages.Size = new System.Drawing.Size(792, 629);
			this.splitContainerMessages.SplitterDistance = 314;
			this.splitContainerMessages.TabIndex = 3;
			// 
			// chatControl
			// 
			this.chatControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chatControl.Caption = "Chat";
			this.chatControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chatControl.Location = new System.Drawing.Point(0, 0);
			this.chatControl.Name = "chatControl";
			this.chatControl.Size = new System.Drawing.Size(792, 314);
			this.chatControl.TabIndex = 0;
			// 
			// newsControl1
			// 
			this.newsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.newsControl1.Caption = "News";
			this.newsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newsControl1.Location = new System.Drawing.Point(0, 0);
			this.newsControl1.Name = "newsControl1";
			this.newsControl1.Size = new System.Drawing.Size(792, 311);
			this.newsControl1.TabIndex = 0;
			// 
			// tabPageCharts
			// 
			this.tabPageCharts.Controls.Add(this.splitContainer2);
			this.tabPageCharts.Location = new System.Drawing.Point(4, 22);
			this.tabPageCharts.Name = "tabPageCharts";
			this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCharts.Size = new System.Drawing.Size(792, 629);
			this.tabPageCharts.TabIndex = 1;
			this.tabPageCharts.Text = "Charts";
			this.tabPageCharts.UseVisualStyleBackColor = true;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.chartsControl1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.histogramControl1);
			this.splitContainer2.Size = new System.Drawing.Size(786, 623);
			this.splitContainer2.SplitterDistance = 310;
			this.splitContainer2.TabIndex = 1;
			// 
			// chartsControl1
			// 
			this.chartsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chartsControl1.Caption = "Charts";
			this.chartsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartsControl1.Location = new System.Drawing.Point(0, 0);
			this.chartsControl1.Name = "chartsControl1";
			this.chartsControl1.Size = new System.Drawing.Size(786, 310);
			this.chartsControl1.TabIndex = 0;
			// 
			// histogramControl1
			// 
			this.histogramControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.histogramControl1.Caption = "Histogram";
			this.histogramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.histogramControl1.Location = new System.Drawing.Point(0, 0);
			this.histogramControl1.Name = "histogramControl1";
			this.histogramControl1.Size = new System.Drawing.Size(786, 309);
			this.histogramControl1.TabIndex = 0;
			// 
			// tabPageQuotes
			// 
			this.tabPageQuotes.Controls.Add(this.splitContainerQuotes);
			this.tabPageQuotes.Location = new System.Drawing.Point(4, 22);
			this.tabPageQuotes.Name = "tabPageQuotes";
			this.tabPageQuotes.Size = new System.Drawing.Size(792, 629);
			this.tabPageQuotes.TabIndex = 5;
			this.tabPageQuotes.Text = "Quotes";
			this.tabPageQuotes.UseVisualStyleBackColor = true;
			// 
			// splitContainerQuotes
			// 
			this.splitContainerQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerQuotes.Location = new System.Drawing.Point(0, 0);
			this.splitContainerQuotes.Name = "splitContainerQuotes";
			// 
			// splitContainerQuotes.Panel1
			// 
			this.splitContainerQuotes.Panel1.Controls.Add(this.pricesControl1);
			// 
			// splitContainerQuotes.Panel2
			// 
			this.splitContainerQuotes.Panel2.Controls.Add(this.domControl1);
			this.splitContainerQuotes.Size = new System.Drawing.Size(792, 629);
			this.splitContainerQuotes.SplitterDistance = 433;
			this.splitContainerQuotes.TabIndex = 0;
			// 
			// pricesControl1
			// 
			this.pricesControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pricesControl1.Caption = "Quotes";
			this.pricesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pricesControl1.Location = new System.Drawing.Point(0, 0);
			this.pricesControl1.Name = "pricesControl1";
			this.pricesControl1.Size = new System.Drawing.Size(433, 629);
			this.pricesControl1.TabIndex = 0;
			// 
			// domControl1
			// 
			this.domControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.domControl1.Caption = "DOM";
			this.domControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.domControl1.Location = new System.Drawing.Point(0, 0);
			this.domControl1.Name = "domControl1";
			this.domControl1.Size = new System.Drawing.Size(355, 629);
			this.domControl1.TabIndex = 0;
			// 
			// tabPagePositions
			// 
			this.tabPagePositions.Controls.Add(this.splitContainer4);
			this.tabPagePositions.Location = new System.Drawing.Point(4, 22);
			this.tabPagePositions.Name = "tabPagePositions";
			this.tabPagePositions.Size = new System.Drawing.Size(792, 629);
			this.tabPagePositions.TabIndex = 4;
			this.tabPagePositions.Text = "Positions/Balance";
			this.tabPagePositions.UseVisualStyleBackColor = true;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.balanceControl1);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.averagePositionsControl1);
			this.splitContainer4.Size = new System.Drawing.Size(792, 629);
			this.splitContainer4.SplitterDistance = 105;
			this.splitContainer4.TabIndex = 0;
			// 
			// balanceControl1
			// 
			this.balanceControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.balanceControl1.Caption = "Balance";
			this.balanceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.balanceControl1.Location = new System.Drawing.Point(0, 0);
			this.balanceControl1.Name = "balanceControl1";
			this.balanceControl1.Size = new System.Drawing.Size(792, 105);
			this.balanceControl1.TabIndex = 0;
			// 
			// averagePositionsControl1
			// 
			this.averagePositionsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.averagePositionsControl1.Caption = "Average Position";
			this.averagePositionsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.averagePositionsControl1.Location = new System.Drawing.Point(0, 0);
			this.averagePositionsControl1.Name = "averagePositionsControl1";
			this.averagePositionsControl1.Size = new System.Drawing.Size(792, 520);
			this.averagePositionsControl1.TabIndex = 0;
			// 
			// tabPageOrders
			// 
			this.tabPageOrders.Controls.Add(this.splitContainer1);
			this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
			this.tabPageOrders.Name = "tabPageOrders";
			this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOrders.Size = new System.Drawing.Size(792, 629);
			this.tabPageOrders.TabIndex = 0;
			this.tabPageOrders.Text = "Orders";
			this.tabPageOrders.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ordersControl);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(786, 623);
			this.splitContainer1.SplitterDistance = 382;
			this.splitContainer1.TabIndex = 1;
			// 
			// ordersControl
			// 
			this.ordersControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ordersControl.Caption = "Orders";
			this.ordersControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ordersControl.Location = new System.Drawing.Point(0, 0);
			this.ordersControl.Name = "ordersControl";
			this.ordersControl.Size = new System.Drawing.Size(786, 382);
			this.ordersControl.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.orderDetailsControl1);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.eventLogControl1);
			this.splitContainer3.Size = new System.Drawing.Size(786, 237);
			this.splitContainer3.SplitterDistance = 147;
			this.splitContainer3.TabIndex = 1;
			// 
			// orderDetailsControl1
			// 
			this.orderDetailsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.orderDetailsControl1.Caption = "Order details";
			this.orderDetailsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderDetailsControl1.Location = new System.Drawing.Point(0, 0);
			this.orderDetailsControl1.Name = "orderDetailsControl1";
			this.orderDetailsControl1.Size = new System.Drawing.Size(786, 147);
			this.orderDetailsControl1.TabIndex = 0;
			// 
			// eventLogControl1
			// 
			this.eventLogControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eventLogControl1.Caption = "Order Events";
			this.eventLogControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventLogControl1.Location = new System.Drawing.Point(0, 0);
			this.eventLogControl1.Name = "eventLogControl1";
			this.eventLogControl1.Size = new System.Drawing.Size(786, 86);
			this.eventLogControl1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageOrders);
			this.tabControl1.Controls.Add(this.tabPageOsmOrders);
			this.tabControl1.Controls.Add(this.tabPagePositions);
			this.tabControl1.Controls.Add(this.tabPageQuotes);
			this.tabControl1.Controls.Add(this.tabPageCharts);
			this.tabControl1.Controls.Add(this.tabPageMessages);
			this.tabControl1.Controls.Add(this.tabPageSymbolLookup);
			this.tabControl1.Controls.Add(this.tickViewTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 655);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPageOsmOrders
			// 
			this.tabPageOsmOrders.Controls.Add(this.splitContainer5);
			this.tabPageOsmOrders.Location = new System.Drawing.Point(4, 22);
			this.tabPageOsmOrders.Name = "tabPageOsmOrders";
			this.tabPageOsmOrders.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOsmOrders.Size = new System.Drawing.Size(792, 629);
			this.tabPageOsmOrders.TabIndex = 6;
			this.tabPageOsmOrders.Text = "OSM Orders";
			this.tabPageOsmOrders.UseVisualStyleBackColor = true;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new System.Drawing.Point(3, 3);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.osmOrdersControl);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
			this.splitContainer5.Size = new System.Drawing.Size(786, 623);
			this.splitContainer5.SplitterDistance = 310;
			this.splitContainer5.TabIndex = 0;
			// 
			// osmOrdersControl
			// 
			this.osmOrdersControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.osmOrdersControl.Caption = "OSM Orders";
			this.osmOrdersControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.osmOrdersControl.Location = new System.Drawing.Point(0, 0);
			this.osmOrdersControl.Name = "osmOrdersControl";
			this.osmOrdersControl.Size = new System.Drawing.Size(786, 310);
			this.osmOrdersControl.TabIndex = 0;
			// 
			// splitContainer6
			// 
			this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer6.Location = new System.Drawing.Point(0, 0);
			this.splitContainer6.Name = "splitContainer6";
			this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.Controls.Add(this.osmOrderDetailsControl);
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.Controls.Add(this.eventLogControl2);
			this.splitContainer6.Size = new System.Drawing.Size(786, 309);
			this.splitContainer6.SplitterDistance = 171;
			this.splitContainer6.TabIndex = 0;
			// 
			// osmOrderDetailsControl
			// 
			this.osmOrderDetailsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.osmOrderDetailsControl.Caption = "Order details";
			this.osmOrderDetailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.osmOrderDetailsControl.Location = new System.Drawing.Point(0, 0);
			this.osmOrderDetailsControl.Name = "osmOrderDetailsControl";
			this.osmOrderDetailsControl.Size = new System.Drawing.Size(786, 171);
			this.osmOrderDetailsControl.TabIndex = 1;
			// 
			// eventLogControl2
			// 
			this.eventLogControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eventLogControl2.Caption = "Order Events";
			this.eventLogControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventLogControl2.Location = new System.Drawing.Point(0, 0);
			this.eventLogControl2.Name = "eventLogControl2";
			this.eventLogControl2.Size = new System.Drawing.Size(786, 134);
			this.eventLogControl2.TabIndex = 1;
			// 
			// tabPageSymbolLookup
			// 
			this.tabPageSymbolLookup.Controls.Add(this.symbolLookup1);
			this.tabPageSymbolLookup.Location = new System.Drawing.Point(4, 22);
			this.tabPageSymbolLookup.Name = "tabPageSymbolLookup";
			this.tabPageSymbolLookup.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSymbolLookup.Size = new System.Drawing.Size(792, 629);
			this.tabPageSymbolLookup.TabIndex = 7;
			this.tabPageSymbolLookup.Text = "Symbol Lookup";
			this.tabPageSymbolLookup.UseVisualStyleBackColor = true;
			// 
			// symbolLookup1
			// 
			this.symbolLookup1.Caption = "Symbol Lookup";
			this.symbolLookup1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.symbolLookup1.Location = new System.Drawing.Point(3, 3);
			this.symbolLookup1.MinimumSize = new System.Drawing.Size(507, 130);
			this.symbolLookup1.Name = "symbolLookup1";
			this.symbolLookup1.Size = new System.Drawing.Size(786, 623);
			this.symbolLookup1.TabIndex = 0;
			// 
			// splitContainer7
			// 
			this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer7.Location = new System.Drawing.Point(3, 3);
			this.splitContainer7.Name = "splitContainer7";
			this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer7.Panel2
			// 
			this.splitContainer7.Panel2.Controls.Add(this.splitContainer8);
			this.splitContainer7.Size = new System.Drawing.Size(786, 623);
			this.splitContainer7.SplitterDistance = 382;
			this.splitContainer7.TabIndex = 2;
			// 
			// splitContainer8
			// 
			this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer8.Location = new System.Drawing.Point(0, 0);
			this.splitContainer8.Name = "splitContainer8";
			this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer8.Panel2
			// 
			this.splitContainer8.Panel2.Controls.Add(this.eventLogControl3);
			this.splitContainer8.Size = new System.Drawing.Size(786, 237);
			this.splitContainer8.SplitterDistance = 147;
			this.splitContainer8.TabIndex = 1;
			// 
			// eventLogControl3
			// 
			this.eventLogControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eventLogControl3.Caption = "Order Events";
			this.eventLogControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventLogControl3.Location = new System.Drawing.Point(0, 0);
			this.eventLogControl3.Name = "eventLogControl3";
			this.eventLogControl3.Size = new System.Drawing.Size(786, 86);
			this.eventLogControl3.TabIndex = 0;
			// 
			// tickViewTabPage
			// 
			this.tickViewTabPage.Controls.Add(this.tickViewControl1);
			this.tickViewTabPage.Location = new System.Drawing.Point(4, 22);
			this.tickViewTabPage.Name = "tickViewTabPage";
			this.tickViewTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.tickViewTabPage.Size = new System.Drawing.Size(792, 629);
			this.tickViewTabPage.TabIndex = 9;
			this.tickViewTabPage.Text = "Tick View";
			this.tickViewTabPage.UseVisualStyleBackColor = true;
			// 
			// tickViewControl1
			// 
			this.tickViewControl1.Caption = "Tick View";
			this.tickViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tickViewControl1.Location = new System.Drawing.Point(3, 3);
			this.tickViewControl1.Name = "tickViewControl1";
			this.tickViewControl1.Size = new System.Drawing.Size(786, 623);
			this.tickViewControl1.TabIndex = 0;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// toolStripMenuItemShowLog
			// 
			this.toolStripMenuItemShowLog.Name = "toolStripMenuItemShowLog";
			this.toolStripMenuItemShowLog.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItemShowLog.Text = "Show API Log";
			this.toolStripMenuItemShowLog.Click += new System.EventHandler(this.toolStripMenuItemShowLog_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 701);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MinimumSize = new System.Drawing.Size(600, 534);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OEC API Example";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPageMessages.ResumeLayout(false);
			this.splitContainerMessages.Panel1.ResumeLayout(false);
			this.splitContainerMessages.Panel2.ResumeLayout(false);
			this.splitContainerMessages.ResumeLayout(false);
			this.tabPageCharts.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.tabPageQuotes.ResumeLayout(false);
			this.splitContainerQuotes.Panel1.ResumeLayout(false);
			this.splitContainerQuotes.Panel2.ResumeLayout(false);
			this.splitContainerQuotes.ResumeLayout(false);
			this.tabPagePositions.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.ResumeLayout(false);
			this.tabPageOrders.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageOsmOrders.ResumeLayout(false);
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			this.splitContainer5.ResumeLayout(false);
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel2.ResumeLayout(false);
			this.splitContainer6.ResumeLayout(false);
			this.tabPageSymbolLookup.ResumeLayout(false);
			this.splitContainer7.Panel1.ResumeLayout(false);
			this.splitContainer7.Panel2.ResumeLayout(false);
			this.splitContainer7.ResumeLayout(false);
			this.splitContainer8.Panel1.ResumeLayout(false);
			this.splitContainer8.Panel2.ResumeLayout(false);
			this.splitContainer8.ResumeLayout(false);
			this.tickViewTabPage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblAccountInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.SplitContainer splitContainerMessages;
        private ChatControl chatControl;
        private NewsControl newsControl1;
        private System.Windows.Forms.TabPage tabPageCharts;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ChartsControl chartsControl1;
        private HistogramControl histogramControl1;
        private System.Windows.Forms.TabPage tabPageQuotes;
        private System.Windows.Forms.SplitContainer splitContainerQuotes;
        private PricesControl pricesControl1;
        private DOMControl domControl1;
        private System.Windows.Forms.TabPage tabPagePositions;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private OrderDetailsControl orderDetailsControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private EventLogControl eventLogControl1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private BalanceControl balanceControl1;
        private AveragePositionsControl averagePositionsControl1;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocationBlocksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiDisconnect;
		private System.Windows.Forms.TabPage tabPageOsmOrders;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.SplitContainer splitContainer6;
		private OrderDetailsControl osmOrderDetailsControl;
		private EventLogControl eventLogControl2;
		private OsmOrdersControl osmOrdersControl;
        private System.Windows.Forms.TabPage tabPageSymbolLookup;
        private SymbolLookup symbolLookup1;
        private OrdersControl ordersControl;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private EventLogControl eventLogControl3;
		private System.Windows.Forms.TabPage tickViewTabPage;
		private TickViewControl tickViewControl1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowLog;
    }
}


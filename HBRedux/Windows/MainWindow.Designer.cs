namespace HBRedux
{
    partial class MainWindow
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceDeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.failuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyOneMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyOneYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entireRecordingPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpHomepageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSettingsMenu,
            this.FileExitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // FileSettingsMenu
            // 
            this.FileSettingsMenu.Name = "FileSettingsMenu";
            this.FileSettingsMenu.Size = new System.Drawing.Size(116, 22);
            this.FileSettingsMenu.Text = "Settings";
            this.FileSettingsMenu.Click += new System.EventHandler(this.FileSettingsMenu_Click);
            // 
            // FileExitMenu
            // 
            this.FileExitMenu.Name = "FileExitMenu";
            this.FileExitMenu.Size = new System.Drawing.Size(116, 22);
            this.FileExitMenu.Text = "Exit";
            this.FileExitMenu.Click += new System.EventHandler(this.FileExitMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeviceNewMenu,
            this.DeviceEditMenu,
            this.DeviceDeleteMenu,
            this.testToolStripMenuItem,
            this.removeTestToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem2.Text = "Devices";
            // 
            // DeviceNewMenu
            // 
            this.DeviceNewMenu.Name = "DeviceNewMenu";
            this.DeviceNewMenu.Size = new System.Drawing.Size(141, 22);
            this.DeviceNewMenu.Text = "New";
            this.DeviceNewMenu.Click += new System.EventHandler(this.DeviceNewMenu_Click);
            // 
            // DeviceEditMenu
            // 
            this.DeviceEditMenu.Name = "DeviceEditMenu";
            this.DeviceEditMenu.Size = new System.Drawing.Size(141, 22);
            this.DeviceEditMenu.Text = "Edit";
            this.DeviceEditMenu.Click += new System.EventHandler(this.DeviceEditMenu_Click);
            // 
            // DeviceDeleteMenu
            // 
            this.DeviceDeleteMenu.Name = "DeviceDeleteMenu";
            this.DeviceDeleteMenu.Size = new System.Drawing.Size(141, 22);
            this.DeviceDeleteMenu.Text = "Delete";
            this.DeviceDeleteMenu.Click += new System.EventHandler(this.DeviceDeleteMenu_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // removeTestToolStripMenuItem
            // 
            this.removeTestToolStripMenuItem.Name = "removeTestToolStripMenuItem";
            this.removeTestToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.removeTestToolStripMenuItem.Text = "Remove Test";
            this.removeTestToolStripMenuItem.Click += new System.EventHandler(this.removeTestToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripMenuItem,
            this.failuresToolStripMenuItem,
            this.periodToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.overviewToolStripMenuItem.Text = "Overview";
            // 
            // failuresToolStripMenuItem
            // 
            this.failuresToolStripMenuItem.Name = "failuresToolStripMenuItem";
            this.failuresToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.failuresToolStripMenuItem.Text = "Failures";
            // 
            // periodToolStripMenuItem
            // 
            this.periodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hourlyToolStripMenuItem,
            this.dailyOneMonthToolStripMenuItem,
            this.monthlyOneYearToolStripMenuItem,
            this.entireRecordingPeriodToolStripMenuItem});
            this.periodToolStripMenuItem.Name = "periodToolStripMenuItem";
            this.periodToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.periodToolStripMenuItem.Text = "Period";
            // 
            // hourlyToolStripMenuItem
            // 
            this.hourlyToolStripMenuItem.Name = "hourlyToolStripMenuItem";
            this.hourlyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.hourlyToolStripMenuItem.Text = "Day";
            // 
            // dailyOneMonthToolStripMenuItem
            // 
            this.dailyOneMonthToolStripMenuItem.Name = "dailyOneMonthToolStripMenuItem";
            this.dailyOneMonthToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.dailyOneMonthToolStripMenuItem.Text = "Month";
            // 
            // monthlyOneYearToolStripMenuItem
            // 
            this.monthlyOneYearToolStripMenuItem.Name = "monthlyOneYearToolStripMenuItem";
            this.monthlyOneYearToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.monthlyOneYearToolStripMenuItem.Text = "Year";
            // 
            // entireRecordingPeriodToolStripMenuItem
            // 
            this.entireRecordingPeriodToolStripMenuItem.Name = "entireRecordingPeriodToolStripMenuItem";
            this.entireRecordingPeriodToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entireRecordingPeriodToolStripMenuItem.Text = "Eternity";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpHomepageMenu,
            this.HelpAboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // HelpHomepageMenu
            // 
            this.HelpHomepageMenu.Name = "HelpHomepageMenu";
            this.HelpHomepageMenu.Size = new System.Drawing.Size(133, 22);
            this.HelpHomepageMenu.Text = "Homepage";
            this.HelpHomepageMenu.Click += new System.EventHandler(this.HelpHomepageMenu_Click);
            // 
            // HelpAboutMenu
            // 
            this.HelpAboutMenu.Name = "HelpAboutMenu";
            this.HelpAboutMenu.Size = new System.Drawing.Size(133, 22);
            this.HelpAboutMenu.Text = "About";
            this.HelpAboutMenu.Click += new System.EventHandler(this.HelpAboutMenu_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.AllColumns.Add(this.olvColumn5);
            this.objectListView1.AllColumns.Add(this.olvColumn6);
            this.objectListView1.AllColumns.Add(this.olvColumn7);
            this.objectListView1.AllColumns.Add(this.olvColumn8);
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7});
            this.objectListView1.Location = new System.Drawing.Point(12, 27);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(910, 409);
            this.objectListView1.TabIndex = 2;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.ItemActivate += new System.EventHandler(this.objectListView1_ItemActivate);
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "name";
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 100;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "ip";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.Text = "IP";
            this.olvColumn3.Width = 75;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "type";
            this.olvColumn4.Text = "Type";
            this.olvColumn4.Width = 100;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "description";
            this.olvColumn5.FillsFreeSpace = true;
            this.olvColumn5.Groupable = false;
            this.olvColumn5.Text = "Description";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "online";
            this.olvColumn6.Text = "Online";
            this.olvColumn6.Width = 75;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "lastseen";
            this.olvColumn7.Groupable = false;
            this.olvColumn7.Text = "Last Seen";
            this.olvColumn7.Width = 150;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "id";
            this.olvColumn8.DisplayIndex = 6;
            this.olvColumn8.Groupable = false;
            this.olvColumn8.IsVisible = false;
            this.olvColumn8.Tag = "ID";
            this.olvColumn8.Text = "ID";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBRedux";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DeviceNewMenu;
        private System.Windows.Forms.ToolStripMenuItem DeviceEditMenu;
        private System.Windows.Forms.ToolStripMenuItem DeviceDeleteMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpHomepageMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitMenu;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem failuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem hourlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyOneMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyOneYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entireRecordingPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
    }
}


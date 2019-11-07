namespace Polymulator
{
    partial class GameSelectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSelectWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiSaveRomConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MiOpenAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MiOpenAppStyleConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.MiOpenEmulatorConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.MiOpenRomConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.MiOpenJoypadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MiOpenConfigFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MiReload = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PnLsEmulators = new System.Windows.Forms.Panel();
            this.LsEmulators = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PnGames = new System.Windows.Forms.Panel();
            this.GameSelector = new Polymulator.GameSelector();
            this.PnActions = new System.Windows.Forms.Panel();
            this.ActionPanel = new Polymulator.ActionPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PnLsEmulators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.PnGames.SuspendLayout();
            this.PnActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MiExit
            // 
            this.MiExit.Name = "MiExit";
            this.MiExit.Size = new System.Drawing.Size(92, 22);
            this.MiExit.Text = "Exit";
            this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiSaveRomConfig,
            this.toolStripSeparator1,
            this.MiOpenAppSettings,
            this.MiOpenAppStyleConfig,
            this.MiOpenEmulatorConfig,
            this.MiOpenRomConfig,
            this.MiOpenJoypadConfig,
            this.toolStripSeparator2,
            this.MiOpenConfigFolder,
            this.MiReload});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // MiSaveRomConfig
            // 
            this.MiSaveRomConfig.Name = "MiSaveRomConfig";
            this.MiSaveRomConfig.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MiSaveRomConfig.Size = new System.Drawing.Size(241, 22);
            this.MiSaveRomConfig.Text = "Save ROM config file";
            this.MiSaveRomConfig.Click += new System.EventHandler(this.MiSaveRomConfig_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // MiOpenAppSettings
            // 
            this.MiOpenAppSettings.Name = "MiOpenAppSettings";
            this.MiOpenAppSettings.Size = new System.Drawing.Size(241, 22);
            this.MiOpenAppSettings.Text = "Open app settings file";
            this.MiOpenAppSettings.Click += new System.EventHandler(this.MiOpenAppSettings_Click);
            // 
            // MiOpenAppStyleConfig
            // 
            this.MiOpenAppStyleConfig.Name = "MiOpenAppStyleConfig";
            this.MiOpenAppStyleConfig.Size = new System.Drawing.Size(241, 22);
            this.MiOpenAppStyleConfig.Text = "Open app style file";
            this.MiOpenAppStyleConfig.Click += new System.EventHandler(this.MiOpenAppStyleConfig_Click);
            // 
            // MiOpenEmulatorConfig
            // 
            this.MiOpenEmulatorConfig.Name = "MiOpenEmulatorConfig";
            this.MiOpenEmulatorConfig.Size = new System.Drawing.Size(241, 22);
            this.MiOpenEmulatorConfig.Text = "Open emulator config file";
            this.MiOpenEmulatorConfig.Click += new System.EventHandler(this.MiOpenEmulatorConfig_Click);
            // 
            // MiOpenRomConfig
            // 
            this.MiOpenRomConfig.Name = "MiOpenRomConfig";
            this.MiOpenRomConfig.Size = new System.Drawing.Size(241, 22);
            this.MiOpenRomConfig.Text = "Open ROM config file";
            this.MiOpenRomConfig.Click += new System.EventHandler(this.MiOpenRomConfig_Click);
            // 
            // MiOpenJoypadConfig
            // 
            this.MiOpenJoypadConfig.Name = "MiOpenJoypadConfig";
            this.MiOpenJoypadConfig.Size = new System.Drawing.Size(241, 22);
            this.MiOpenJoypadConfig.Text = "Open joypad config dialog";
            this.MiOpenJoypadConfig.Click += new System.EventHandler(this.MiOpenJoypadConfig_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // MiOpenConfigFolder
            // 
            this.MiOpenConfigFolder.Name = "MiOpenConfigFolder";
            this.MiOpenConfigFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MiOpenConfigFolder.Size = new System.Drawing.Size(241, 22);
            this.MiOpenConfigFolder.Text = "Open config files folder";
            this.MiOpenConfigFolder.Click += new System.EventHandler(this.MiOpenConfigFolder_Click);
            // 
            // MiReload
            // 
            this.MiReload.Name = "MiReload";
            this.MiReload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.MiReload.Size = new System.Drawing.Size(241, 22);
            this.MiReload.Text = "Reload";
            this.MiReload.Click += new System.EventHandler(this.MiReload_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MiAbout
            // 
            this.MiAbout.Name = "MiAbout";
            this.MiAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MiAbout.Size = new System.Drawing.Size(135, 22);
            this.MiAbout.Text = "About...";
            this.MiAbout.Click += new System.EventHandler(this.MiAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1342, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PnLsEmulators);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1342, 639);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // PnLsEmulators
            // 
            this.PnLsEmulators.BackColor = System.Drawing.SystemColors.Window;
            this.PnLsEmulators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnLsEmulators.Controls.Add(this.LsEmulators);
            this.PnLsEmulators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnLsEmulators.Location = new System.Drawing.Point(0, 0);
            this.PnLsEmulators.Name = "PnLsEmulators";
            this.PnLsEmulators.Padding = new System.Windows.Forms.Padding(5);
            this.PnLsEmulators.Size = new System.Drawing.Size(197, 639);
            this.PnLsEmulators.TabIndex = 0;
            // 
            // LsEmulators
            // 
            this.LsEmulators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsEmulators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsEmulators.FormattingEnabled = true;
            this.LsEmulators.Location = new System.Drawing.Point(5, 5);
            this.LsEmulators.Name = "LsEmulators";
            this.LsEmulators.Size = new System.Drawing.Size(183, 625);
            this.LsEmulators.TabIndex = 1;
            this.LsEmulators.SelectedIndexChanged += new System.EventHandler(this.LsEmulators_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PnGames);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PnActions);
            this.splitContainer2.Size = new System.Drawing.Size(1144, 639);
            this.splitContainer2.SplitterDistance = 830;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // PnGames
            // 
            this.PnGames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnGames.Controls.Add(this.GameSelector);
            this.PnGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnGames.Location = new System.Drawing.Point(0, 0);
            this.PnGames.Margin = new System.Windows.Forms.Padding(0);
            this.PnGames.Name = "PnGames";
            this.PnGames.Size = new System.Drawing.Size(830, 639);
            this.PnGames.TabIndex = 0;
            // 
            // GameSelector
            // 
            this.GameSelector.AutoScroll = true;
            this.GameSelector.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GameSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameSelector.Emulator = null;
            this.GameSelector.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GameSelector.Location = new System.Drawing.Point(0, 0);
            this.GameSelector.Margin = new System.Windows.Forms.Padding(0);
            this.GameSelector.Name = "GameSelector";
            this.GameSelector.Page = 0;
            this.GameSelector.Pages = 0;
            this.GameSelector.SelectedItem = null;
            this.GameSelector.Size = new System.Drawing.Size(826, 635);
            this.GameSelector.TabIndex = 0;
            this.GameSelector.Window = null;
            // 
            // PnActions
            // 
            this.PnActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnActions.Controls.Add(this.ActionPanel);
            this.PnActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnActions.Location = new System.Drawing.Point(0, 0);
            this.PnActions.Margin = new System.Windows.Forms.Padding(0);
            this.PnActions.Name = "PnActions";
            this.PnActions.Size = new System.Drawing.Size(313, 639);
            this.PnActions.TabIndex = 0;
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ActionPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ActionPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.ActionPanel.Size = new System.Drawing.Size(309, 635);
            this.ActionPanel.TabIndex = 0;
            this.ActionPanel.Visible = false;
            this.ActionPanel.Window = null;
            // 
            // GameSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 685);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameSelectWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLYMULATOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameSelectWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PnLsEmulators.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.PnGames.ResumeLayout(false);
            this.PnActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel PnGames;
        private System.Windows.Forms.Panel PnActions;
        private System.Windows.Forms.Panel PnLsEmulators;
        private System.Windows.Forms.ListBox LsEmulators;
        private GameSelector GameSelector;
        public ActionPanel ActionPanel;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiOpenEmulatorConfig;
        private System.Windows.Forms.ToolStripMenuItem MiOpenRomConfig;
        private System.Windows.Forms.ToolStripMenuItem MiOpenAppStyleConfig;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiAbout;
        private System.Windows.Forms.ToolStripMenuItem MiOpenAppSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MiOpenConfigFolder;
        private System.Windows.Forms.ToolStripMenuItem MiSaveRomConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MiReload;
        private System.Windows.Forms.ToolStripMenuItem MiOpenJoypadConfig;
    }
}
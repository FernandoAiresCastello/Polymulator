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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StMachine = new System.Windows.Forms.ToolStripStatusLabel();
            this.StRomsFound = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PnLsEmulators = new System.Windows.Forms.Panel();
            this.LsEmulators = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PnGames = new System.Windows.Forms.Panel();
            this.GameSelector = new Polymulator.GameSelector();
            this.PnActions = new System.Windows.Forms.Panel();
            this.ActionPanel = new Polymulator.ActionPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
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
            this.MiExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.MiExit.Size = new System.Drawing.Size(165, 22);
            this.MiExit.Text = "Exit";
            this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StMachine,
            this.StRomsFound});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StMachine
            // 
            this.StMachine.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StMachine.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.StMachine.Name = "StMachine";
            this.StMachine.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StMachine.Size = new System.Drawing.Size(62, 19);
            this.StMachine.Text = "Machine";
            // 
            // StRomsFound
            // 
            this.StRomsFound.Name = "StRomsFound";
            this.StRomsFound.Size = new System.Drawing.Size(83, 19);
            this.StRomsFound.Text = "0 ROMs found";
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
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(748, 357);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 2;
            // 
            // PnLsEmulators
            // 
            this.PnLsEmulators.BackColor = System.Drawing.SystemColors.Window;
            this.PnLsEmulators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnLsEmulators.Controls.Add(this.LsEmulators);
            this.PnLsEmulators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnLsEmulators.Location = new System.Drawing.Point(5, 5);
            this.PnLsEmulators.Name = "PnLsEmulators";
            this.PnLsEmulators.Padding = new System.Windows.Forms.Padding(5);
            this.PnLsEmulators.Size = new System.Drawing.Size(105, 347);
            this.PnLsEmulators.TabIndex = 0;
            // 
            // LsEmulators
            // 
            this.LsEmulators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsEmulators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsEmulators.FormattingEnabled = true;
            this.LsEmulators.Location = new System.Drawing.Point(5, 5);
            this.LsEmulators.Name = "LsEmulators";
            this.LsEmulators.Size = new System.Drawing.Size(91, 333);
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
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PnActions);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.splitContainer2.Size = new System.Drawing.Size(634, 357);
            this.splitContainer2.SplitterDistance = 460;
            this.splitContainer2.TabIndex = 0;
            // 
            // PnGames
            // 
            this.PnGames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnGames.Controls.Add(this.GameSelector);
            this.PnGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnGames.Location = new System.Drawing.Point(0, 5);
            this.PnGames.Name = "PnGames";
            this.PnGames.Size = new System.Drawing.Size(460, 347);
            this.PnGames.TabIndex = 0;
            // 
            // GameSelector
            // 
            this.GameSelector.AutoScroll = true;
            this.GameSelector.Columns = 2;
            this.GameSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameSelector.Location = new System.Drawing.Point(0, 0);
            this.GameSelector.Name = "GameSelector";
            this.GameSelector.Padding = new System.Windows.Forms.Padding(5);
            this.GameSelector.Size = new System.Drawing.Size(456, 343);
            this.GameSelector.TabIndex = 0;
            this.GameSelector.Window = null;
            // 
            // PnActions
            // 
            this.PnActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnActions.Controls.Add(this.ActionPanel);
            this.PnActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnActions.Location = new System.Drawing.Point(0, 5);
            this.PnActions.Name = "PnActions";
            this.PnActions.Size = new System.Drawing.Size(165, 347);
            this.PnActions.TabIndex = 0;
            // 
            // ActionPanel
            // 
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ActionPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ActionPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.ActionPanel.Size = new System.Drawing.Size(161, 343);
            this.ActionPanel.TabIndex = 0;
            // 
            // GameSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 405);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameSelectWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLYMULATOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel StMachine;
        private System.Windows.Forms.ToolStripStatusLabel StRomsFound;
        public ActionPanel ActionPanel;
    }
}
namespace Polymulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.LeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MachineListPanel = new System.Windows.Forms.Panel();
            this.MachineListBox = new System.Windows.Forms.ListBox();
            this.RightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RomListPanel = new System.Windows.Forms.Panel();
            this.RomListBox = new System.Windows.Forms.ListBox();
            this.NotePanel = new System.Windows.Forms.Panel();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.SearchBoxPanel = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.ScreenshotBox = new System.Windows.Forms.PictureBox();
            this.MainLayoutPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.LeftLayoutPanel.SuspendLayout();
            this.MachineListPanel.SuspendLayout();
            this.RightLayoutPanel.SuspendLayout();
            this.RomListPanel.SuspendLayout();
            this.NotePanel.SuspendLayout();
            this.SearchBoxPanel.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.TopPanel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.SplitContainer, 0, 1);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(912, 554);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.ColumnCount = 3;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.216495F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.54639F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.23711F));
            this.TopPanel.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.TopPanel.Controls.Add(this.TitleLabel, 1, 0);
            this.TopPanel.Controls.Add(this.pictureBox2, 0, 0);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(10, 9);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 1;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.Size = new System.Drawing.Size(892, 60);
            this.TopPanel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnExit);
            this.flowLayoutPanel1.Controls.Add(this.BtnSettings);
            this.flowLayoutPanel1.Controls.Add(this.BtnMaximize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(526, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 54);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::Polymulator.Properties.Resources.cancel;
            this.BtnExit.Location = new System.Drawing.Point(318, 5);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(40, 45);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Image = global::Polymulator.Properties.Resources.cog_edit1;
            this.BtnSettings.Location = new System.Drawing.Point(268, 5);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(40, 45);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Image = global::Polymulator.Properties.Resources.arrow_inout;
            this.BtnMaximize.Location = new System.Drawing.Point(218, 5);
            this.BtnMaximize.Margin = new System.Windows.Forms.Padding(5);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(40, 45);
            this.BtnMaximize.TabIndex = 5;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.TitleLabel.Location = new System.Drawing.Point(74, 10);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(439, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "POLYMULATOR";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Polymulator.Properties.Resources.gamecontroller;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(11, 76);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.LeftLayoutPanel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.RightLayoutPanel);
            this.SplitContainer.Size = new System.Drawing.Size(890, 468);
            this.SplitContainer.SplitterDistance = 154;
            this.SplitContainer.SplitterWidth = 5;
            this.SplitContainer.TabIndex = 1;
            // 
            // LeftLayoutPanel
            // 
            this.LeftLayoutPanel.ColumnCount = 1;
            this.LeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftLayoutPanel.Controls.Add(this.MachineListPanel, 0, 0);
            this.LeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftLayoutPanel.Name = "LeftLayoutPanel";
            this.LeftLayoutPanel.RowCount = 1;
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LeftLayoutPanel.Size = new System.Drawing.Size(154, 468);
            this.LeftLayoutPanel.TabIndex = 0;
            // 
            // MachineListPanel
            // 
            this.MachineListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MachineListPanel.Controls.Add(this.MachineListBox);
            this.MachineListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineListPanel.Location = new System.Drawing.Point(0, 0);
            this.MachineListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MachineListPanel.Name = "MachineListPanel";
            this.MachineListPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MachineListPanel.Size = new System.Drawing.Size(154, 468);
            this.MachineListPanel.TabIndex = 0;
            // 
            // MachineListBox
            // 
            this.MachineListBox.BackColor = System.Drawing.Color.Navy;
            this.MachineListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MachineListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineListBox.ForeColor = System.Drawing.Color.White;
            this.MachineListBox.FormattingEnabled = true;
            this.MachineListBox.ItemHeight = 16;
            this.MachineListBox.Location = new System.Drawing.Point(7, 6);
            this.MachineListBox.Margin = new System.Windows.Forms.Padding(0);
            this.MachineListBox.Name = "MachineListBox";
            this.MachineListBox.Size = new System.Drawing.Size(138, 454);
            this.MachineListBox.TabIndex = 1;
            this.MachineListBox.SelectedIndexChanged += new System.EventHandler(this.MachineListBox_SelectedIndexChanged);
            // 
            // RightLayoutPanel
            // 
            this.RightLayoutPanel.ColumnCount = 2;
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.RightLayoutPanel.Controls.Add(this.RomListPanel, 0, 1);
            this.RightLayoutPanel.Controls.Add(this.NotePanel, 0, 2);
            this.RightLayoutPanel.Controls.Add(this.SearchBoxPanel, 0, 0);
            this.RightLayoutPanel.Controls.Add(this.ImagePanel, 1, 0);
            this.RightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RightLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightLayoutPanel.Name = "RightLayoutPanel";
            this.RightLayoutPanel.RowCount = 3;
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightLayoutPanel.Size = new System.Drawing.Size(731, 468);
            this.RightLayoutPanel.TabIndex = 1;
            // 
            // RomListPanel
            // 
            this.RomListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomListPanel.Controls.Add(this.RomListBox);
            this.RomListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomListPanel.Location = new System.Drawing.Point(0, 30);
            this.RomListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RomListPanel.Name = "RomListPanel";
            this.RomListPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RomListPanel.Size = new System.Drawing.Size(511, 292);
            this.RomListPanel.TabIndex = 0;
            // 
            // RomListBox
            // 
            this.RomListBox.BackColor = System.Drawing.Color.Navy;
            this.RomListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RomListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomListBox.ForeColor = System.Drawing.Color.White;
            this.RomListBox.FormattingEnabled = true;
            this.RomListBox.ItemHeight = 16;
            this.RomListBox.Location = new System.Drawing.Point(7, 6);
            this.RomListBox.Margin = new System.Windows.Forms.Padding(0);
            this.RomListBox.Name = "RomListBox";
            this.RomListBox.Size = new System.Drawing.Size(495, 278);
            this.RomListBox.TabIndex = 2;
            this.RomListBox.SelectedIndexChanged += new System.EventHandler(this.RomListBox_SelectedIndexChanged);
            this.RomListBox.DoubleClick += new System.EventHandler(this.RomListBox_DoubleClick);
            // 
            // NotePanel
            // 
            this.NotePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotePanel.Controls.Add(this.TxtNotes);
            this.NotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotePanel.Location = new System.Drawing.Point(0, 328);
            this.NotePanel.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NotePanel.Size = new System.Drawing.Size(511, 140);
            this.NotePanel.TabIndex = 1;
            // 
            // TxtNotes
            // 
            this.TxtNotes.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNotes.ForeColor = System.Drawing.Color.White;
            this.TxtNotes.Location = new System.Drawing.Point(7, 6);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(495, 126);
            this.TxtNotes.TabIndex = 0;
            // 
            // SearchBoxPanel
            // 
            this.SearchBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxPanel.Controls.Add(this.TxtSearch);
            this.SearchBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchBoxPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.SearchBoxPanel.Name = "SearchBoxPanel";
            this.SearchBoxPanel.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.SearchBoxPanel.Size = new System.Drawing.Size(511, 24);
            this.SearchBoxPanel.TabIndex = 2;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.Navy;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearch.Location = new System.Drawing.Point(7, 2);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(495, 16);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePanel.Controls.Add(this.ScreenshotBox);
            this.ImagePanel.Location = new System.Drawing.Point(516, 0);
            this.ImagePanel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.RightLayoutPanel.SetRowSpan(this.ImagePanel, 3);
            this.ImagePanel.Size = new System.Drawing.Size(215, 468);
            this.ImagePanel.TabIndex = 3;
            // 
            // ScreenshotBox
            // 
            this.ScreenshotBox.Location = new System.Drawing.Point(0, 0);
            this.ScreenshotBox.Name = "ScreenshotBox";
            this.ScreenshotBox.Size = new System.Drawing.Size(100, 84);
            this.ScreenshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ScreenshotBox.TabIndex = 0;
            this.ScreenshotBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(912, 554);
            this.Controls.Add(this.MainLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLYMULATOR";
            this.MainLayoutPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.LeftLayoutPanel.ResumeLayout(false);
            this.MachineListPanel.ResumeLayout(false);
            this.RightLayoutPanel.ResumeLayout(false);
            this.RomListPanel.ResumeLayout(false);
            this.NotePanel.ResumeLayout(false);
            this.NotePanel.PerformLayout();
            this.SearchBoxPanel.ResumeLayout(false);
            this.SearchBoxPanel.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TableLayoutPanel LeftLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;
        private System.Windows.Forms.Panel MachineListPanel;
        private System.Windows.Forms.ListBox MachineListBox;
        private System.Windows.Forms.Panel RomListPanel;
        private System.Windows.Forms.ListBox RomListBox;
        private System.Windows.Forms.Panel NotePanel;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Panel SearchBoxPanel;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox ScreenshotBox;
        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMaximize;
    }
}


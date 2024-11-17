namespace Polymulator
{
    partial class ActionPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbInfo = new System.Windows.Forms.Label();
            this.LbTitle = new System.Windows.Forms.Label();
            this.PnlActionLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.LnkPlay = new System.Windows.Forms.LinkLabel();
            this.LnkAddFavorite = new System.Windows.Forms.LinkLabel();
            this.LnkSetCoverArt = new System.Windows.Forms.LinkLabel();
            this.LnkSetScreenshot = new System.Windows.Forms.LinkLabel();
            this.LnkRemoveCoverArt = new System.Windows.Forms.LinkLabel();
            this.LnkRemoveScreenshot = new System.Windows.Forms.LinkLabel();
            this.LnkOpenFileLocation = new System.Windows.Forms.LinkLabel();
            this.LnkForgetLastPlayed = new System.Windows.Forms.LinkLabel();
            this.PnNotes = new System.Windows.Forms.Panel();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.PbScreenshot = new System.Windows.Forms.PictureBox();
            this.PbFavorite = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlActionLinks.SuspendLayout();
            this.PnNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.LbInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbScreenshot, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PnlActionLinks, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PnNotes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PbFavorite, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LbInfo
            // 
            this.LbInfo.AutoSize = true;
            this.LbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbInfo.Location = new System.Drawing.Point(3, 24);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(187, 13);
            this.LbInfo.TabIndex = 3;
            this.LbInfo.Text = "Information";
            this.LbInfo.UseMnemonic = false;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitle.Location = new System.Drawing.Point(3, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(187, 24);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Game Title";
            this.LbTitle.UseMnemonic = false;
            // 
            // PnlActionLinks
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PnlActionLinks, 2);
            this.PnlActionLinks.Controls.Add(this.LnkPlay);
            this.PnlActionLinks.Controls.Add(this.LnkAddFavorite);
            this.PnlActionLinks.Controls.Add(this.LnkSetCoverArt);
            this.PnlActionLinks.Controls.Add(this.LnkSetScreenshot);
            this.PnlActionLinks.Controls.Add(this.LnkRemoveCoverArt);
            this.PnlActionLinks.Controls.Add(this.LnkRemoveScreenshot);
            this.PnlActionLinks.Controls.Add(this.LnkOpenFileLocation);
            this.PnlActionLinks.Controls.Add(this.LnkForgetLastPlayed);
            this.PnlActionLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlActionLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PnlActionLinks.Location = new System.Drawing.Point(3, 190);
            this.PnlActionLinks.Name = "PnlActionLinks";
            this.PnlActionLinks.Size = new System.Drawing.Size(219, 100);
            this.PnlActionLinks.TabIndex = 2;
            // 
            // LnkPlay
            // 
            this.LnkPlay.AutoSize = true;
            this.LnkPlay.Location = new System.Drawing.Point(3, 0);
            this.LnkPlay.Name = "LnkPlay";
            this.LnkPlay.Size = new System.Drawing.Size(27, 13);
            this.LnkPlay.TabIndex = 0;
            this.LnkPlay.TabStop = true;
            this.LnkPlay.Text = "Play";
            this.LnkPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPlay_LinkClicked);
            // 
            // LnkAddFavorite
            // 
            this.LnkAddFavorite.AutoSize = true;
            this.LnkAddFavorite.Location = new System.Drawing.Point(3, 13);
            this.LnkAddFavorite.Name = "LnkAddFavorite";
            this.LnkAddFavorite.Size = new System.Drawing.Size(45, 13);
            this.LnkAddFavorite.TabIndex = 1;
            this.LnkAddFavorite.TabStop = true;
            this.LnkAddFavorite.Text = "Favorite";
            this.LnkAddFavorite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAddFavorite_LinkClicked);
            // 
            // LnkSetCoverArt
            // 
            this.LnkSetCoverArt.AutoSize = true;
            this.LnkSetCoverArt.Location = new System.Drawing.Point(3, 26);
            this.LnkSetCoverArt.Name = "LnkSetCoverArt";
            this.LnkSetCoverArt.Size = new System.Drawing.Size(70, 13);
            this.LnkSetCoverArt.TabIndex = 2;
            this.LnkSetCoverArt.TabStop = true;
            this.LnkSetCoverArt.Text = "Set Cover Art";
            this.LnkSetCoverArt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSetCoverArt_LinkClicked);
            // 
            // LnkSetScreenshot
            // 
            this.LnkSetScreenshot.AutoSize = true;
            this.LnkSetScreenshot.Location = new System.Drawing.Point(3, 39);
            this.LnkSetScreenshot.Name = "LnkSetScreenshot";
            this.LnkSetScreenshot.Size = new System.Drawing.Size(80, 13);
            this.LnkSetScreenshot.TabIndex = 4;
            this.LnkSetScreenshot.TabStop = true;
            this.LnkSetScreenshot.Text = "Set Screenshot";
            this.LnkSetScreenshot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSetScreenshot_LinkClicked);
            // 
            // LnkRemoveCoverArt
            // 
            this.LnkRemoveCoverArt.AutoSize = true;
            this.LnkRemoveCoverArt.Location = new System.Drawing.Point(3, 52);
            this.LnkRemoveCoverArt.Name = "LnkRemoveCoverArt";
            this.LnkRemoveCoverArt.Size = new System.Drawing.Size(94, 13);
            this.LnkRemoveCoverArt.TabIndex = 5;
            this.LnkRemoveCoverArt.TabStop = true;
            this.LnkRemoveCoverArt.Text = "Remove Cover Art";
            this.LnkRemoveCoverArt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRemoveCoverArt_LinkClicked);
            // 
            // LnkRemoveScreenshot
            // 
            this.LnkRemoveScreenshot.AutoSize = true;
            this.LnkRemoveScreenshot.Location = new System.Drawing.Point(3, 65);
            this.LnkRemoveScreenshot.Name = "LnkRemoveScreenshot";
            this.LnkRemoveScreenshot.Size = new System.Drawing.Size(104, 13);
            this.LnkRemoveScreenshot.TabIndex = 6;
            this.LnkRemoveScreenshot.TabStop = true;
            this.LnkRemoveScreenshot.Text = "Remove Screenshot";
            this.LnkRemoveScreenshot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRemoveScreenshot_LinkClicked);
            // 
            // LnkOpenFileLocation
            // 
            this.LnkOpenFileLocation.AutoSize = true;
            this.LnkOpenFileLocation.Location = new System.Drawing.Point(3, 78);
            this.LnkOpenFileLocation.Name = "LnkOpenFileLocation";
            this.LnkOpenFileLocation.Size = new System.Drawing.Size(96, 13);
            this.LnkOpenFileLocation.TabIndex = 3;
            this.LnkOpenFileLocation.TabStop = true;
            this.LnkOpenFileLocation.Text = "Open File Location";
            this.LnkOpenFileLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkOpenFileLocation_LinkClicked);
            // 
            // LnkForgetLastPlayed
            // 
            this.LnkForgetLastPlayed.AutoSize = true;
            this.LnkForgetLastPlayed.Location = new System.Drawing.Point(113, 0);
            this.LnkForgetLastPlayed.Name = "LnkForgetLastPlayed";
            this.LnkForgetLastPlayed.Size = new System.Drawing.Size(95, 13);
            this.LnkForgetLastPlayed.TabIndex = 7;
            this.LnkForgetLastPlayed.TabStop = true;
            this.LnkForgetLastPlayed.Text = "Forget Last Played";
            this.LnkForgetLastPlayed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgetLastPlayed_LinkClicked);
            // 
            // PnNotes
            // 
            this.PnNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.PnNotes, 2);
            this.PnNotes.Controls.Add(this.TxtNotes);
            this.PnNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNotes.Location = new System.Drawing.Point(3, 296);
            this.PnNotes.Name = "PnNotes";
            this.PnNotes.Padding = new System.Windows.Forms.Padding(5);
            this.PnNotes.Size = new System.Drawing.Size(219, 161);
            this.PnNotes.TabIndex = 4;
            // 
            // TxtNotes
            // 
            this.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNotes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotes.Location = new System.Drawing.Point(5, 5);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(207, 149);
            this.TxtNotes.TabIndex = 5;
            this.TxtNotes.TextChanged += new System.EventHandler(this.TxtNotes_TextChanged);
            // 
            // PbScreenshot
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PbScreenshot, 2);
            this.PbScreenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbScreenshot.Image = global::Polymulator.Properties.Resources.no_screenshot;
            this.PbScreenshot.Location = new System.Drawing.Point(3, 47);
            this.PbScreenshot.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.PbScreenshot.Name = "PbScreenshot";
            this.PbScreenshot.Size = new System.Drawing.Size(219, 130);
            this.PbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbScreenshot.TabIndex = 1;
            this.PbScreenshot.TabStop = false;
            // 
            // PbFavorite
            // 
            this.PbFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFavorite.Location = new System.Drawing.Point(193, 0);
            this.PbFavorite.Margin = new System.Windows.Forms.Padding(0);
            this.PbFavorite.MinimumSize = new System.Drawing.Size(24, 24);
            this.PbFavorite.Name = "PbFavorite";
            this.PbFavorite.Size = new System.Drawing.Size(32, 24);
            this.PbFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbFavorite.TabIndex = 5;
            this.PbFavorite.TabStop = false;
            // 
            // ActionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ActionPanel";
            this.Size = new System.Drawing.Size(225, 460);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PnlActionLinks.ResumeLayout(false);
            this.PnlActionLinks.PerformLayout();
            this.PnNotes.ResumeLayout(false);
            this.PnNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFavorite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.PictureBox PbScreenshot;
        private System.Windows.Forms.FlowLayoutPanel PnlActionLinks;
        private System.Windows.Forms.LinkLabel LnkPlay;
        private System.Windows.Forms.LinkLabel LnkAddFavorite;
        private System.Windows.Forms.LinkLabel LnkSetCoverArt;
        private System.Windows.Forms.LinkLabel LnkOpenFileLocation;
        private System.Windows.Forms.LinkLabel LnkSetScreenshot;
        private System.Windows.Forms.Label LbInfo;
        private System.Windows.Forms.Panel PnNotes;
        public System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.LinkLabel LnkRemoveCoverArt;
        private System.Windows.Forms.LinkLabel LnkRemoveScreenshot;
        private System.Windows.Forms.LinkLabel LnkForgetLastPlayed;
        private System.Windows.Forms.PictureBox PbFavorite;
    }
}

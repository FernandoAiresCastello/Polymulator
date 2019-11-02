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
            this.LbFileSize = new System.Windows.Forms.Label();
            this.LbTitle = new System.Windows.Forms.Label();
            this.PbScreenshot = new System.Windows.Forms.PictureBox();
            this.PnlActionLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.LnkPlay = new System.Windows.Forms.LinkLabel();
            this.LnkAddFavorite = new System.Windows.Forms.LinkLabel();
            this.LnkSetCoverArt = new System.Windows.Forms.LinkLabel();
            this.LnkSetScreenshot = new System.Windows.Forms.LinkLabel();
            this.LnkOpenFileLocation = new System.Windows.Forms.LinkLabel();
            this.PnNotes = new System.Windows.Forms.Panel();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbScreenshot)).BeginInit();
            this.PnlActionLinks.SuspendLayout();
            this.PnNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LbFileSize, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbScreenshot, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PnlActionLinks, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PnNotes, 0, 4);
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
            // LbFileSize
            // 
            this.LbFileSize.AutoSize = true;
            this.LbFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbFileSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbFileSize.Location = new System.Drawing.Point(3, 13);
            this.LbFileSize.Name = "LbFileSize";
            this.LbFileSize.Size = new System.Drawing.Size(219, 13);
            this.LbFileSize.TabIndex = 3;
            this.LbFileSize.Text = "File size";
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitle.Location = new System.Drawing.Point(3, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(219, 13);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Game Title";
            // 
            // PbScreenshot
            // 
            this.PbScreenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbScreenshot.Image = global::Polymulator.Properties.Resources.no_screenshot;
            this.PbScreenshot.Location = new System.Drawing.Point(3, 36);
            this.PbScreenshot.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.PbScreenshot.Name = "PbScreenshot";
            this.PbScreenshot.Size = new System.Drawing.Size(219, 130);
            this.PbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbScreenshot.TabIndex = 1;
            this.PbScreenshot.TabStop = false;
            // 
            // PnlActionLinks
            // 
            this.PnlActionLinks.Controls.Add(this.LnkPlay);
            this.PnlActionLinks.Controls.Add(this.LnkAddFavorite);
            this.PnlActionLinks.Controls.Add(this.LnkSetCoverArt);
            this.PnlActionLinks.Controls.Add(this.LnkSetScreenshot);
            this.PnlActionLinks.Controls.Add(this.LnkOpenFileLocation);
            this.PnlActionLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlActionLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PnlActionLinks.Location = new System.Drawing.Point(3, 179);
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
            this.LnkAddFavorite.Size = new System.Drawing.Size(84, 13);
            this.LnkAddFavorite.TabIndex = 1;
            this.LnkAddFavorite.TabStop = true;
            this.LnkAddFavorite.Text = "Add to Favorites";
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
            // LnkOpenFileLocation
            // 
            this.LnkOpenFileLocation.AutoSize = true;
            this.LnkOpenFileLocation.Location = new System.Drawing.Point(3, 52);
            this.LnkOpenFileLocation.Name = "LnkOpenFileLocation";
            this.LnkOpenFileLocation.Size = new System.Drawing.Size(96, 13);
            this.LnkOpenFileLocation.TabIndex = 3;
            this.LnkOpenFileLocation.TabStop = true;
            this.LnkOpenFileLocation.Text = "Open File Location";
            this.LnkOpenFileLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkOpenFileLocation_LinkClicked);
            // 
            // PnNotes
            // 
            this.PnNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnNotes.Controls.Add(this.TxtNotes);
            this.PnNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNotes.Location = new System.Drawing.Point(3, 285);
            this.PnNotes.Name = "PnNotes";
            this.PnNotes.Padding = new System.Windows.Forms.Padding(5);
            this.PnNotes.Size = new System.Drawing.Size(219, 172);
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
            this.TxtNotes.Size = new System.Drawing.Size(207, 160);
            this.TxtNotes.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.PbScreenshot)).EndInit();
            this.PnlActionLinks.ResumeLayout(false);
            this.PnlActionLinks.PerformLayout();
            this.PnNotes.ResumeLayout(false);
            this.PnNotes.PerformLayout();
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
        private System.Windows.Forms.Label LbFileSize;
        private System.Windows.Forms.Panel PnNotes;
        private System.Windows.Forms.TextBox TxtNotes;
    }
}

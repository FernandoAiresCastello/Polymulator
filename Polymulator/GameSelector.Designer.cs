namespace Polymulator
{
    partial class GameSelector
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
            this.TbGames = new System.Windows.Forms.TableLayoutPanel();
            this.TbMain = new System.Windows.Forms.TableLayoutPanel();
            this.PnTbGames = new System.Windows.Forms.Panel();
            this.TopPanelOuter = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LbPage = new System.Windows.Forms.Label();
            this.LbRomsFound = new System.Windows.Forms.Label();
            this.LbMachine = new System.Windows.Forms.Label();
            this.PnPageLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.LnkPrevPage = new System.Windows.Forms.LinkLabel();
            this.LnkNextPage = new System.Windows.Forms.LinkLabel();
            this.ChkOnlyFavorites = new System.Windows.Forms.CheckBox();
            this.TbMain.SuspendLayout();
            this.PnTbGames.SuspendLayout();
            this.TopPanelOuter.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.PnPageLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbGames
            // 
            this.TbGames.AutoSize = true;
            this.TbGames.ColumnCount = 2;
            this.TbGames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13405F));
            this.TbGames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86595F));
            this.TbGames.Location = new System.Drawing.Point(0, 0);
            this.TbGames.Margin = new System.Windows.Forms.Padding(0);
            this.TbGames.Name = "TbGames";
            this.TbGames.Padding = new System.Windows.Forms.Padding(10);
            this.TbGames.RowCount = 2;
            this.TbGames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbGames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbGames.Size = new System.Drawing.Size(393, 386);
            this.TbGames.TabIndex = 0;
            // 
            // TbMain
            // 
            this.TbMain.ColumnCount = 1;
            this.TbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbMain.Controls.Add(this.PnTbGames, 0, 1);
            this.TbMain.Controls.Add(this.TopPanelOuter, 0, 0);
            this.TbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMain.Location = new System.Drawing.Point(0, 0);
            this.TbMain.Name = "TbMain";
            this.TbMain.RowCount = 2;
            this.TbMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TbMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TbMain.Size = new System.Drawing.Size(395, 415);
            this.TbMain.TabIndex = 1;
            // 
            // PnTbGames
            // 
            this.PnTbGames.AutoScroll = true;
            this.PnTbGames.Controls.Add(this.TbGames);
            this.PnTbGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnTbGames.Location = new System.Drawing.Point(0, 54);
            this.PnTbGames.Margin = new System.Windows.Forms.Padding(0);
            this.PnTbGames.Name = "PnTbGames";
            this.PnTbGames.Size = new System.Drawing.Size(395, 365);
            this.PnTbGames.TabIndex = 0;
            // 
            // TopPanelOuter
            // 
            this.TopPanelOuter.AutoSize = true;
            this.TopPanelOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanelOuter.Controls.Add(this.TopPanel);
            this.TopPanelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanelOuter.Location = new System.Drawing.Point(0, 0);
            this.TopPanelOuter.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanelOuter.Name = "TopPanelOuter";
            this.TopPanelOuter.Padding = new System.Windows.Forms.Padding(5, 8, 5, 10);
            this.TopPanelOuter.Size = new System.Drawing.Size(395, 54);
            this.TopPanelOuter.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.AutoSize = true;
            this.TopPanel.ColumnCount = 3;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanel.Controls.Add(this.LbPage, 1, 0);
            this.TopPanel.Controls.Add(this.LbRomsFound, 0, 1);
            this.TopPanel.Controls.Add(this.LbMachine, 0, 0);
            this.TopPanel.Controls.Add(this.PnPageLinks, 1, 1);
            this.TopPanel.Controls.Add(this.ChkOnlyFavorites, 2, 0);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(5, 8);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 2;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopPanel.Size = new System.Drawing.Size(383, 34);
            this.TopPanel.TabIndex = 2;
            // 
            // LbPage
            // 
            this.LbPage.AutoSize = true;
            this.LbPage.Location = new System.Drawing.Point(130, 0);
            this.LbPage.Name = "LbPage";
            this.LbPage.Size = new System.Drawing.Size(62, 13);
            this.LbPage.TabIndex = 2;
            this.LbPage.Text = "Page 0 of 0";
            // 
            // LbRomsFound
            // 
            this.LbRomsFound.AutoSize = true;
            this.LbRomsFound.Location = new System.Drawing.Point(3, 17);
            this.LbRomsFound.Name = "LbRomsFound";
            this.LbRomsFound.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LbRomsFound.Size = new System.Drawing.Size(64, 15);
            this.LbRomsFound.TabIndex = 1;
            this.LbRomsFound.Text = "Roms found";
            // 
            // LbMachine
            // 
            this.LbMachine.AutoSize = true;
            this.LbMachine.Location = new System.Drawing.Point(3, 0);
            this.LbMachine.Name = "LbMachine";
            this.LbMachine.Size = new System.Drawing.Size(48, 13);
            this.LbMachine.TabIndex = 0;
            this.LbMachine.Text = "Machine";
            // 
            // PnPageLinks
            // 
            this.PnPageLinks.AutoSize = true;
            this.PnPageLinks.Controls.Add(this.LnkPrevPage);
            this.PnPageLinks.Controls.Add(this.LnkNextPage);
            this.PnPageLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPageLinks.Location = new System.Drawing.Point(127, 17);
            this.PnPageLinks.Margin = new System.Windows.Forms.Padding(0);
            this.PnPageLinks.Name = "PnPageLinks";
            this.PnPageLinks.Size = new System.Drawing.Size(127, 17);
            this.PnPageLinks.TabIndex = 3;
            this.PnPageLinks.WrapContents = false;
            // 
            // LnkPrevPage
            // 
            this.LnkPrevPage.AutoSize = true;
            this.LnkPrevPage.Location = new System.Drawing.Point(3, 0);
            this.LnkPrevPage.Name = "LnkPrevPage";
            this.LnkPrevPage.Size = new System.Drawing.Size(29, 13);
            this.LnkPrevPage.TabIndex = 0;
            this.LnkPrevPage.TabStop = true;
            this.LnkPrevPage.Text = "Prev";
            this.LnkPrevPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPrevPage_LinkClicked);
            // 
            // LnkNextPage
            // 
            this.LnkNextPage.AutoSize = true;
            this.LnkNextPage.Location = new System.Drawing.Point(38, 0);
            this.LnkNextPage.Name = "LnkNextPage";
            this.LnkNextPage.Size = new System.Drawing.Size(29, 13);
            this.LnkNextPage.TabIndex = 1;
            this.LnkNextPage.TabStop = true;
            this.LnkNextPage.Text = "Next";
            this.LnkNextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNextPage_LinkClicked);
            // 
            // ChkOnlyFavorites
            // 
            this.ChkOnlyFavorites.AutoSize = true;
            this.ChkOnlyFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkOnlyFavorites.Location = new System.Drawing.Point(254, 0);
            this.ChkOnlyFavorites.Margin = new System.Windows.Forms.Padding(0);
            this.ChkOnlyFavorites.Name = "ChkOnlyFavorites";
            this.ChkOnlyFavorites.Size = new System.Drawing.Size(129, 17);
            this.ChkOnlyFavorites.TabIndex = 4;
            this.ChkOnlyFavorites.Text = "Display only favorites";
            this.ChkOnlyFavorites.UseVisualStyleBackColor = true;
            this.ChkOnlyFavorites.CheckedChanged += new System.EventHandler(this.ChkOnlyFavorites_CheckedChanged);
            // 
            // GameSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameSelector";
            this.Size = new System.Drawing.Size(395, 415);
            this.TbMain.ResumeLayout(false);
            this.TbMain.PerformLayout();
            this.PnTbGames.ResumeLayout(false);
            this.PnTbGames.PerformLayout();
            this.TopPanelOuter.ResumeLayout(false);
            this.TopPanelOuter.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.PnPageLinks.ResumeLayout(false);
            this.PnPageLinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TbGames;
        private System.Windows.Forms.TableLayoutPanel TbMain;
        private System.Windows.Forms.Panel PnTbGames;
        private System.Windows.Forms.Panel TopPanelOuter;
        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.Label LbRomsFound;
        private System.Windows.Forms.Label LbMachine;
        private System.Windows.Forms.Label LbPage;
        private System.Windows.Forms.FlowLayoutPanel PnPageLinks;
        private System.Windows.Forms.LinkLabel LnkPrevPage;
        private System.Windows.Forms.LinkLabel LnkNextPage;
        private System.Windows.Forms.CheckBox ChkOnlyFavorites;
    }
}

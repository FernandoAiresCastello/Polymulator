namespace Polymulator
{
    partial class GameSelectorItem
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
            this.PbCoverArt = new System.Windows.Forms.PictureBox();
            this.LbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PbCoverArt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbTitle, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Item_DoubleClick);
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Item_Click);
            // 
            // PbCoverArt
            // 
            this.PbCoverArt.Location = new System.Drawing.Point(5, 5);
            this.PbCoverArt.Margin = new System.Windows.Forms.Padding(5);
            this.PbCoverArt.Name = "PbCoverArt";
            this.PbCoverArt.Size = new System.Drawing.Size(194, 200);
            this.PbCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCoverArt.TabIndex = 0;
            this.PbCoverArt.TabStop = false;
            this.PbCoverArt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Item_DoubleClick);
            this.PbCoverArt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Item_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitle.Location = new System.Drawing.Point(0, 210);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LbTitle.MaximumSize = new System.Drawing.Size(200, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.LbTitle.Size = new System.Drawing.Size(200, 53);
            this.LbTitle.TabIndex = 3;
            this.LbTitle.Text = "Game Title";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbTitle.UseMnemonic = false;
            this.LbTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Item_DoubleClick);
            this.LbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Item_Click);
            // 
            // GameSelectorItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameSelectorItem";
            this.Size = new System.Drawing.Size(204, 263);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PbCoverArt;
        private System.Windows.Forms.Label LbTitle;
    }
}

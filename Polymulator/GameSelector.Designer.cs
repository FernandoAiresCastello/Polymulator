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
            this.SuspendLayout();
            // 
            // TbGames
            // 
            this.TbGames.AutoSize = true;
            this.TbGames.ColumnCount = 2;
            this.TbGames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbGames.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbGames.Location = new System.Drawing.Point(5, 5);
            this.TbGames.Name = "TbGames";
            this.TbGames.RowCount = 2;
            this.TbGames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbGames.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbGames.Size = new System.Drawing.Size(294, 296);
            this.TbGames.TabIndex = 0;
            // 
            // GameSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.TbGames);
            this.DoubleBuffered = true;
            this.Name = "GameSelector";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(269, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TbGames;
    }
}

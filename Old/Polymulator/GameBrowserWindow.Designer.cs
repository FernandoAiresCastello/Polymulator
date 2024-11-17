namespace Polymulator
{
    partial class GameBrowserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBrowserWindow));
            this.RootPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtRom = new System.Windows.Forms.TextBox();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.LstRoms = new System.Windows.Forms.ListBox();
            this.RootPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootPanel
            // 
            this.RootPanel.Controls.Add(this.tableLayoutPanel1);
            this.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootPanel.Location = new System.Drawing.Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.RootPanel.Size = new System.Drawing.Size(784, 562);
            this.RootPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TxtInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtRom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LstRoms, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtRom
            // 
            this.TxtRom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRom.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRom.Location = new System.Drawing.Point(5, 5);
            this.TxtRom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.TxtRom.Name = "TxtRom";
            this.TxtRom.Size = new System.Drawing.Size(754, 22);
            this.TxtRom.TabIndex = 0;
            // 
            // TxtInfo
            // 
            this.TxtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo.Location = new System.Drawing.Point(3, 462);
            this.TxtInfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.ReadOnly = true;
            this.TxtInfo.Size = new System.Drawing.Size(758, 87);
            this.TxtInfo.TabIndex = 1;
            this.TxtInfo.WordWrap = false;
            // 
            // LstRoms
            // 
            this.LstRoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstRoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstRoms.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstRoms.FormattingEnabled = true;
            this.LstRoms.ItemHeight = 23;
            this.LstRoms.Location = new System.Drawing.Point(3, 45);
            this.LstRoms.Name = "LstRoms";
            this.LstRoms.ScrollAlwaysVisible = true;
            this.LstRoms.Size = new System.Drawing.Size(758, 404);
            this.LstRoms.Sorted = true;
            this.LstRoms.TabIndex = 2;
            // 
            // GameBrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.RootPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBrowserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polymulator";
            this.RootPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RootPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.TextBox TxtRom;
        private System.Windows.Forms.ListBox LstRoms;
    }
}
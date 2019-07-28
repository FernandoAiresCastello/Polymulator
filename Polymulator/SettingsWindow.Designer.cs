namespace Polymulator
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxtConfig = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.BtnFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSave,
            this.BtnCancel,
            this.BtnFolder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(548, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TxtConfig
            // 
            this.TxtConfig.AcceptsReturn = true;
            this.TxtConfig.AcceptsTab = true;
            this.TxtConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtConfig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfig.Location = new System.Drawing.Point(0, 25);
            this.TxtConfig.Margin = new System.Windows.Forms.Padding(0);
            this.TxtConfig.Multiline = true;
            this.TxtConfig.Name = "TxtConfig";
            this.TxtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtConfig.Size = new System.Drawing.Size(548, 325);
            this.TxtConfig.TabIndex = 1;
            this.TxtConfig.Text = "Testing...";
            this.TxtConfig.WordWrap = false;
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::Polymulator.Properties.Resources.tick_octagon;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "toolStripButton1";
            this.BtnSave.ToolTipText = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCancel.Image = global::Polymulator.Properties.Resources.cancel1;
            this.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(23, 22);
            this.BtnCancel.Text = "toolStripButton2";
            this.BtnCancel.ToolTipText = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnFolder
            // 
            this.BtnFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFolder.Image = global::Polymulator.Properties.Resources.folder_explorer;
            this.BtnFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFolder.Name = "BtnFolder";
            this.BtnFolder.Size = new System.Drawing.Size(23, 22);
            this.BtnFolder.Text = "toolStripButton1";
            this.BtnFolder.ToolTipText = "Open file location";
            this.BtnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 350);
            this.ControlBox = false;
            this.Controls.Add(this.TxtConfig);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.TextBox TxtConfig;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripButton BtnFolder;
    }
}
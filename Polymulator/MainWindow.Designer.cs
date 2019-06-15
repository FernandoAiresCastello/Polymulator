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
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainLayoutPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
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
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(785, 554);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(11, 10);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(763, 39);
            this.TopPanel.TabIndex = 2;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(11, 57);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.LeftLayoutPanel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.RightLayoutPanel);
            this.SplitContainer.Size = new System.Drawing.Size(763, 487);
            this.SplitContainer.SplitterDistance = 177;
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
            this.LeftLayoutPanel.Size = new System.Drawing.Size(177, 487);
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
            this.MachineListPanel.Size = new System.Drawing.Size(177, 487);
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
            this.MachineListBox.Size = new System.Drawing.Size(161, 473);
            this.MachineListBox.TabIndex = 1;
            this.MachineListBox.SelectedIndexChanged += new System.EventHandler(this.MachineListBox_SelectedIndexChanged);
            // 
            // RightLayoutPanel
            // 
            this.RightLayoutPanel.ColumnCount = 1;
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.Controls.Add(this.RomListPanel, 0, 1);
            this.RightLayoutPanel.Controls.Add(this.NotePanel, 0, 2);
            this.RightLayoutPanel.Controls.Add(this.SearchBoxPanel, 0, 0);
            this.RightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RightLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightLayoutPanel.Name = "RightLayoutPanel";
            this.RightLayoutPanel.RowCount = 3;
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightLayoutPanel.Size = new System.Drawing.Size(581, 487);
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
            this.RomListPanel.Size = new System.Drawing.Size(581, 311);
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
            this.RomListBox.Size = new System.Drawing.Size(565, 297);
            this.RomListBox.TabIndex = 2;
            this.RomListBox.SelectedIndexChanged += new System.EventHandler(this.RomListBox_SelectedIndexChanged);
            this.RomListBox.DoubleClick += new System.EventHandler(this.RomListBox_DoubleClick);
            // 
            // NotePanel
            // 
            this.NotePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotePanel.Controls.Add(this.TxtNotes);
            this.NotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotePanel.Location = new System.Drawing.Point(0, 347);
            this.NotePanel.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NotePanel.Size = new System.Drawing.Size(581, 140);
            this.NotePanel.TabIndex = 1;
            // 
            // TxtNotes
            // 
            this.TxtNotes.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNotes.ForeColor = System.Drawing.Color.White;
            this.TxtNotes.Location = new System.Drawing.Point(7, 6);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ReadOnly = true;
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(565, 126);
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
            this.SearchBoxPanel.Size = new System.Drawing.Size(581, 24);
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
            this.TxtSearch.Size = new System.Drawing.Size(565, 16);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "POLYMULATOR";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(785, 554);
            this.Controls.Add(this.MainLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLYMULATOR";
            this.MainLayoutPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TableLayoutPanel LeftLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Panel MachineListPanel;
        private System.Windows.Forms.ListBox MachineListBox;
        private System.Windows.Forms.Panel RomListPanel;
        private System.Windows.Forms.ListBox RomListBox;
        private System.Windows.Forms.Panel NotePanel;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Panel SearchBoxPanel;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
    }
}


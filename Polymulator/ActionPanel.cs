using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Polymulator
{
    public partial class ActionPanel : UserControl
    {
        public GameSelectWindow Window { set; get; }

        private GameSelectorItem Item;
        private readonly Image NoScreenshot = Properties.Resources.no_screenshot;

        public ActionPanel()
        {
            InitializeComponent();
            Font = ApplicationStyle.MainFont;
            ForeColor = ApplicationStyle.MainForeColor;
            LbFileSize.ForeColor = ApplicationStyle.SecondaryForeColor;
            PnNotes.BackColor = ApplicationStyle.MainBackColor;
            TxtNotes.BackColor = ApplicationStyle.MainBackColor;
            TxtNotes.ForeColor = ApplicationStyle.MainForeColor;

            foreach (Control ctl in PnlActionLinks.Controls)
            {
                if (ctl is LinkLabel)
                {
                    LinkLabel link = ctl as LinkLabel;
                    link.LinkColor = ApplicationStyle.LinkForeColor;
                    link.ActiveLinkColor = ApplicationStyle.ActiveLinkForeColor;
                }
            }
        }

        public void UpdatePanel(GameSelectorItem item)
        {
            Item = item;
            LbTitle.Text = item.Rom.File;
            LbFileSize.Text = "File size: " + item.Rom.Size;
            PbScreenshot.Image = !string.IsNullOrWhiteSpace(item.Rom.ScreenshotFile) ? Image.FromFile(item.Rom.ScreenshotFile) : NoScreenshot;
        }

        private void LnkPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // todo
        }

        private void LnkAddFavorite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // todo
        }

        private void LnkSetCoverArt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the cover art for this game";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Item.Rom.CoverArtFile = dialog.FileName;
                Window.RedrawActionPanel(Item);
            }
        }

        private void LnkSetScreenshot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the screenshot for this game";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Item.Rom.ScreenshotFile = dialog.FileName;
                Window.RedrawGameSelectorItem(Item);
            }
        }

        private void LnkOpenFileLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new FileInfo(Item.Rom.Path).DirectoryName);
        }
    }
}

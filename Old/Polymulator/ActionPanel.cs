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

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                TxtNotes.BackColor = value;
                PnNotes.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                TxtNotes.ForeColor = value;
                PnNotes.ForeColor = value;
            }
        }

        public ActionPanel()
        {
            InitializeComponent();
            UpdatePanel(null);
        }

        public void UpdatePanel(GameSelectorItem item)
        {
            if (item == null)
                Hide();
            else
                Show();

            Item = item;
            UpdatePanel();
        }

        public void UpdatePanel()
        {
            if (Item != null)
            {
                GameRom rom = Item.Rom;

                SetInfo
                (
                    $"Filename: {rom.File}", 
                    $"Size: {rom.SizeDescription}",
                    $"Last played: {rom.LastPlayed}"
                );

                LbTitle.Text = rom.FriendlyTitle;
                PbFavorite.Image = rom.Favorite ? Properties.Resources.star : null;
                LnkAddFavorite.Text = Item.Rom.Favorite ? "Remove from favorites" : "Add to favorites";
                TxtNotes.Text = rom.Notes;
                PbScreenshot.Image = !string.IsNullOrWhiteSpace(rom.ScreenshotFile) ? 
                    Image.FromFile(rom.ScreenshotFile) : NoScreenshot;
            }

            UpdateStyle();
        }

        private void SetInfo(params string[] infos)
        {
            StringBuilder text = new StringBuilder();

            foreach (string info in infos)
                text.Append(info + "\n");

            LbInfo.Text = text.ToString();
        }

        public void UpdateStyle()
        {
            Font = ApplicationStyle.MainFont;
            ForeColor = ApplicationStyle.MainForeColor;
            LbInfo.ForeColor = ApplicationStyle.SecondaryForeColor;
            PnNotes.BackColor = ApplicationStyle.MainBackColor;
            TxtNotes.BackColor = ApplicationStyle.MainBackColor;
            TxtNotes.ForeColor = ApplicationStyle.MainForeColor;
            TxtNotes.Font = new Font(TxtNotes.Font.FontFamily, ApplicationStyle.NotesFontSize, TxtNotes.Font.Style);

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

        private void TxtNotes_TextChanged(object sender, EventArgs e)
        {
            Item.Rom.Notes = TxtNotes.Text;
        }

        private void LnkPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Window.LaunchGame(Item.Rom);
        }

        private void LnkOpenFileLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new FileInfo(Item.Rom.Path).DirectoryName);
        }

        private void LnkAddFavorite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Item.Rom.Favorite = !Item.Rom.Favorite;
            UpdatePanel();
            if (Window.Selector.DisplayOnlyFavorites)
                Window.UpdateGameSelector();
        }

        private void LnkSetCoverArt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the cover art for this game";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Item.Rom.CoverArtFile = dialog.FileName;
                Window.RedrawGameSelectorItem(Item);
            }
        }

        private void LnkSetScreenshot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the screenshot for this game";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Item.Rom.ScreenshotFile = dialog.FileName;
                UpdatePanel();
            }
        }

        private void LnkRemoveCoverArt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, 
                "This will remove the cover art. Are you sure?", "Please confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Item.Rom.CoverArtFile = null;
                Window.RedrawGameSelectorItem(Item);
            }
        }

        private void LnkRemoveScreenshot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(this,
                "This will remove the screenshot. Are you sure?", "Please confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Item.Rom.ScreenshotFile = null;
                UpdatePanel();
            }
        }

        private void LnkForgetLastPlayed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, 
                "This will forget the last time played. Are you sure?", "Please confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Item.Rom.LastPlayedDateTime = null;
                UpdatePanel();
                Window.UpdateGameSelector();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymulator
{
    public partial class GameSelector : UserControl
    {
        public GameSelectWindow Window { set; get; }
        public Emulator Emulator { set; get; }
        public int Page { set; get; }
        public int Pages { set; get; }
        public GameSelectorItem SelectedItem { set; get; }
        public bool DisplayOnlyFavorites => ChkOnlyFavorites.Checked;

        private List<GameSelectorItem> Items = new List<GameSelectorItem>();

        public GameSelector() : this(null)
        {
        }

        public GameSelector(GameSelectWindow window)
        {
            Window = window;
            InitializeComponent();
            UpdateStyle();
            TbGames.ColumnCount = ApplicationSettings.GameSelectorColumns;
            TbGames.RowCount = 0;
        }

        public void UpdateStyle()
        {
            BackColor = ApplicationStyle.MainBackColor;
            ForeColor = ApplicationStyle.MainForeColor;
            TopPanel.Font = ApplicationStyle.MainFont;
            TopPanel.ForeColor = ApplicationStyle.MainForeColor;
            LbRomsFound.ForeColor = ApplicationStyle.SecondaryForeColor;
            LnkPrevPage.LinkColor = ApplicationStyle.LinkForeColor;
            LnkNextPage.LinkColor = ApplicationStyle.LinkForeColor;
            LnkPrevPage.ActiveLinkColor = ApplicationStyle.ActiveLinkForeColor;
            LnkNextPage.ActiveLinkColor = ApplicationStyle.ActiveLinkForeColor;
        }

        public void UpdateGames(Emulator emulator)
        {
            if (emulator != Emulator)
                Page = 0;

            Hide();
            Emulator = emulator;
            int maxGamesPerPage = ApplicationSettings.GameSelectorMaxGamesPerPage;

            TbGames.ColumnCount = ApplicationSettings.GameSelectorColumns;
            TbGames.Controls.Clear();
            TbGames.RowCount = emulator.Roms.Count / TbGames.ColumnCount;

            Pages = emulator.Roms.Count / maxGamesPerPage + 1;

            Items.Clear();

            for (int i = Page * maxGamesPerPage; i < emulator.Roms.Count; i++)
            {
                GameRom rom = emulator.Roms[i];

                if (!DisplayOnlyFavorites || (DisplayOnlyFavorites && rom.Favorite))
                    Items.Add(new GameSelectorItem(this, rom));

                if (Items.Count >= maxGamesPerPage)
                    break;
            }

            TbGames.Controls.AddRange(Items.ToArray());

            foreach (RowStyle style in TbGames.RowStyles)
                style.SizeType = SizeType.AutoSize;
            foreach (ColumnStyle style in TbGames.ColumnStyles)
                style.SizeType = SizeType.AutoSize;

            UpdateInfo(emulator);
            Show();
            Refresh();

            if (Items.Count > 0)
                Items[0].SelectItem();
        }

        public void UpdateInfo(Emulator emulator)
        {
            LbMachine.Text = emulator.MachineName;

            if (DisplayOnlyFavorites)
                LbRomsFound.Text = $"{Items.Count} favorite games found (out of {emulator.Roms.Count})";
            else
                LbRomsFound.Text = emulator.Roms.Count + " games found";
            
            LbPage.Text = Pages > 1 ? $"Page {Page + 1} of {Pages}" : "";

            if (Pages > 1)
                PnPageLinks.Show();
            else
                PnPageLinks.Hide();
        }

        public void UpdateActionPanel(GameSelectorItem selectedItem)
        {
            Window.ActionPanel.UpdatePanel(selectedItem);
        }

        public void DeselectAll()
        {
            foreach (GameSelectorItem item in Items)
                item.DeselectItem();
        }

        public void RedrawItem(GameSelectorItem item)
        {
            item.Refresh();
        }

        public void NextPage()
        {
            if (Pages > 1)
            {
                if (Page < Pages - 1)
                    Page++;
                else
                    Page = 0;

                UpdateGames();
            }
        }

        public void PrevPage()
        {
            if (Pages > 1)
            {
                if (Page > 0)
                    Page--;
                else
                    Page = Pages - 1;

                UpdateGames();
            }
        }

        private void UpdateGames()
        {
            UpdateGames(Emulator);
        }

        private void LnkPrevPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrevPage();
        }

        private void LnkNextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NextPage();
        }

        private void ChkOnlyFavorites_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGames();
        }
    }
}

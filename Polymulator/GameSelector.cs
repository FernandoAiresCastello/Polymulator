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
        public SortType Sort { set; get; } = new SortType();

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
            CbSortBy.Font = new Font(CbSortBy.Font.FontFamily, CbSortBy.Font.Size - 1, CbSortBy.Font.Style);
            CbSortBy.DataSource = SortType.List;
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

            ApplySort();
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

        public void ApplySort()
        {
            Emulator.Roms.Sort
            (
                delegate (GameRom rom1, GameRom rom2)
                {
                    int comparedByName = rom1.FriendlyTitle.CompareTo(rom2.FriendlyTitle);

                    if (Sort.Equals(SortType.ByName))
                    {
                        return comparedByName;
                    }
                    else if (Sort.Equals(SortType.ByFileSizeAsc))
                    {
                        return rom1.Size.CompareTo(rom2.Size);
                    }
                    else if (Sort.Equals(SortType.ByFileSizeDesc))
                    {
                        return rom2.Size.CompareTo(rom1.Size);
                    }
                    else if (Sort.Equals(SortType.FavoritesFirst))
                    {
                        if (rom1.Favorite && rom2.Favorite)
                            return rom2.Favorite.CompareTo(rom1.Favorite);
                        else if (rom1.Favorite)
                            return -1;
                        else if (rom2.Favorite)
                            return 1;
                        else
                            return comparedByName;
                    }
                    else if (Sort.Equals(SortType.ByLastTimePlayed))
                    {
                        if (rom1.LastPlayedDateTime.HasValue && rom2.LastPlayedDateTime.HasValue)
                            return rom2.LastPlayedDateTime.Value.CompareTo(rom1.LastPlayedDateTime.Value);
                        else if (rom1.LastPlayedDateTime.HasValue)
                            return -1;
                        else if (rom2.LastPlayedDateTime.HasValue)
                            return 1;
                        else
                            return comparedByName;
                    }
                    else if (Sort.Equals(SortType.WithCoverArtFirst))
                    {
                        if (rom1.HasCoverArt && rom2.HasCoverArt)
                            return rom2.HasCoverArt.CompareTo(rom1.HasCoverArt);
                        else if (rom1.HasCoverArt)
                            return -1;
                        else if (rom2.HasCoverArt)
                            return 1;
                        else
                            return comparedByName;
                    }

                    return 0;
                }
            );
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

        private void CbSortBy_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Emulator != null)
            {
                Sort.Type = (string)CbSortBy.SelectedItem;
                UpdateGames();
            }
        }
    }
}

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
        public int Columns { set; get; } = 5;
        public GameSelectWindow Window { set; get; }

        private List<GameSelectorItem> Items = new List<GameSelectorItem>();

        public GameSelector() : this(null)
        {
        }

        public GameSelector(GameSelectWindow window)
        {
            Window = window;
            InitializeComponent();
            TbGames.ColumnCount = Columns;
            TbGames.RowCount = 0;
        }

        public void UpdateGames(Emulator config)
        {
            Hide();

            TbGames.Controls.Clear();
            TbGames.RowCount = config.Roms.Count / Columns;

            Items.Clear();
            foreach (GameRom rom in config.Roms)
                Items.Add(new GameSelectorItem(this, rom));

            TbGames.Controls.AddRange(Items.ToArray());

            foreach (RowStyle style in TbGames.RowStyles)
                style.SizeType = SizeType.AutoSize;
            foreach (ColumnStyle style in TbGames.ColumnStyles)
                style.SizeType = SizeType.AutoSize;

            Show();
            Refresh();
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
    }
}

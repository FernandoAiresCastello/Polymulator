using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Polymulator
{
    public partial class GameSelectorItem : UserControl
    {
        public GameRom Rom { get; private set; }

        private readonly Image NoCoverArt = Properties.Resources.rom_file;

        private GameSelector Selector;
        private bool Selected = false;

        public GameSelectorItem() : this(null, null)
        {
        }

        public GameSelectorItem(GameSelector selector, GameRom rom)
        {
            Selector = selector;
            InitializeComponent();
            Cursor = Cursors.Hand;
            Margin = new Padding(5);
            LbTitle.Font = ApplicationStyle.MainFont;
            SetRom(rom);
        }

        public void SetRom(GameRom rom)
        {
            Rom = rom;
            Refresh();
        }

        private void Item_Click(object sender, MouseEventArgs e)
        {
            SelectItem();
        }

        public void DeselectItem()
        {
            Selected = false;
            UpdateColors();
        }

        public void SelectItem()
        {
            Selector.DeselectAll();
            Selected = true;
            UpdateColors();
            Selector.UpdateActionPanel(this);
        }

        private void UpdateColors()
        {
            BackColor = Selected ? ApplicationStyle.HighlightBackColor : ApplicationStyle.MainBackColor;
            ForeColor = Selected ? ApplicationStyle.HighlightForeColor : ApplicationStyle.MainForeColor;
        }

        public override void Refresh()
        {
            LbTitle.Text = Rom.File;
            PbCoverArt.Image = !string.IsNullOrWhiteSpace(Rom.CoverArtFile) ? Image.FromFile(Rom.CoverArtFile) : NoCoverArt;
            base.Refresh();
        }
    }
}

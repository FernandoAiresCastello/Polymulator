using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymulator
{
    public partial class GameBrowserWindow : Form
    {
        public List<Emulator> Emulators { get; private set; }
        public Emulator SelectedEmulator { get; private set; }
        public List<GameRom> AllRoms => GetAllRoms();

        public GameBrowserWindow()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ListView.View = View.Details;
            ListView.Scrollable = true;
            ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListView.Columns.Add("Filename");
            ListView.Columns.Add("Type");
            ListView.Columns.Add("Size");
            ListView.Columns.Add("Last played");
            Reload();
        }

        private void Reload()
        {
            Hide();

            try
            {
                Emulators = ConfigFileManager.LoadEmulators();
                ConfigFileManager.LoadAppSettings();
                ConfigFileManager.LoadAppStyle();
                ConfigFileManager.LoadRomInfo(AllRoms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Show();
        }

        private List<GameRom> GetAllRoms()
        {
            List<GameRom> roms = new List<GameRom>();

            if (Emulators != null)
            {
                foreach (Emulator emulator in Emulators)
                    roms.AddRange(emulator.Roms);
            }

            return roms;
        }

        public void LaunchGame(GameRom rom)
        {
            try
            {
                string args = string.IsNullOrWhiteSpace(SelectedEmulator.Arguments) ?
                    "" : SelectedEmulator.Arguments + " ";

                args += "\"" + rom.Path + "\"";
                Process.Start(SelectedEmulator.EmulatorPath, args);
                rom.LastPlayedDateTime = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

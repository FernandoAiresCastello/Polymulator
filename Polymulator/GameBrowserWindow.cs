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
        private List<Emulator> Emulators;
        private List<GameRom> AllRoms => GetAllRoms();
        private List<GameRom> RomList = new List<GameRom>();

        public GameBrowserWindow()
        {
            InitializeComponent();
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            SetWindowForeColor(Color.FromArgb(0, 0, 0));
            SetWindowBackColor(Color.FromArgb(255, 220, 80));
            Reload();

            TxtRom.KeyDown += TxtRom_KeyDown;
            TxtRom.KeyUp += TxtRom_KeyUp;
            LstRoms.KeyDown += LstRoms_KeyDown;
            LstRoms.MouseClick += LstRoms_Click;
            LstRoms.MouseDoubleClick += LstRoms_DoubleClick;
            LstRoms.SelectedIndexChanged += LstRoms_Click;
        }

        private void LstRoms_DoubleClick(object sender, EventArgs e)
        {
            LaunchSelectedGame();
        }

        private void LstRoms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
                TxtRom.Focus();
            else if (e.KeyCode == Keys.Enter)
                LaunchSelectedGame();
            else if (e.Control && e.KeyCode == Keys.O)
                OpenSelectedFileLocation();
        }

        private void TxtRom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                LstRoms.Focus();
        }

        private void TxtRom_KeyUp(object sender, KeyEventArgs e)
        {
            FilterRoms();
        }

        private void LstRoms_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (LstRoms.SelectedItem == null)
                return;

            GameRom rom = LstRoms.SelectedItem as GameRom;
            ClearInfo();
            AddInfo(rom.FriendlyTitle);
            AddInfo("File: " + rom.File);
            AddInfo("Path: " + rom.Path);
            AddInfo("Size: " + rom.SizeDescription);
            AddInfo("Last played: " + rom.LastPlayed);
        }

        private void ClearInfo()
        {
            TxtInfo.Text = "";
        }

        private void AddInfo(string info)
        {
            TxtInfo.AppendText(info + Environment.NewLine);
        }

        private void SetWindowForeColor(Color forecolor)
        {
            RootPanel.ForeColor = forecolor;
            TxtRom.ForeColor = forecolor;
            LstRoms.ForeColor = forecolor;
            TxtInfo.ForeColor = forecolor;
        }

        private void SetWindowBackColor(Color backcolor)
        {
            RootPanel.BackColor = backcolor;
            TxtRom.BackColor = backcolor;
            LstRoms.BackColor = backcolor;
            TxtInfo.BackColor = backcolor;
        }

        private void FilterRoms()
        {
            string title = TxtRom.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(title))
                LstRoms.DataSource = RomList;
            else
                LstRoms.DataSource = RomList.Where(rom => rom.File.ToLower().Contains(title)).ToList();
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
                Error(ex.Message);
            }

            RomList = GetAllRoms();
            LstRoms.DataSource = RomList;
            LstRoms.SelectedItem = null;
            Show();
        }

        private void Error(string msg)
        {
            MessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LaunchSelectedGame()
        {
            if (LstRoms.SelectedItem != null)
                LaunchGame(LstRoms.SelectedItem as GameRom);
        }

        public void LaunchGame(GameRom rom)
        {
            try
            {
                Emulator emulator = GetEmulatorByGameRom(rom);

                if (emulator != null)
                {
                    WindowState = FormWindowState.Minimized;

                    string args = string.IsNullOrWhiteSpace(emulator.Arguments) ? "" : emulator.Arguments + " ";

                    args += "\"" + rom.Path + "\"";
                    Process.Start(emulator.EmulatorPath, args);
                    rom.LastPlayedDateTime = DateTime.Now;
                }
                else
                {
                    Error("Emulator not found for the selected game file");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Emulator GetEmulatorByGameRom(GameRom rom)
        {
            return Emulators.Find(e => e.RomPath == rom.Directory);
        }

        private void OpenSelectedFileLocation()
        {
            if (LstRoms.SelectedItem != null)
            {
                GameRom rom = LstRoms.SelectedItem as GameRom;
                Process.Start(rom.Directory);
            }
        }
    }
}

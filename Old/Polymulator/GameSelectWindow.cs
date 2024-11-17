using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymulator
{
    public partial class GameSelectWindow : Form
    {
        public List<Emulator> Emulators { get; private set; }
        public Emulator SelectedEmulator { get; private set; }
        public List<GameRom> AllRoms => GetAllRoms();
        public GameSelector Selector => GameSelector;

        public GameSelectWindow()
        {
            InitializeComponent();
            splitContainer2.SplitterWidth = 1;
            GameSelector.Window = this;
            ActionPanel.Window = this;
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

            UpdateStyle();
            UpdateMachineList();
            Show();
        }

        public void UpdateStyle()
        {
            LsEmulators.Font = ApplicationStyle.MainFont;
            LsEmulators.ForeColor = ApplicationStyle.MainForeColor;
            LsEmulators.BackColor = ApplicationStyle.MainBackColor;
            PnLsEmulators.BackColor = ApplicationStyle.MainBackColor;
            PnGames.BackColor = ApplicationStyle.MainBackColor;
            PnActions.BackColor = ApplicationStyle.MainBackColor;
            ActionPanel.BackColor = ApplicationStyle.MainBackColor;
            ActionPanel.ForeColor = ApplicationStyle.MainForeColor;
            PnGames.BackColor = ApplicationStyle.MainBackColor;

            GameSelector.UpdateStyle();
        }

        private void UpdateMachineList()
        {
            int previousSelected = LsEmulators.SelectedIndex;

            List<string> machines = new List<string>();

            foreach (Emulator config in Emulators)
                machines.Add(config.MachineName);

            LsEmulators.DataSource = machines;
            LsEmulators.SelectedIndex = previousSelected;
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
                ActionPanel.UpdatePanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LsEmulators_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectEmulator(LsEmulators.SelectedIndex);
        }

        public void SelectEmulator(int index)
        {
            if (index < 0 || index >= Emulators.Count)
                return;

            SelectedEmulator = Emulators[index];
            GameSelector.UpdateGames(SelectedEmulator);
        }

        public void UpdateGameSelector()
        {
            GameSelector.UpdateGames(SelectedEmulator);
        }

        public void RedrawGameSelectorItem(GameSelectorItem item)
        {
            GameSelector.RedrawItem(item);
        }

        public void RedrawActionPanel(GameSelectorItem item)
        {
            ActionPanel.UpdatePanel(item);
        }

        public void SaveRomInfo()
        {
            ConfigFileManager.SaveRomInfo(AllRoms);
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

        private void GameSelectWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRomInfo();
            Application.Exit();
        }

        private void MiOpenAppSettings_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileManager.SettingsFile);
        }

        private void MiOpenEmulatorConfig_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileManager.EmulatorConfigFile);
        }

        private void MiOpenRomConfig_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileManager.RomInfoFile);
        }

        private void MiOpenAppStyleConfig_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileManager.AppStyleConfigFile);
        }

        private void MiOpenConfigFolder_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileManager.BaseFolder);
        }

        private void MiReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void MiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                "POLYMULATOR © 2019\n\nDeveloped by Fernando Aires Castello", 
                "About Polymulator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MiSaveRomConfig_Click(object sender, EventArgs e)
        {
            ConfigFileManager.SaveRomInfo(AllRoms);
            MessageBox.Show(this, 
                "ROM config file saved successfully!", 
                "Config saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MiOpenJoypadConfig_Click(object sender, EventArgs e)
        {
            Process.Start("joy.cpl");
        }
    }
}

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

        public GameSelectWindow()
        {
            InitializeComponent();
            GameSelector.Window = this;
            ActionPanel.Window = this;
            Reload();
        }

        private void Reload()
        {
            Hide();

            try
            {
                SaveRomInfoForAllEmulators();
                ConfigFileLoader.LoadAppSettings();
                ConfigFileLoader.LoadAppStyle();
                Emulators = ConfigFileLoader.LoadEmulators();
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
            GameSelector.BackColor = ApplicationStyle.MainBackColor;
            GameSelector.ForeColor = ApplicationStyle.MainForeColor;
            PnActions.BackColor = ApplicationStyle.MainBackColor;
            ActionPanel.BackColor = ApplicationStyle.MainBackColor;
            ActionPanel.ForeColor = ApplicationStyle.MainForeColor;
            PnGames.BackColor = ApplicationStyle.MainBackColor;
        }

        private void UpdateMachineList()
        {
            List<string> machines = new List<string>();

            foreach (Emulator config in Emulators)
                machines.Add(config.MachineName);

            LsEmulators.DataSource = machines;
        }

        public void LaunchGame(GameRom rom)
        {
            try
            {
                string args = "\"" + rom.Path + "\"";
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
            ConfigFileLoader.LoadRomInfo(SelectedEmulator);
            StMachine.Text = SelectedEmulator.MachineName;
            StRomsFound.Text = SelectedEmulator.Roms.Count + " games found.";
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

        private void GameSelectWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRomInfoForAllEmulators();
            Application.Exit();
        }

        private void MiOpenAppSettings_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileLoader.SettingsFile);
        }

        private void MiOpenEmulatorConfig_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileLoader.EmulatorConfigFile);
        }

        private void MiOpenRomConfig_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileLoader.RomInfoFile);
        }

        private void MiOpenAppStyleConfig_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileLoader.AppStyleConfigFile);
        }

        private void MiOpenConfigFolder_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigFileLoader.BaseFolder);
        }

        private void MiReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void MiAbout_Click(object sender, EventArgs e)
        {
            string msg = "POLYMULATOR © 2019\n\nDeveloped by Fernando Aires Castello";

            MessageBox.Show(this, msg, "About Polymulator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SaveRomInfoForAllEmulators()
        {
            ConfigFileLoader.SaveRomInfo(Emulators);
        }
    }
}

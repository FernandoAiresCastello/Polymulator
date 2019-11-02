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
        private List<Emulator> Emulators;
        private Emulator SelectedEmulator;

        public GameSelectWindow()
        {
            Hide();
            InitializeComponent();
            GameSelector.Window = this;
            ActionPanel.Window = this;

            LsEmulators.Font = ApplicationStyle.MainFont;
            LsEmulators.ForeColor = ApplicationStyle.MainForeColor;
            LsEmulators.BackColor = ApplicationStyle.MainBackColor;
            PnLsEmulators.BackColor = ApplicationStyle.MainBackColor;
            GameSelector.BackColor = ApplicationStyle.MainBackColor;
            GameSelector.ForeColor = ApplicationStyle.MainForeColor;
            ActionPanel.BackColor = ApplicationStyle.MainBackColor;
            ActionPanel.ForeColor = ApplicationStyle.MainForeColor;
            PnGames.BackColor = ApplicationStyle.MainBackColor;

            Reload();
            Show();
        }

        private void Reload()
        {
            try
            {
                Emulators = ApplicationConfig.LoadEmulators();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateMachineList();
        }

        private void UpdateMachineList()
        {
            List<string> machines = new List<string>();

            foreach (Emulator config in Emulators)
                machines.Add(config.MachineName);

            LsEmulators.DataSource = machines;
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
            ApplicationConfig.LoadRomInfo(SelectedEmulator);
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
    }
}

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
    public partial class SettingsWindow : Form
    {
        public static readonly string SettingsFilePath = "config.ini";

        private MainWindow MainWindow;

        public SettingsWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
            Shown += SettingsWindow_Shown;
        }

        private void SettingsWindow_Shown(object sender, EventArgs e)
        {
            TxtConfig.Text = File.ReadAllText(SettingsFilePath);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            File.WriteAllText(SettingsFilePath, TxtConfig.Text);
            MainWindow.OnConfigUpdate();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory);
        }

        public void SetColors(Color foreground, Color background)
        {
            TxtConfig.ForeColor = foreground;
            TxtConfig.BackColor = background;
        }
    }
}

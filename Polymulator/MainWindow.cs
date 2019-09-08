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
    public partial class MainWindow : Form
    {
        private static readonly string configFile = "config.ini";

        private static readonly string[] SizeSuffixes = 
            { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        private List<EmulatorConfig> Emulators = new List<EmulatorConfig>();
        private EmulatorConfig SelectedEmulator;
        private string ScreenshotPath;
        private Bitmap ScreenshotsImage;
        private Timer TitleFlashTimer;
        private List<Color> TitleFlashColors = new List<Color>();
        private int TitleFlashColorIx = 0;

        public MainWindow()
        {
            InitializeComponent();

            TitleFlashColors.Add(Color.Red);
            TitleFlashColors.Add(Color.Lime);
            TitleFlashColors.Add(Color.Blue);
            TitleFlashColors.Add(Color.Magenta);
            TitleFlashColors.Add(Color.Orange);
            TitleFlashColors.Add(Color.Cyan);
            TitleFlashColors.Add(Color.Yellow);
            TitleFlashColors.Add(Color.White);

            TitleFlashTimer = new Timer();
            TitleFlashTimer.Interval = 100;
            TitleFlashTimer.Tick += TitleFlashTimer_Tick;
            TitleFlashTimer.Start();

            Reload();
        }

        private void Reload()
        {
            LoadConfig();
            UpdateMachineList();
            SetWindowColor(Color.MidnightBlue);
            SetControlColor(Color.White, Color.Navy);
            SetNoteColor(Color.White, Color.MidnightBlue);
        }

        private void TitleFlashTimer_Tick(object sender, EventArgs e)
        {
            TitleLabel.ForeColor = TitleFlashColors[TitleFlashColorIx++];
            if (TitleFlashColorIx >= TitleFlashColors.Count)
                TitleFlashColorIx = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetWindowColor(Color color)
        {
            BackColor = color;
        }

        private void SetControlColor(Color foreground, Color background)
        {
            MachineListBox.ForeColor = foreground;
            RomListBox.ForeColor = foreground;

            MachineListBox.BackColor = background;
            MachineListPanel.BackColor = background;
            RomListBox.BackColor = background;
            RomListPanel.BackColor = background;

            TxtSearch.ForeColor = foreground;
            TxtSearch.BackColor = background;
            SearchBoxPanel.BackColor = background;
        }

        private void SetNoteColor(Color foreground, Color background)
        {
            NotePanel.BackColor = background;
            TxtNotes.ForeColor = foreground;
            TxtNotes.BackColor = background;
            ImagePanel.BackColor = background;
        }

        private void MachineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MachineListBox.SelectedIndex;
            if (index < 0 || index >= Emulators.Count)
                return;

            SelectedEmulator = Emulators[index];
            TxtSearch.Text = "";
            TxtNotes.Text = "";
            UpdateRomList();
        }

        private void RomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RomListBox.SelectedValue == null)
            {
                TxtNotes.Text = "";
                return;
            }

            string path = SelectedEmulator.RomPath;
            string romName = RomListBox.SelectedValue.ToString();
            StringBuilder info = new StringBuilder();
            FileInfo file = new FileInfo(path + "\\" + romName);
            info.AppendLine(romName);
            if (file.Exists)
                info.AppendLine("Size: " + SizeSuffix(file.Length));
            else
                info.AppendLine("File not found in path " + path);

            TxtNotes.Text = info.ToString();
            LoadScreenshots(romName);
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FilterRoms();
        }

        private void LoadConfig()
        {
            Emulators.Clear();

            if (!File.Exists(configFile))
            {
                string msg = "Config file " + configFile + " not found.";
                MessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNotes.Text = msg;
                return;
            }

            string[] lines = File.ReadAllLines(configFile);
            ScreenshotPath = lines[0];

            int offset = 1;
            string[] emulatorLines = new ArraySegment<string>(
                lines, offset, lines.Length - offset).ToArray();

            foreach (string line in emulatorLines)
            {
                string[] parts = line.Trim().Split(';');
                string machineName = parts.Length > 0 ? parts[0].Trim() : "";
                string machinePath = parts.Length > 1 ? parts[1].Trim() : "";
                string romPath = parts.Length > 2 ? parts[2].Trim() : "";
                string searchSubfolders = parts.Length > 3 ? parts[3].Trim() : "";
                string[] extensions = parts.Length > 4 ? parts[4].Trim().Split('|') : null;
                string args = parts.Length > 5 ? parts[5].Trim() : "";

                if (!string.IsNullOrWhiteSpace(machineName))
                {
                    EmulatorConfig config = new EmulatorConfig();
                    config.MachineName = machineName;
                    config.EmulatorPath = machinePath;
                    config.RomPath = romPath;
                    config.Arguments = args;
                    config.RomFiles.Clear();

                    if (!string.IsNullOrWhiteSpace(romPath))
                    {
                        if (bool.TrueString.ToLower().Equals(searchSubfolders.ToLower()))
                        {
                            List<string> subfolders = Directory.EnumerateDirectories(romPath).ToList();

                            foreach (string folder in subfolders)
                            {
                                List<string> files = new List<string>();

                                if (extensions == null || extensions[0].Equals("") || extensions[0].Equals("*"))
                                    files = Directory.EnumerateFiles(folder).ToList();
                                else
                                {
                                    foreach (string extension in extensions)
                                        files.AddRange(Directory.EnumerateFiles(folder, extension).ToList());
                                }

                                config.RomFiles.AddRange(files);
                            }
                        }
                        else
                        {
                            if (extensions == null || extensions[0].Equals("") || extensions[0].Equals("*"))
                                config.RomFiles = Directory.EnumerateFiles(romPath).ToList();
                            else
                            {
                                foreach (string extension in extensions)
                                    config.RomFiles.AddRange(Directory.EnumerateFiles(romPath, extension));
                            }
                        }

                        config.RomNames.Clear();
                        foreach (string path in config.RomFiles)
                            config.RomNames.Add(new FileInfo(path).Name);
                    }

                    Emulators.Add(config);
                }
            }
        }

        private void UpdateMachineList()
        {
            List<string> machines = new List<string>();

            foreach (EmulatorConfig config in Emulators)
                machines.Add(config.MachineName);

            MachineListBox.DataSource = machines;
        }

        private void UpdateRomList()
        {
            RomListBox.DataSource = SelectedEmulator.RomNames;
        }

        private void FilterRoms()
        {
            string text = TxtSearch.Text.Trim();

            List<string> roms = SelectedEmulator.RomNames;
            List<string> filteredRoms = roms.FindAll((file) => 
                file.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) >= 0);

            RomListBox.DataSource = filteredRoms;

            if (filteredRoms.Count == 0)
                TxtNotes.Text = "";
        }

        private void RomListBox_DoubleClick(object sender, EventArgs e)
        {
            string filename = (string)RomListBox.SelectedValue;
            if (filename == null)
                return;

            string romPath = SelectedEmulator.RomPath + "\\" + filename;
            string emulatorPath = SelectedEmulator.EmulatorPath;
            string args = SelectedEmulator.Arguments;

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = emulatorPath;
            info.Arguments = $"\"{romPath}\"";
            Process.Start(info);
        }

        static string SizeSuffix(long value, int decimalPlaces = 0)
        {
            if (decimalPlaces < 0)
                throw new ArgumentOutOfRangeException("decimalPlaces");
            if (value < 0)
                return "-" + SizeSuffix(-value);
            if (value == 0)
                return string.Format("{0:n" + decimalPlaces + "} bytes", 0);

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow win = new SettingsWindow(this);
            win.SetColors(Color.AliceBlue, Color.Navy);
            win.ShowDialog(this);
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        public void OnConfigUpdate()
        {
            Reload();
        }

        private void LoadScreenshots(string romName)
        {
            string path1 = $"{ScreenshotPath}\\{romName}.1.png";
            string path2 = $"{ScreenshotPath}\\{romName}.2.png";
            string path3 = $"{ScreenshotPath}\\{romName}.3.png";

            Bitmap scr1 = null;
            Bitmap scr2 = null;
            Bitmap scr3 = null;

            if (File.Exists(path1))
                scr1 = new Bitmap(path1);
            if (File.Exists(path2))
                scr2 = new Bitmap(path2);
            if (File.Exists(path3))
                scr3 = new Bitmap(path3);

            int height = 0;
            if (scr1 != null)
                height += scr1.Height;
            if (scr2 != null)
                height += scr2.Height;
            if (scr3 != null)
                height += scr3.Height;

            int width = Math.Max(scr1 != null ? scr1.Width : 0, 
                Math.Max(scr2 != null ? scr2.Width : 0, scr3 != null ? scr3.Width : 0));

            if (width == 0 || height == 0)
            {
                ScreenshotBox.Image = null;
                return;
            }

            ScreenshotsImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(ScreenshotsImage))
            {
                int x = 0;
                int y = 0;

                if (scr1 != null)
                {
                    g.DrawImage(scr1, x, y);
                    y += scr1.Height;
                }
                if (scr2 != null)
                {
                    g.DrawImage(scr2, x, y);
                    y += scr2.Height;
                }
                if (scr3 != null)
                {
                    g.DrawImage(scr3, x, y);
                    y += scr3.Height;
                }
            }

            ScreenshotBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ScreenshotBox.Image = ScreenshotsImage;
        }
    }
}

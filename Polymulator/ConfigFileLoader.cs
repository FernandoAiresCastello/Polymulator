using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymulator
{
    public static class ConfigFileLoader
    {
        public static readonly string BaseFolder = Application.StartupPath;
        public static readonly string SettingsFile = "settings.ini";
        public static readonly string AppStyleConfigFile = "style.ini";
        public static readonly string EmulatorConfigFile = "emulators.ini";
        public static readonly string RomInfoFile = "roms.ini";

        public static void LoadAppSettings()
        {
            if (!File.Exists(SettingsFile))
                throw new FileNotFoundException("Settings file " + SettingsFile + " not found.");

            Dictionary<string, string> settings = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(SettingsFile);

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("#"))
                    continue;

                string[] parts = line.Trim().Split('=');
                string name = parts[0].Trim();
                string value = parts[1].Trim();
                settings[name] = value;
            }

            ApplicationSettings.Apply(settings);
        }

        public static void LoadAppStyle()
        {
            if (!File.Exists(AppStyleConfigFile))
                throw new FileNotFoundException("Application style config file " + AppStyleConfigFile + " not found.");

            Dictionary<string, string> style = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(AppStyleConfigFile);

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("#"))
                    continue;

                string[] parts = line.Trim().Split('=');
                string name = parts[0].Trim();
                string value = parts[1].Trim();
                style[name] = value;
            }

            ApplicationStyle.Apply(style);
        }

        public static void LoadRomInfo(Emulator emulator)
        {
            if (!File.Exists(RomInfoFile))
                throw new FileNotFoundException("ROM info file " + RomInfoFile + " not found.");

            string[] lines = File.ReadAllLines(RomInfoFile);

            foreach (string line in lines)
            {
                string[] parts = line.Trim().Split(';');
                string romPath = parts.Length > 0 ? parts[0].Trim() : "";
                string coverArtFile = parts.Length > 1 ? parts[1].Trim() : null;
                string screenshotFile = parts.Length > 2 ? parts[2].Trim() : null;
                string notes = parts.Length > 3 ? parts[3].Trim() : null;
                string lastPlayed = parts.Length > 4 ? parts[4].Trim() : null;

                foreach (GameRom rom in emulator.Roms)
                {
                    if (rom.Path.Equals(romPath))
                    {
                        rom.ScreenshotFile = screenshotFile;
                        rom.CoverArtFile = coverArtFile;
                        rom.Notes = notes;
                        if (!string.IsNullOrWhiteSpace(lastPlayed))
                            rom.LastPlayedDateTime = DateTime.Parse(lastPlayed);
                    }
                }
            }
        }

        public static void SaveRomInfo(List<Emulator> emulators)
        {
            if (emulators == null)
                return;

            if (!File.Exists(RomInfoFile))
                File.Create(RomInfoFile);

            List<string> lines = new List<string>();

            foreach (Emulator emulator in emulators)
            {
                foreach (GameRom rom in emulator.Roms)
                {
                    string lastPlayed = rom.LastPlayedDateTime.HasValue ? rom.LastPlayed : null;
                    lines.Add($"{rom.Path};{rom.CoverArtFile};{rom.ScreenshotFile};{rom.Notes};{lastPlayed}");
                }
            }

            File.WriteAllLines(RomInfoFile, lines.ToArray());
        }

        public static List<Emulator> LoadEmulators()
        {
            if (!File.Exists(EmulatorConfigFile))
                throw new FileNotFoundException("Emulator config file " + EmulatorConfigFile + " not found.");

            List<Emulator> emulators = new List<Emulator>();

            string[] lines = File.ReadAllLines(EmulatorConfigFile);

            foreach (string line in lines)
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
                    Emulator emulator = new Emulator
                    {
                        MachineName = machineName,
                        Arguments = args,
                        EmulatorPath = machinePath,
                        RomPath = romPath
                    };

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

                                emulator.AddRoms(files);
                            }
                        }
                        else
                        {
                            if (extensions == null || extensions[0].Equals("") || extensions[0].Equals("*"))
                                emulator.SetRoms(Directory.EnumerateFiles(romPath).ToList());
                            else
                            {
                                foreach (string extension in extensions)
                                    emulator.AddRoms(Directory.EnumerateFiles(romPath, extension).ToList());
                            }
                        }
                    }

                    emulators.Add(emulator);
                }
            }

            return emulators;
        }
    }
}

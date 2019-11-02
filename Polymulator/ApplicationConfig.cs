using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymulator
{
    public static class ApplicationConfig
    {
        private static readonly string emulatorConfigFile = "emulators.ini";
        private static readonly string romInfoFile = "roms.ini";

        public static void LoadRomInfo(Emulator emulator)
        {
            if (!File.Exists(romInfoFile))
                throw new FileNotFoundException("ROM info file " + romInfoFile + " not found.");

            string[] lines = File.ReadAllLines(romInfoFile);

            foreach (string line in lines)
            {
                string[] parts = line.Trim().Split(';');
                string romPath = parts.Length > 0 ? parts[0].Trim() : "";
                string coverArtFile = parts.Length > 1 ? parts[1].Trim() : null;
                string screenshotFile = parts.Length > 2 ? parts[2].Trim() : null;

                foreach (GameRom rom in emulator.Roms)
                {
                    if (rom.Path.Equals(romPath))
                    {
                        rom.ScreenshotFile = screenshotFile;
                        rom.CoverArtFile = coverArtFile;
                    }
                }
            }
        }

        public static List<Emulator> LoadEmulators()
        {
            if (!File.Exists(emulatorConfigFile))
                throw new FileNotFoundException("Emulator config file " + emulatorConfigFile + " not found.");

            List<Emulator> emulators = new List<Emulator>();

            string[] lines = File.ReadAllLines(emulatorConfigFile);

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

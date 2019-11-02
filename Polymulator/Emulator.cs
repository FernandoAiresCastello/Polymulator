using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymulator
{
    public class Emulator
    {
        public string MachineName { set; get; }
        public string EmulatorPath { set; get; }
        public string RomPath { set; get; }
        public List<GameRom> Roms { set; get; } = new List<GameRom>();
        public string Arguments { set; get; }

        public void SetRoms(List<string> files)
        {
            Roms.Clear();
            AddRoms(files);
        }

        public void AddRoms(List<string> files)
        {
            foreach (string file in files)
            {
                Roms.Add(new GameRom(file, new FileInfo(file).Name));
            }
        }
    }
}

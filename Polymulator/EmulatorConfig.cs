using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymulator
{
    public class EmulatorConfig
    {
        public string MachineName { set; get; }
        public string EmulatorPath { set; get; }
        public string RomPath { set; get; }
        public List<string> RomFiles { set; get; } = new List<string>();
        public List<string> RomNames { set; get; } = new List<string>();
        public string Arguments { set; get; }

        public EmulatorConfig()
        {
        }
    }
}

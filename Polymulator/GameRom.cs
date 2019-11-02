using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Polymulator
{
    public class GameRom
    {
        public string Path { set; get; }
        public string File { set; get; }
        public string CoverArtFile { set; get; }
        public string ScreenshotFile { set; get; }
        public string Notes { set; get; }
        public DateTime? LastPlayedDateTime { set; get; }

        public string FriendlyTitle => GetFriendlyTitle();
        public string Size => SizeSuffix(new FileInfo(Path).Length);
        public string LastPlayed => LastPlayedDateTime.HasValue ? LastPlayedDateTime.Value.ToString() : "Never";        

        public GameRom()
        {
        }

        public GameRom(string path, string file)
        {
            Path = path;
            File = file;
        }

        private string SizeSuffix(long value, int decimalPlaces = 0)
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

            string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        private string GetFriendlyTitle()
        {
            string title = System.IO.Path.GetFileNameWithoutExtension(Path);
            return Regex.Replace(title, ApplicationSettings.FriendlyTitleRegex, "");
        }
    }
}

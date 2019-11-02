using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymulator
{
    public static class ApplicationSettings
    {
        public static string FriendlyTitleRegex { set; get; }

        public static void Apply(Dictionary<string, string> settings)
        {
            FriendlyTitleRegex = settings["FriendlyTitleRegex"];
        }
    }
}

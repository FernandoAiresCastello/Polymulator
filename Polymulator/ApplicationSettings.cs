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
        public static int GameSelectorColumns { set; get; } = 5;
        public static int GameSelectorMaxGamesPerPage { set; get; } = 100;

        public static void Apply(Dictionary<string, string> settings)
        {
            FriendlyTitleRegex = settings["FriendlyTitleRegex"];
            GameSelectorColumns = int.Parse(settings["GameSelectorColumns"]);
            GameSelectorMaxGamesPerPage = int.Parse(settings["GameSelectorMaxGamesPerPage"]);
        }
    }
}

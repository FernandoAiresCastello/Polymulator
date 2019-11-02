using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymulator
{
    public static class ApplicationStyle
    {
        public static Font MainFont { set; get; } = new Font("Arial Narrow", 12, FontStyle.Bold);
        public static Color MainBackColor { set; get; } = Color.DarkSlateBlue;
        public static Color MainForeColor { set; get; } = Color.WhiteSmoke;
        public static Color HighlightBackColor { set; get; } = Color.Cyan;
        public static Color HighlightForeColor { set; get; } = Color.Black;
        public static Color SecondaryForeColor { set; get; } = Color.SlateGray;
        public static Color LinkForeColor { set; get; } = Color.Cyan;
        public static Color ActiveLinkForeColor { set; get; } = Color.White;
    }
}

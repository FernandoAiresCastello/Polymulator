using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
        public static float NotesFontSize { set; get; } = 8;

        public static void Apply(Dictionary<string, string> style)
        {
            MainFont = new Font(style["MainFontFamily"], float.Parse(style["MainFontSize"]), FontStyleFromString(style["MainFontStyle"]));
            MainBackColor = ColorFromHexString(style["MainBackColor"]);
            MainForeColor = ColorFromHexString(style["MainForeColor"]);
            HighlightBackColor = ColorFromHexString(style["HighlightBackColor"]);
            HighlightForeColor = ColorFromHexString(style["HighlightForeColor"]);
            SecondaryForeColor = ColorFromHexString(style["SecondaryForeColor"]);
            LinkForeColor = ColorFromHexString(style["LinkForeColor"]);
            ActiveLinkForeColor = ColorFromHexString(style["ActiveLinkForeColor"]);
            NotesFontSize = float.Parse(style["NotesFontSize"]);
        }

        private static Color ColorFromHexString(string hexString)
        {
            if (hexString.StartsWith("0x"))
                hexString = hexString.Substring(2);

            return Color.FromArgb(255, Color.FromArgb(int.Parse(hexString, NumberStyles.HexNumber)));
        }

        private static FontStyle FontStyleFromString(string fontStyle)
        {
            switch (fontStyle)
            {
                case "Bold": return FontStyle.Bold;
                case "Italic": return FontStyle.Italic;
                case "Regular": return FontStyle.Regular;
                case "Strikeout": return FontStyle.Strikeout;
                case "Underline": return FontStyle.Underline;
            }

            throw new ArgumentException("Invalid font style: " + fontStyle);
        }
    }
}

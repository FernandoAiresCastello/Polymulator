using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymulator
{
    public class SortType
    {
        public readonly static string ByName = "Sort by name";
        public readonly static string ByLastTimePlayed = "Sort last played first";
        public readonly static string FavoritesFirst = "Sort favorites first";
        public readonly static string ByFileSizeAsc = "Sort by ascending file size";
        public readonly static string ByFileSizeDesc = "Sort by descending file size";
        public readonly static string WithCoverArtFirst = "Sort with cover art first";

        public static List<string> List
        {
            get
            {
                return new List<string>
                {
                    ByName,
                    ByLastTimePlayed,
                    FavoritesFirst,
                    ByFileSizeAsc,
                    ByFileSizeDesc,
                    WithCoverArtFirst
               };
            }
        }

        public string Type { set; get; }

        public SortType()
        {
            Type = ByName;
        }

        public SortType(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type;
        }

        public override bool Equals(object obj)
        {
            if (GetType() == obj.GetType())
            {
                SortType other = (SortType)obj;
                return Type.Equals(other.Type);
            }
            else if (obj is string)
            {
                return Type.Equals(obj);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode();
        }
    }
}

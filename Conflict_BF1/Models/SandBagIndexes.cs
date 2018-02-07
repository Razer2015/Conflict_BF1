using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflict_BF1.Models
{
    public delegate void IndexesSet();

    public static class SandBagIndexes
    {
        public static event IndexesSet IndexesRefreshed;

        public static IndexList[] Indexes { get; set; }

        static SandBagIndexes() {
            Indexes = new IndexList[4];
            Indexes[0] = new IndexList();      // Red
            Indexes[1] = new IndexList();      // Orange
            Indexes[2] = new IndexList();      // Yellow
            Indexes[3] = new IndexList();      // Green
        }

        public static void RefreshIndexes() {
            IndexesRefreshed?.Invoke();
        }
    }

    public class IndexList
    {
        public bool[] Red { get; set; }
        public bool[] Orange { get; set; }
        public bool[] Yellow { get; set; }
        public bool[] Green { get; set; }

        public IndexList() {
            Red = new bool[8];
            Orange = new bool[6];
            Yellow = new bool[4];
            Green = new bool[2];
        }

        public IndexList(bool[] red, bool[] orange, bool[] yellow, bool[] green) {
            Red = red;
            Orange = orange;
            Yellow = yellow;
            Green = green;
        }
    }
}

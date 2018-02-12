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
        public static event IndexesSet Refreshed;

        //public static IndexList[] Indexes { get; set; }
        public static bool[,] Indexes { get; set; }
        private static int[][] Matrix = new[]
        {
            new int[] { 0, 1, 2, 3, 4, 5, 6, 7 },
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 2, 3, 4, 5 },
            new int[] { 3, 4 }
        };

        static SandBagIndexes() {
            Indexes = new bool[8,8];

            //var x = Matrix[0][1];

            //Indexes = new IndexList[4];
            //Indexes[0] = new IndexList();      // First
            //Indexes[1] = new IndexList();      // Second
            //Indexes[2] = new IndexList();      // Third
            //Indexes[3] = new IndexList();      // Fourth
        }

        public static void RefreshIndexes() {
            Refreshed?.Invoke();
        }

        public static int SandBagCount() {
            int result = 0;
            // Get all bounds before looping.
            int bound0 = Indexes.GetUpperBound(0);
            int bound1 = Indexes.GetUpperBound(1);
            // ... Loop over bounds.
            for (int i = 0; i <= bound0; i++) {
                for (int x = 0; x <= bound1; x++) {
                    // Display the element at these indexes.
                    result += Indexes[i, x] ? 1 : 0;
                }
            }
            return result;
        }

        public static bool GetIndex(int row, int column) {
            if (row < 0 || column < 0) {
                return false;
            }
            return Indexes[row, column];
        }

        public static bool GetIndex(int row, int column, int side) {
            int _row = 0;
            int _column = 0;
            if (side.Equals(0)) {
                _row = row;
                _column = Matrix[row][column];
            }
            else if (side.Equals(1)) {
                _row = Matrix[row][column];
                _column = 7 - row;
            }
            else if (side.Equals(2)) {
                _row = 7 - row;
                _column = Matrix[row][Matrix[row].Length - (column + 1)];
            }
            else if (side.Equals(3)) {
                _row = Matrix[row][Matrix[row].Length - (column + 1)];
                _column = row;
            }
            return Indexes[_row, _column];
        }

        public static void SetIndex(int row, int column, int side, bool value) {
            if (side.Equals(0)) {
                Indexes[row, Matrix[row][column]] = value;
            }
            else if (side.Equals(1)) {
                Indexes[Matrix[row][column], 7 - row] = value;
            }
            else if (side.Equals(2)) {
                Indexes[7 - row, Matrix[row][Matrix[row].Length - (column + 1)]] = value;
            }
            else if (side.Equals(3)) {
                Indexes[Matrix[row][Matrix[row].Length - (column + 1)], row] = value;
            }
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

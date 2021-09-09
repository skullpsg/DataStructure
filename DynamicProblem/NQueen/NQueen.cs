using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.DynamicProblem.NQueen
{
    public class NQueen
    {
        public IConsoleWriter console = null;

        public NQueen(IConsoleWriter console = null)
        {
            this.console = console;
        }

        public bool PlaceNQueen(int[] cols, int row)
        {
            if (row == cols.Length)
            {
                print(cols);
                return true;
            }

            for (int i = 0; i < cols.Length; i++)
            {
                if (isSafe(cols, row, i))
                {
                    cols[row] = i;
                    if (PlaceNQueen(cols, row + 1))
                        return true;
                    cols[row] = -1;
                }
            }
            return false;
        }

        private void print(int[] cols)
        {
            for (int row = 0; row < cols.Length; row++)
            {
                console.WriteLine($"{row},{cols[row]}");
            }
        }

        bool isSafe(int[] cols, int row, int col)
        {
            for (int row2 = 0; row2 < row; row2++)
            {
                int col2 = cols[row2];
                if (col2 == col)
                {
                    return false;
                }
                int colDist = Math.Abs(col2 - col);
                int rowDist = Math.Abs(row2 - row);
                if (rowDist == colDist)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

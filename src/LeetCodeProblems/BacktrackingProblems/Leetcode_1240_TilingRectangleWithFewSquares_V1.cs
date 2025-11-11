using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/tiling-a-rectangle-with-the-fewest-squares/
    /// </summary>
    public class Leetcode_1240_TilingRectangleWithFewSquares_V1
    {
        public int TilingRectangle(int n, int m)
        {
            if (n == m)
            {
                return 1;
            }

            return CalculateMinSquares(n, m);
        }

        private int CalculateMinSquares(int rows, int columns)
        {
            if (rows == columns)
            {
                return 1;
            }

            if(rows == 0 || columns == 0)
            {
                return 0;
            }

            if (rows < 0 || columns < 0)
            {
                return -1;
            }

            var min = Math.Min(rows, columns);
            for (var square = min; square >= 1; square--)
            {
                var remainingRows = rows - square;
                var remainingColumns = columns - square;
            }

            return 0;
        }
    }
}

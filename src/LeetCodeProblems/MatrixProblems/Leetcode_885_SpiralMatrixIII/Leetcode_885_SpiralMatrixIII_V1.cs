using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.Leetcode_885_SpiralMatrixIII
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix-iii/
    /// </summary>
    public class Leetcode_885_SpiralMatrixIII_V1
    {
        public IList<int[]> SpiralOrder(int rows, int cols, int startRow, int startCol)
        {
            var matrix = new int[rows, cols];
            var spiralOrder = new List<int[]>();
            var endRow = startRow + 1;
            var endCol = startCol + 1;
            var cnt = 0;

            while (cnt < 2)
            {
                //Traverse from left to right
                if (startRow >= 0)
                {
                    for (var col = startCol; col < endCol; col++)
                    {
                        spiralOrder.Add(new int[] { startRow, col });
                    }
                }
                startCol -= 1;

                //Traverse from top to bottom
                if (endCol < cols)
                {
                    for (var row = startRow; row < endRow; row++)
                    {
                        spiralOrder.Add(new int[] { row, endCol });
                    }
                }
                startRow -= 1;

                //Traverse from right to left
                if (endRow < rows)
                {
                    for (var col = endCol; col > startCol; col--)
                    {
                        spiralOrder.Add(new int[] { endRow, col });
                    }
                }
                endCol += 1;

                //Traverse from bottom to top
                if (startCol >= 0)
                {
                    for (var row = endRow; row > startRow; row--)
                    {
                        spiralOrder.Add(new int[] { row, startCol });
                    }
                }
                endRow += 1;

                cnt += 1;
            }

            return spiralOrder;
        }
    }
}

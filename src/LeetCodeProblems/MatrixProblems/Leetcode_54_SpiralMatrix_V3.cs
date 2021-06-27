using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class Leetcode_54_SpiralMatrix_V3
    {
        public IList<int> SpiralTraversal(int[,] matrix)
        {
            var spiralOrder = new List<int>();
            var startColumn = 0;
            var endColumn = matrix.GetLength(0);
            var startRow = 0;
            var endRow = matrix.GetLength(0);

            while (true)
            {
                if (startRow < endRow)
                {
                    //Move from left to right
                    for (var column = startColumn; column < endColumn; column++)
                    {
                        spiralOrder.Add(matrix[startRow, column]);
                    }
                    startRow += 1;
                }

                if (endColumn > startColumn)
                {
                    //Move from top to bottom
                    for (var row = startRow; row < endRow; row++)
                    {
                        spiralOrder.Add(matrix[row, endColumn - 1]);
                    }
                    endColumn -= 1;
                }

                if (endRow > startRow)
                {
                    //Move from right to left
                    for (var column = endColumn - 1; column >= startColumn; column--)
                    {
                        spiralOrder.Add(matrix[endRow, column]);
                    }
                    endRow -= 1;
                }

                if (startColumn < endColumn)
                {
                    //Move from bottom to top
                    for (var row = endRow; row > startRow; row--)
                    {
                        spiralOrder.Add(matrix[row, startColumn]);
                    }
                    startRow += 1;
                }
            }
        }
    }
}

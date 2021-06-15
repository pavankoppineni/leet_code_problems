using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class Leetcode_54_SpiralMatrix_V2
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var values = new List<int>();
            var numberOfRows = matrix.GetLength(0);
            var numberOfColumns = matrix.GetLength(1);

            var startColumn = 0;
            var endColumn = numberOfColumns;
            var startRow = 0;
            var endRow = numberOfRows;

            while (true)
            {
                if (startColumn >= endColumn && startRow >= endRow)
                {
                    break;
                }
                //Traverse from left to right
                if (startRow < endRow)
                {
                    for (var column = startColumn; column < endColumn; column++)
                    {
                        values.Add(matrix[startRow, column]);
                    }
                    startRow += 1;
                }

                //Traverse from top to bottom
                if (startColumn < endColumn)
                {
                    for (var row = startRow; row < endRow; row++)
                    {
                        values.Add(matrix[row, endColumn - 1]);
                    }
                    endColumn -= 1;
                }

                //Traverse from right to left
                if (startRow < endRow)
                {
                    for (var column = endColumn - 1; column >= startColumn; column--)
                    {
                        values.Add(matrix[endRow - 1, column]);
                    }
                    endRow -= 1;
                }

                //Traverse from bottom to top
                if (startColumn < endColumn)
                {
                    for (var row = endRow - 1; row >= startRow; row--)
                    {
                        values.Add(matrix[row, startColumn]);
                    }
                    startColumn += 1;
                }
            }
            return values;
        }
    }
}

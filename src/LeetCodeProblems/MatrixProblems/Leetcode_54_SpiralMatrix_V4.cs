using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class Leetcode_54_SpiralMatrix_V4
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var items = new List<int>();
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            var startRow = 0;
            var endRow = rows;
            var startColumn = 0;
            var endColumn = columns;
            while (true)
            {
                if (startRow >= endRow || startColumn >= endColumn)
                {
                    break;
                }

                //Traverse row from left to right
                if (startRow < endRow)
                {
                    for (var column = startColumn; column < endColumn; column++)
                    {
                        items.Add(matrix[startRow, column]);
                    }
                    startRow += 1;
                }

                //Traverse column from top to bottom
                if (startColumn < endColumn)
                {
                    for (var row = startRow; row < endRow; row++)
                    {
                        items.Add(matrix[row, endColumn - 1]);
                    }
                    endColumn -= 1;
                }

                //Traverse row from right to left
                if (startRow < endRow)
                {
                    for (var column = endColumn - 1; column >= startColumn; column--)
                    {
                        items.Add(matrix[endRow - 1, column]);
                    }
                    endRow -= 1;
                }

                //Traverse column from bottom to top
                if (startColumn < endColumn)
                {
                    for (var row = endRow - 1; row >= startRow; row--)
                    {
                        items.Add(matrix[row, startColumn]);
                    }
                    startColumn += 1;
                }
            }

            return items;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class Leetcode_54_SpiralMatrix_V1
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0)
            {
                return Array.Empty<int>();
            }

            var spiralOrderItems = new List<int>();

            //Row index values
            var startRow = 0;
            var endRow = matrix.Length;

            //Column index values
            var startColumn = 0;
            var endColumn = matrix[0].Length;

            while (true)
            {
                if (startRow >= endRow && startColumn >= endColumn)
                {
                    break;
                }

                //Travserse row from left to right
                if (startRow < endRow)
                {
                    for (var column = startColumn; column < endColumn; column++)
                    {
                        spiralOrderItems.Add(matrix[startRow][column]);
                    }
                    startRow += 1;
                }

                //Traverse column from top to bottom
                if (startColumn < endColumn)
                {
                    for (var row = startRow; row < endRow; row++)
                    {
                        spiralOrderItems.Add(matrix[row][endColumn - 1]);
                    }
                    endColumn -= 1;
                }

                //Traverse row from right to left
                if (startRow < endRow)
                {
                    for (var column = endColumn - 1; column >= startColumn; column--)
                    {
                        spiralOrderItems.Add(matrix[endRow - 1][column]);
                    }
                    endRow -= 1;
                }

                //Traverse column from bottom to top
                if (startColumn < endColumn)
                {
                    for (var row = endRow - 1; row >= startRow; row--)
                    {
                        spiralOrderItems.Add(matrix[row][startColumn]);
                    }
                    startColumn += 1;
                }
            }

            return spiralOrderItems;
        }
    }
}

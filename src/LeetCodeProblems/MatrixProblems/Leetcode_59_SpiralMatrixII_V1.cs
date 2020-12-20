using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix-ii/
    /// </summary>
    public class Leetcode_54_SpiralMatrixII_V1
    {
        public int[][] GenerateMatrix(int n)
        {
            var maxElement = n * n;

            var spiralOrderItems = new int[n][];
            var currentIndex = 0;
            while (currentIndex < n)
            {
                spiralOrderItems[currentIndex] = new int[n];
                currentIndex++;
            }

            //Row index elements
            var startRow = 0;
            var endRow = n;

            //Column index elements
            var startColumn = 0;
            var endColumn = n;

            var currentValue = 1;

            while (currentValue <= maxElement)
            {
                //Traverse row from left to right
                for (var column = startColumn; column < endColumn; column++)
                {
                    spiralOrderItems[startRow][column] = currentValue;
                    currentValue += 1;
                }
                startRow += 1;

                //Traverse column from top to bottom
                for (var row = startRow; row < endRow; row++)
                {
                    spiralOrderItems[row][endColumn - 1] = currentValue;
                    currentValue += 1;
                }
                endColumn -= 1;

                //Traverse row from right to left
                for (var column = endColumn - 1; column >= startColumn; column--)
                {
                    spiralOrderItems[endRow - 1][column] = currentValue;
                    currentValue += 1;
                }
                endRow -= 1;

                //Traverse column from bottom to top
                for (var row = endRow - 1; row >= startRow; row--)
                {
                    spiralOrderItems[row][startColumn] = currentValue;
                    currentValue += 1;
                }
                startColumn += 1;

            }

            return spiralOrderItems;
        }
    }
}

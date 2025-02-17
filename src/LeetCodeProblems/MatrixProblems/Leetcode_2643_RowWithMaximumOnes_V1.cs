using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/row-with-maximum-ones
    /// </summary>
    public class Leetcode_2643_RowWithMaximumOnes_V1
    {
        public int[] CalculateRowWithMaximumOnes(int[][] matrix)
        {
            var rowsCount = matrix.Length;
            var columnCount = matrix[0].Length;
            var maxRow = 0;
            var maxCount = 0;
            for (var row = 0; row < rowsCount; row++)
            {
                var currentCount = Calculate(row, matrix, columnCount);
                if (currentCount > maxCount)
                {
                    maxRow = row;
                    maxCount = currentCount;
                }

                if (maxCount == columnCount)
                {
                    break;
                }
            }

            return new int[] { maxRow, maxCount };
        }

        private int Calculate(int row, int[][] matrix, int colCount)
        {
            var count = 0;
            for (var col = 0; col < colCount; col++)
            {
                if (matrix[row][col] == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

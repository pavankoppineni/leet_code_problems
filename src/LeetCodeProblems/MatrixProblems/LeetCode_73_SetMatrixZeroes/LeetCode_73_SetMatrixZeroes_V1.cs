using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems.LeetCode_73_SetMatrixZeroes
{
    /// <summary>
    /// https://leetcode.com/problems/set-matrix-zeroes/
    /// </summary>
    public class LeetCode_73_SetMatrixZeroes_V1
    {
        public int[][] SetZeroes(int[][] matrix)
        {
            var rowsLength = matrix.Length;
            var colsLength = matrix[0].Length;
            var firstCellZero = matrix[0][0] == 0;
            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        matrix[0][col] = 0;
                        matrix[row][0] = 0;
                    }
                }
            }

            //Set rows
            for (var row = 1; row < rowsLength; row++)
            {
                if (matrix[row][0] != 0)
                {
                    continue;
                }

                for (var col = 0; col < colsLength; col++)
                {
                    matrix[row][col] = 0;
                }
            }

            //Set columns
            for (var col = 1; col < colsLength; col++)
            {
                if (matrix[0][col] != 0)
                {
                    continue;
                }

                for (var row = 0; row < rowsLength; row++)
                {
                    matrix[row][col] = 0;
                }
            }

            if(firstCellZero)
            {
                for (var col = 0; col < colsLength; col++)
                {
                    matrix[0][col] = 0;
                }

                for (var row = 0; row < rowsLength; row++)
                {
                    matrix[row][0] = 0;
                }
            }

            return matrix;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1572_MatrixDiagonalSum
{
    /// <summary>
    /// https://leetcode.com/problems/matrix-diagonal-sum/
    /// </summary>
    public class Leetcode_1572_MatrixDiagonalSum_V1
    {
        public int DiagonalSum(int[][] matrix)
        {
            var length = matrix.Length;
            var sum = 0;
            for (int i = 0, row = 0, col = length - 1; i < length; i++)
            {
                sum += matrix[i][i] + matrix[row][col];
                row++;
                col--;
            }
            if ((length & 1) == 1)
            {
                sum -= matrix[length >> 1][length >> 1];
            }
            return sum;
        }
    }
}

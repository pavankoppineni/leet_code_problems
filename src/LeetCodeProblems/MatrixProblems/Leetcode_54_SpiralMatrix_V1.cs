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

            var orderIndex = 0;
            var order = new List<int>();

            //Start row and end row details
            var startRowInclusive = 0;
            var endRowExclusive = matrix.Length;

            //Start column and end column details
            var startColumnInclusive = 0;
            var endColumnExclusive = matrix[0].Length;

            return order;
        }
    }
}

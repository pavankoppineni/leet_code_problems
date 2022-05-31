using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.RecursionProblems.Leetcode_120_Triangle
{
    /// <summary>
    /// https://leetcode.com/problems/triangle/
    /// </summary>
    public class Leetcode_120_Triangle_V1
    {
        private IList<IList<int>> _triangle;
        public int CalculateMinimumPath(IList<IList<int>> triangle)
        {
            _triangle = triangle;
            return CalculateMinimumPath(0, 0);
        }

        private int CalculateMinimumPath(int row, int col)
        {
            if (row == _triangle.Count)
            {
                return 0;
            }
            var items = _triangle[row];
            var value = items[col];
            var minValue = value + Math.Min(CalculateMinimumPath(row + 1, col), CalculateMinimumPath(row + 1, col + 1));
            return minValue;
        }
    }
}

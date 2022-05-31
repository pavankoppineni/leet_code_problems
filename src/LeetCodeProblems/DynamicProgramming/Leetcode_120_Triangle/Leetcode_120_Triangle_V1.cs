using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_120_Triangle
{
    /// <summary>
    /// https://leetcode.com/problems/triangle/
    /// </summary>
    public class Leetcode_120_Triangle_V1
    {
        private IList<IList<int>> _triangle;
        private IDictionary<int, int> _lookup;
        public int CalculateMinimumPath(IList<IList<int>> triangle)
        {
            _lookup = new Dictionary<int, int>();
            _triangle = triangle;
            return CalculateMinimumPath(0, 0);
        }

        private int CalculateMinimumPath(int row, int col)
        {
            var offset = (row * (row + 1)) / 2;
            var index = offset + col;
            if (_lookup.ContainsKey(index))
            {
                return _lookup[index];
            }
            if (row == _triangle.Count)
            {
                return 0;
            }
            var items = _triangle[row];
            var value = items[col];
            var minValue = value + Math.Min(CalculateMinimumPath(row + 1, col), CalculateMinimumPath(row + 1, col + 1));
            _lookup.Add(index, minValue);
            return minValue;
        }
    }
}

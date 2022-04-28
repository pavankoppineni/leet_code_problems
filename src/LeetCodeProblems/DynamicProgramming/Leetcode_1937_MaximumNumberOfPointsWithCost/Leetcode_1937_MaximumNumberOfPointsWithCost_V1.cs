using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_1937_MaximumNumberOfPointsWithCost
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-points-with-cost/
    /// </summary>
    public class Leetcode_1937_MaximumNumberOfPointsWithCost_V1
    {
        private int[][] _points;
        private int _rows;
        private int _columns;
        private IDictionary<int, int> _cellLookUp;
        private IDictionary<int, RowItem> _rowLookUp;
        public int CalculateMaximumNumberOfPoints(int[][] points)
        {
            _cellLookUp = new Dictionary<int, int>();
            _rowLookUp = new Dictionary<int, RowItem>();
            _points = points;
            _rows = points.Length;
            _columns = points[0].Length;
            var maxValue = int.MinValue;
            for (var col = 0; col < _columns; col++)
            {
                var currentValue = CalculateMaximumNumberOfPoints(0, col);
                maxValue = Math.Max(maxValue, currentValue);
            }
            return maxValue;
        }

        private int CalculateMaximumNumberOfPoints(int row, int col)
        {
            if (row >= _rows - 1)
            {
                return _points[row][col];
            }
            if (_rowLookUp.ContainsKey(row))
            {
                if (_rowLookUp[row].Count == _columns)
                {
                    return _rowLookUp[row].MaxValue;
                }
            }
            var index = row * _columns + col;
            if (_cellLookUp.ContainsKey(index))
            {
                return _cellLookUp[index];
            }
            var maxValue = int.MinValue;
            for (var column = 0; column < _columns; column++)
            {
                var currentValue = CalculateMaximumNumberOfPoints(row + 1, column) + _points[row][col] - Math.Abs(column - col);
                maxValue = Math.Max(maxValue, currentValue);
            }
            _cellLookUp.Add(index, maxValue);
            if (_rowLookUp.ContainsKey(row))
            {
                var rowItem = _rowLookUp[row];
                rowItem.Count += 1;
                rowItem.MaxValue = Math.Max(rowItem.MaxValue, maxValue);
            }
            else
            {
                _rowLookUp.Add(row, new RowItem { Count = 1, MaxValue = maxValue });
            }
            return _cellLookUp[index];
        }
    }

    public class RowItem
    {
        public int Count { get; set; }
        public int MaxValue { get; set; }
    }
}

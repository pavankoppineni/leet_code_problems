using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_1981_MinimizeTheDifferenceBetweenTargetAndChosenElements
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-the-difference-between-target-and-chosen-elements/
    /// </summary>
    public class Leetcode_1981_MinimizeTheDifferenceBetweenTargetAndChosenElements_V1
    {
        private int[][] _matrix;
        private int _columns;
        private int _rows;
        private int _target;
        private IDictionary<int, IList<int>> _lookup;
        private int _minDifference = int.MaxValue;
        public int CalculateMinimumDifference(int[][] matrix, int target)
        {
            _lookup = new Dictionary<int, IList<int>>();
            _matrix = matrix;
            _rows = _matrix.Length;
            _columns = _matrix[0].Length;
            _target = target;
            CalculateMinimumDifference(0, 0);
            return _minDifference;
        }

        private void CalculateMinimumDifference(int row, int sum)
        {
            //if (_lookup.ContainsKey(row))
            //{
            //    return _lookup[row];
            //}

            if (row >= _rows)
            {
                _minDifference = Math.Min(_minDifference, Math.Abs(sum - _target));
                return;
            }

            for (var column = 0; column < _columns; column++)
            {
                CalculateMinimumDifference(row + 1, sum + _matrix[row][column]);
            }
            //_lookup.Add(row, values);
            //return values;
        }
    }
}

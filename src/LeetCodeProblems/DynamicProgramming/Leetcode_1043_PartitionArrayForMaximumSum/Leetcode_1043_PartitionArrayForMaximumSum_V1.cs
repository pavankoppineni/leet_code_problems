using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_1043_PartitionArrayForMaximumSum
{
    /// <summary>
    /// https://leetcode.com/problems/partition-array-for-maximum-sum/
    /// </summary>
    public class Leetcode_1043_PartitionArrayForMaximumSum_V1
    {
        private int[] _values;
        private int _size;
        private IDictionary<int, int> _lookup;
        public int CalculateMaximumSum(int[] values, int size)
        {
            _lookup = new Dictionary<int, int>();
            _values = values;
            _size = size;
            return CalculateMaximumSum(0);
        }

        private int CalculateMaximumSum(int startIndex)
        {
            if (startIndex >= _values.Length)
            {
                return 0;
            }

            if (_lookup.ContainsKey(startIndex))
            {
                return _lookup[startIndex];
            }

            var maxSum = 0;
            var maxValue = _values[startIndex];
            for (var index = 0; index < _size; index++)
            {
                if (startIndex + index >= _values.Length)
                {
                    continue;
                }
                if (_values[startIndex + index] > maxValue)
                {
                    maxValue = _values[startIndex + index];
                }
                var currentSum = CalculateMaximumSum(startIndex + index + 1) + (maxValue * (index + 1));
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            _lookup.Add(startIndex, maxSum);
            return maxSum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-and-sum-of-array/
    /// </summary>
    public class Leetcode_2172_MaximumANDSumOfArray_V1
    {
        private int[] _slots;
        private int[] _values;
        private IDictionary<int, int> _lookup;
        public int CalculateMaximumAND(int[] values, int numberOfSlots)
        {
            _lookup = new Dictionary<int, int>();
            _slots = new int[numberOfSlots];
            _values = values;
            return CalculateMaximumAND(0);
        }

        private int CalculateMaximumAND(int level)
        {
            if (level >= _values.Length)
            {
                return 0;
            }

            if (_lookup.ContainsKey(level))
            {
                return _lookup[level];
            }

            var maxValue = 0;
            for (var i = 0; i < _slots.Length; i++)
            {
                if (_slots[i] == 2)
                {
                    continue;
                }
                _slots[i] += 1;
                var currentValue = (_values[level] & (i + 1)) + CalculateMaximumAND(level + 1);
                if (currentValue > maxValue)
                    maxValue = currentValue;
                _slots[i] -= 1;
            }
            _lookup.Add(level, maxValue);
            return maxValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-maximum-bitwise-or-subsets/
    /// </summary>
    public class Leetcode_2044_CountNumberOfMaximumBitwiseORSubsets_V1
    {
        private IDictionary<int, int> _lookup;
        private int[] _values;
        public int CalculateMaxSubSets(int[] values)
        {
            _lookup = new Dictionary<int, int>();
            _values = values;
            CalculateMaxSubSets(0, 0);
            var maxValue = 0;
            foreach (var item in _lookup)
            {
                if (item.Key > maxValue)
                {
                    maxValue = item.Key;
                }
            }
            return _lookup[maxValue];
        }

        private void CalculateMaxSubSets(int level, int orValue)
        {
            if (level == _values.Length)
            {
                if (!_lookup.ContainsKey(orValue))
                {
                    _lookup.Add(orValue, 0);
                }
                _lookup[orValue] += 1;
                return;
            }

            CalculateMaxSubSets(level + 1, orValue | _values[level]);
            CalculateMaxSubSets(level + 1, orValue);
        }
    }
}

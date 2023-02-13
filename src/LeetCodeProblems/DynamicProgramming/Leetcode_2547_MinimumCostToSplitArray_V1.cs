using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-to-split-an-array/
    /// </summary>
    public class Leetcode_2547_MinimumCostToSplitArray_V1
    {
        private int[] _values;
        private int _k;
        private IDictionary<(int start, int end), int> _lookup;
        public int CalculateMinumumCost(int[] values, int k)
        {
            _lookup = new Dictionary<(int start, int end), int>();
            _values = values;
            _k = k;
            return CalculateMinimumCost(0, values.Length - 1);
        }

        private int CalculateMinimumCost(int start, int end)
        {
            if (start > end)
            {
                return 0;
            }

            var key = (start, end);
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }
            var minimumCost = int.MaxValue;
            for (var index = start; index <= end; index++)
            {
                var trimmedCost = _k + CalculateTrimmedCost(start, index);
                var currentCost = CalculateMinimumCost(index + 1, end);
                minimumCost = Math.Min(trimmedCost + currentCost, minimumCost);
            }
            _lookup.Add(key, minimumCost);
            return minimumCost;
        }

        private int CalculateTrimmedCost(int start, int end)
        {
            if (start == end)
            {
                return 0;
            }
            var trimmedCost = 0;
            var lookup = new Dictionary<int, int>();
            while (start <= end)
            {
                if (!lookup.ContainsKey(_values[start]))
                {
                    lookup.Add(_values[start], 1);
                }
                else
                {
                    lookup[_values[start]] += 1;
                }
                start++;
            }

            foreach (var lookupItem in lookup)
            {
                if (lookupItem.Value > 1)
                {
                    trimmedCost += lookupItem.Value;
                }
            }
            return trimmedCost;
        }
    }
}

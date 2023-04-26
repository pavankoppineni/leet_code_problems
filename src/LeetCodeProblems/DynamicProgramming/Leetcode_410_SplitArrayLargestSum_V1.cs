using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/split-array-largest-sum/
    /// </summary>
    public class Leetcode_410_SplitArrayLargestSum_V1
    {
        private int[] _nums;
        private int[] _prefixSum;
        private IDictionary<(int start, int end, int split), int> _lookup;
        public int CalculateSplitArray(int[] nums, int m)
        {
            _nums = nums;
            _lookup = new Dictionary<(int start, int end, int split), int>();
            _prefixSum = new int[nums.Length];
            _prefixSum[0] = nums[0];
            for (var index = 1; index < nums.Length; index++)
            {
                _prefixSum[index] = nums[index] + _prefixSum[index - 1];
            }
            return CalculateSplitArray(0, nums.Length - 1, m);
        }

        private int CalculateSplitArray(int start, int end, int m)
        { 

            if (_lookup.ContainsKey((start, end, m)))
            {
                return _lookup[(start, end, m)];
            }

            if (m == 1)
            {
                if (!_lookup.ContainsKey((start, end, m)))
                {
                    _lookup.Add((start, end, m), GetSubArraySum(start, end));
                }
                return _lookup[(start, end, m)];
            }

            if (end - start + 1 == m)
            {
                var subArrayMax = GetMax(start, end);
                _lookup.Add((start, end, m), subArrayMax);
                return subArrayMax;
            }

            var min = int.MaxValue;
            for (var index = start; index <= end - (m - 1); index++)
            {
                var left = GetSubArraySum(start, index);
                var right = CalculateSplitArray(index + 1, end, m - 1);
                var currentMax = Math.Max(left, right);
                min = Math.Min(min, currentMax);
            }
            _lookup.Add((start, end, m), min);
            return min;
        }

        private int GetSubArraySum(int start, int end)
        {
            if (start == 0)
            {
                return _prefixSum[end];
            }
            return _prefixSum[end] - _prefixSum[start - 1];
        }

        private int GetMax(int start, int end)
        {
            var max = _nums[start];
            for (var index = start; index <= end; index++)
            {
                max = Math.Max(max, _nums[index]);
            }
            return max;
        }
    }
}

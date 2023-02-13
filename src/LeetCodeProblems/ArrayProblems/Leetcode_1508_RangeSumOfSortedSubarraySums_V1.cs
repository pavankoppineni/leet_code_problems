using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-of-sorted-subarray-sums/
    /// </summary>
    public class Leetcode_1508_RangeSumOfSortedSubarraySums_V1
    {
        private HashSet<string> _rangeSet;
        private int[] _nums;
        private IList<int> _rangeSums;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public int RangeSum(int[] nums, int n, int left, int right)
        {
            _nums = nums;
            ConstructRangeSumArray(nums);
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        private void ConstructRangeSumArray(int[] nums)
        {
            var length = nums.Length;
            var rangeSumLength = (length * (length + 1)) / 2;
            _rangeSums = new List<int>(rangeSumLength);
            _rangeSet = new HashSet<string>();
            var totalSum = nums.Sum();
            ConstructRangeSumArray(0, length - 1, totalSum);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="sum"></param>
        private void ConstructRangeSumArray(int left, int right, int sum)
        {
            if (left > right)
            {
                return;
            }

            var key = $"{left}_{right}";
            if (_rangeSet.Contains(key))
            {
                return;
            }
            _rangeSums.Add(sum);
            ConstructRangeSumArray(left + 1, right, sum - _nums[left]);
            ConstructRangeSumArray(left, right - 1, sum - _nums[right]);
            _rangeSet.Add(key);
        }
    }
}

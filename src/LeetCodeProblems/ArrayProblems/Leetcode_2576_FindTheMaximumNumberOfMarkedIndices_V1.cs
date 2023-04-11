using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-number-of-marked-indices/
    /// </summary>
    public class Leetcode_2576_FindTheMaximumNumberOfMarkedIndices_V1
    {
        private int[] _nums;
        public int CalculateMarkedIndices(int[] nums)
        {
            var hashIndices = new HashSet<int>();
            var numberOfIndices = 0;
            Array.Sort(nums);
            _nums = nums;
            var startIndex = 0;
            for (var index = 0; index < _nums.Length; index++)
            {
                if (hashIndices.Contains(index))
                {
                    continue;
                }
                hashIndices.Add(index);
                var rightIndex = CalculateRightIndex(startIndex + 1, _nums.Length - 1, _nums[index] * 2);
                if (rightIndex == -1)
                {
                    break;
                }
                startIndex = rightIndex;
                numberOfIndices += 2;
                hashIndices.Add(rightIndex);
            }
            return numberOfIndices;
        }

        private int CalculateRightIndex(int left, int right, int value)
        {
            if (left > right)
            {
                return -1;
            }

            if (left == right)
            {
                if (value <= _nums[left])
                {
                    return left;
                }
                return -1;
            }

            var mid = left + ((right - left) / 2);
            if (value <= _nums[mid])
            {
                return CalculateRightIndex(left, mid, value);
            }
            return CalculateRightIndex(mid + 1, right, value);
        }
    }
}

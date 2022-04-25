using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_525_ContiguousArray
{
    /// <summary>
    /// https://leetcode.com/problems/contiguous-array/
    /// </summary>
    public class Leetcode_525_ContiguousArray_V1
    {
        public int CalculateMaximumLength(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return 0;
            }
            if (nums.Length == 2)
            {
                return nums[0] + nums[1] == 1 ? 2 : 0;
            }

            var maxLength = 0;
            var lookUpSum = new Dictionary<int, int>();
            var previous = 0;
            for (var index = 0; index < nums.Length; index++)
            {
                if (nums[index] == 0)
                {
                    previous += -1;
                }
                else
                {
                    previous += 1;
                }
                if (previous == 0)
                {
                    maxLength = index + 1;
                    continue;
                }
                if (!lookUpSum.ContainsKey(previous))
                {
                    lookUpSum.Add(previous, index);
                }
                else
                {
                    maxLength = Math.Max(maxLength, index - lookUpSum[previous]);
                }
            }
            return maxLength;
        }
    }
}

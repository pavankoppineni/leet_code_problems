using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2401_LongestNiceSubarray
{
    /// <summary>
    /// https://leetcode.com/problems/longest-nice-subarray/
    /// </summary>
    public class Leetcode_2401_LongestNiceSubarray_V1
    {
        public int FindLongestNiceSubarray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 1;
            }
            var maxLength = 0;
            var previousIndex = 0;
            var logicalOR = nums[0];
            var currentLength = 1;
            for (var index = 1; index < nums.Length; index++)
            {
                //Case One
                if ((logicalOR & nums[index]) == 0)
                {
                    currentLength += 1;
                    logicalOR |= nums[index];
                }
                //Case Two
                else
                {
                    while (previousIndex < index)
                    {
                        var compliment = ~nums[previousIndex];
                        logicalOR &= compliment;
                        previousIndex += 1;
                        if ((logicalOR & nums[index]) == 0)
                        {
                            break;
                        }
                    }
                    logicalOR |= nums[index];
                    currentLength = index - previousIndex + 1;
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            return maxLength;
        }
    }
}

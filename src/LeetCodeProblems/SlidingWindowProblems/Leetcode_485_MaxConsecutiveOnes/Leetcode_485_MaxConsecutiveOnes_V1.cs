using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems.Leetcode_485_MaxConsecutiveOnes
{
    /// <summary>
    /// https://leetcode.com/problems/max-consecutive-ones/
    /// </summary>
    public class Leetcode_485_MaxConsecutiveOnes_V1
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var maxCount = 0;
            var currentCount = 0;
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 0;
                }
                else
                {
                    currentCount += 1;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        }
    }
}

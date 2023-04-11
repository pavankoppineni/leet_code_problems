using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximize-greatness-of-an-array/
    /// </summary>
    public class Leetcode_2592_MaximizeGreatnessOfArray_V1
    {
        public int CalculateMaximumGreatness(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            Array.Sort(nums);
            var start = 0;
            var end = 1;
            var count  = 0;
            while (end < nums.Length)
            {
                //When : start is less than end
                //Then : increment count
                if (nums[end] > nums[start])
                {
                    count++;
                    start++;
                    end++;
                }
                //When : start is greater than or equal to end
                //Then : increment end
                else
                {
                    end++;
                }
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/first-missing-positive/
    /// </summary>
    public class Leetcode_41_FindMissingPositive_V1
    {
        public int FindMissingPositive(int[] nums)
        {
            var auxilaryArray = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num <= 0 || num >= nums.Length)
                {
                    continue;
                }
                auxilaryArray[num - 1] = 1;
            }

            var missingPositiveNumber = 0;
            for (var i = 0; i < auxilaryArray.Length; i++)
            {
                if (auxilaryArray[i] == 0)
                {
                    missingPositiveNumber = i + 1;
                    break;
                }
            }

            if (missingPositiveNumber == 0)
            {
                return auxilaryArray.Length + 1;
            }

            return missingPositiveNumber;
        }
    }
}

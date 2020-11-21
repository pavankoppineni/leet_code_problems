using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class Leetcode_287_FindTheDuplicateNumber_V1
    {
        public int FindDuplicate(int[] nums)
        {
            int duplicateNumber = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var absNum = Math.Abs(num);
                var index = absNum - 1;
                var indexNum = nums[index];
                if(indexNum < 0)
                {
                    duplicateNumber = absNum;
                    break;
                }
                else
                {
                    nums[index] = -1 * nums[index];
                }
            }

            return duplicateNumber;
        }
    }
}

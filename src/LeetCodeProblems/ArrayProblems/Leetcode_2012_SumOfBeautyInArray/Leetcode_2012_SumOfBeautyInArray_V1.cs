using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2012_SumOfBeautyInArray
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-beauty-in-the-array/
    /// </summary>
    public class Leetcode_2012_SumOfBeautyInArray_V1
    {
        public int CalculateSumOfBeauties(int[] nums)
        {
            var prefixArray = new int[nums.Length];
            var suffixArray = new int[nums.Length];

            prefixArray[0] = nums[0];
            for (var index = 1; index < nums.Length; index++)
            {
                prefixArray[index] = Math.Max(prefixArray[index - 1], nums[index]);
            }

            suffixArray[nums.Length - 1] = nums[nums.Length - 1];
            for (var index = nums.Length - 2; index >= 0; index--)
            {
                suffixArray[index] = Math.Min(suffixArray[index + 1], nums[index]);
            }

            var sum = 0;
            for (var index = 1; index < nums.Length - 1; index++)
            {
                var value = nums[index];
                //Case 1 : Value is greater than all items to the left and value is less than all items to right
                if (prefixArray[index - 1] < value && suffixArray[index + 1] > value)
                {
                    sum += 2;
                    continue;
                }

                //Case 2 : Value is greater than index-1 and less than index+1
                if (value > nums[index - 1] && value < nums[index + 1])
                {
                    sum += 1;
                }
            }

            return sum;
        }
    }
}

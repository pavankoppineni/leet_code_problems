using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-i/
    /// </summary>
    public class Leetcode_3201_FindMaximumLengthOfValidSubsequence_V1
    {
        public int CalculateMaxLength(int[] nums)
        {
            var result = new Result { };
            var prev = nums[0] % 2;
            if (prev == 0)
            {
                result.EvenLength += 1;
            }
            else
            {
                result.OddLength += 1;
            }
            result.OddEvenLength += 1;
            for (var index = 1; index < nums.Length; index++)
            {
                var currentValue = nums[index] % 2;
                if (currentValue == 0)
                {
                    result.EvenLength += 1;
                }
                else
                {
                    result.OddLength += 1;
                }
                if (prev != currentValue)
                {
                    result.OddEvenLength += 1;
                }
            }
            return result.CalculateMaximumLength();
        }

        public class Result
        {
            public int EvenLength { get; set; }
            public int OddLength {  get; set; }
            public int OddEvenLength {  get; set; }
            public int CalculateMaximumLength()
            {
                var max = Math.Max(EvenLength, OddLength);
                return Math.Max(max, OddEvenLength);
            }
        }
    }
}

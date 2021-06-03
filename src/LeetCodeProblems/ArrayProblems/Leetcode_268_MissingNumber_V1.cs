using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/missing-number/
    /// </summary>
    public class Leetcode_268_MissingNumber_V1
    {
        public int FindMissingNumber(int[] values)
        {
            var len = values.Length;
            var maxSum = len * (len + 1) / 2;
            var sum = values.Sum();
            return maxSum - sum;
        }
    }
}

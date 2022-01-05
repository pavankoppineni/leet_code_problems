using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GFG_Problems.CountOfSubsetsWithSumEqualToX
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-of-subsets-with-sum-equal-to-x/
    /// </summary>
    public class CountOfSubsetsWithSumEqualToX_Recursion_V1
    {
        private int[] _arr;
        public int CountOfSubsetsWithSumEqualToX(int[] arr, int sum)
        {
            _arr = arr;
            return CountOfSubsetsWithSumEqualToX(0, sum);
        }

        private int CountOfSubsetsWithSumEqualToX(int level, int sum)
        {
            if (sum == 0)
            {
                return 1;
            }

            if (level >= _arr.Length)
            {
                return 0;
            }

            if (sum < 0)
            {
                return 0;
            }

            var left = CountOfSubsetsWithSumEqualToX(level + 1, sum - _arr[level]);
            var right = CountOfSubsetsWithSumEqualToX(level + 1, sum);
            return left + right;
        }
    }
}

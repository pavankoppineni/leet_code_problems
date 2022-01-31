using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1589_MaximumSumObtainedOfAnyPermutation
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-sum-obtained-of-any-permutation/
    /// </summary>
    public class Leetcode_1589_MaximumSumObtainedOfAnyPermutation_V1
    {
        public long MaxSumRangeQuery(int[] values, int[][] requests)
        {
            var countArray = new int[values.Length + 1];
            foreach (var request in requests)
            {
                countArray[request[0]] += 1;
                countArray[request[1] + 1] -= 1;
            }
            for (var index = 1; index < countArray.Length; index++)
            {
                countArray[index] += countArray[index - 1];
            }
            Array.Sort(countArray, new DecreasingComparer());
            Array.Sort(values, new DecreasingComparer());
            long sum = 0;
            for (var index = 0; index < countArray.Length - 1; index++)
            {
                if (countArray[index] <= 0)
                {
                    break;
                }
                sum += countArray[index] * values[index];
            }
            return sum;
        }
    }

    public class DecreasingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

}

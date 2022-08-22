using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GFG_Problems.MinimumSwapsRequiredToGroupAllOnesTogether
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/minimum-swaps-required-to-group-all-1s-together2451/1
    /// </summary>
    public class MinimumSwapsRequiredToGroupAllOnesTogether
    {
        public int CalculateMinimumSwaps(int[] arr)
        {
            var n = arr.Length;
            var count = 0;
            for (int index = 0; index < n; index++)
            {
                if (arr[index] == 1)
                {
                    count++;
                }
            }

            var minSwaps = 0;
            var currentSwaps = 0;
            var start = 0;
            var right = count;
            var zeroCount = 0;
            for (int index = 0; index < right; index++)
            {
                if (arr[index] == 0)
                {
                    zeroCount++;
                }
            }
            minSwaps = zeroCount;
            currentSwaps = minSwaps;
            for (int index = right; index < n; index++)
            {
                if (arr[index] == 0)
                {
                    currentSwaps += 1;
                }
                if (arr[start] == 0)
                {
                    currentSwaps -= 1;
                }
                if (currentSwaps < minSwaps)
                {
                    minSwaps = currentSwaps;
                }
                start += 1;
            }
            return minSwaps;
        }
    }
}

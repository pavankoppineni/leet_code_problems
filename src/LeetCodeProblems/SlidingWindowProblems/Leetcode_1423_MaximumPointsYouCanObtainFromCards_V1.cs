using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
    /// </summary>
    public class Leetcode_1423_MaximumPointsYouCanObtainFromCards_V1
    {
        public int CalculateMaximumScore(int[] values, int k)
        {
            var maxSum = 0;
            for (var index = 0; index < k; index++)
            {
                maxSum += values[index];
            }

            if (k == values.Length)
            {
                return maxSum;
            }

            var currentSum = maxSum;
            var count = 1;
            while (count <= k)
            {
                currentSum -= values[k - count];
                currentSum += values[values.Length - count];
                count += 1;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            return maxSum;
        }
    }
}

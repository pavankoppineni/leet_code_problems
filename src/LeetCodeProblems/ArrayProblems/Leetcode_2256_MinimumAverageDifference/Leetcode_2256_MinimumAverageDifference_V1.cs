using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2256_MinimumAverageDifference
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-average-difference/
    /// </summary>
    public class Leetcode_2256_MinimumAverageDifference_V1
    {
        public int CalculateMinimumAverageDifference(int[] values)
        {
            var minIndex = -1;
            double minimumAvgDifference = int.MaxValue;
            long totalSum = 0;
            for (var index = 0; index < values.Length; index++)
            {
                totalSum += values[index];
            }

            long leftSum = 0;
            for (var index = 0; index < values.Length - 1; index++)
            {
                leftSum += values[index];
                double leftAverage = leftSum / (index + 1);
                var rightSum = totalSum - leftSum;
                double rightAverage = rightSum / (values.Length - (index + 1));
                var difference = Math.Abs(leftAverage - rightAverage);
                if (difference < minimumAvgDifference)
                {
                    minimumAvgDifference = difference;
                    minIndex = index;
                }
            }

            double average = totalSum / values.Length;
            if (average < minimumAvgDifference)
            {
                minIndex = values.Length - 1;
            }

            return minIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-sum-of-mountain-triplets-i/
    /// </summary>
    public class Leetcode_2908_MinimumSumOfMountainTriplets_1_V1
    {
        public int CalculateMinimumSum(int[] values)
        {
            var triplets = new Triplet[values.Length];
            var leftMin = values[0];
            for (int index = 1; index < values.Length - 1; index++)
            {
                triplets[index] = new Triplet();
                triplets[index].LeftMin = leftMin;
                triplets[index].CurrentValue = values[index];
                leftMin = Math.Min(leftMin, values[index]);
            }

            var rightMin = values[values.Length - 1];
            for (int index = values.Length - 2; index >= 1; index--)
            {
                triplets[index].RightMin = rightMin;
                triplets[index].CurrentValue = values[index];
                rightMin = Math.Min(rightMin, values[index]);
            }

            var minimumSum = int.MaxValue;
            for (var index = 1; index < values.Length - 1; index++)
            {
                var currentTriplet = triplets[index];
                if (currentTriplet.IsValid())
                {
                    minimumSum = Math.Min(minimumSum, currentTriplet.CalculateTripletSum());
                }
            }

            return minimumSum == int.MaxValue ? -1 : minimumSum;
        }
    }

    public class Triplet
    {
        public int LeftMin { get; set; }
        public int RightMin { get; set; }
        public int CurrentValue { get; set; }
        public bool IsValid()
        {
            return CurrentValue > LeftMin && CurrentValue > RightMin;
        }
        public int CalculateTripletSum()
        {
            return CurrentValue + LeftMin + RightMin;
        }
    }
}

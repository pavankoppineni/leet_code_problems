using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/reducing-dishes/
    /// </summary>
    public class Leetcode_1402_ReducingDishes_V1
    {
        public int CalculateMaximumSatisfaction(int[] satisfactions)
        {
            var suffixSum = 0;
            var maxSatisfaction = 0;
            Array.Sort(satisfactions);
            for (var index = satisfactions.Length - 1; index >= 0; index--)
            {
                var currentSatisfaction = satisfactions[index] + maxSatisfaction + suffixSum;
                if (currentSatisfaction >= maxSatisfaction)
                {
                    maxSatisfaction = currentSatisfaction;
                }
                else
                {
                    break;
                }
                suffixSum += satisfactions[index];
            }
            return maxSatisfaction;
        }
    }
}

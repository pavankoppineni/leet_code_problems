using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_746_MinCostClimbingStairs
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-climbing-stairs/
    /// </summary>
    public class Leetcode_746_MinCostClimbingStairs_V1
    {
        public int MinCostClimbingStairs(int[] costs)
        {
            var firstStep = MinCostClimbingStairs(costs, 0);
            var secondStep = MinCostClimbingStairs(costs, 1);
            return Math.Min(firstStep, secondStep);
        }

        private int MinCostClimbingStairs(int[] costs, int index)
        {
            if (index >= costs.Length)
            {
                return 0;
            }
            var firstStep = MinCostClimbingStairs(costs, index + 1);
            var secondStep = MinCostClimbingStairs(costs, index + 2);
            return costs[index] + Math.Min(firstStep, secondStep);
        }
    }
}

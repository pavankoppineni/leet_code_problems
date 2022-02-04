using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_198_HouseRobber
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber/
    /// </summary>
    public class Leetcode_198_HouseRobber_V1
    {
        public int Rob(int[] houses)
        {
            var exclusive = 0;
            var inclusive = houses[0];
            for (var index = 1; index < houses.Length; index++)
            {
                var tempInclusive = inclusive - houses[index - 1];
                var newInclusive = Math.Max(tempInclusive + houses[index], exclusive + houses[index]);
                exclusive = inclusive;
                inclusive = newInclusive;
            }
            return Math.Max(exclusive, inclusive);
        }
    }
}

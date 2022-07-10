using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2274_MaximumConsecutiveFloorsWithoutSpecialFloors
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-consecutive-floors-without-special-floors/
    /// </summary>
    public class Leetcode_2274_MaximumConsecutiveFloorsWithoutSpecialFloors_V1
    {
        public int CalculateMaximumConsecutiveFloors(int bottom, int top, int[] specialFloors)
        {
            Array.Sort(specialFloors);
            var max = 0;
            for (var index = 1; index < specialFloors.Length; index++)
            {
                var currentMax = specialFloors[index] - specialFloors[index - 1];
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }
            max = Math.Max(specialFloors[0] - bottom, max);
            max = Math.Max(top - specialFloors[specialFloors.Length - 1], max);
            return max;
        }
    }
}

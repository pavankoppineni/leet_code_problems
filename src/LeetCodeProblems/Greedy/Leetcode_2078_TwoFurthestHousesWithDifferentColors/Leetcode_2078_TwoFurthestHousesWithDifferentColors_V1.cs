using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_2078_TwoFurthestHousesWithDifferentColors
{
    /// <summary>
    /// https://leetcode.com/problems/two-furthest-houses-with-different-colors/
    /// </summary>
    public class Leetcode_2078_TwoFurthestHousesWithDifferentColors_V1
    {
        public int CalculateMaximumDistance(int[] colors)
        {
            var firstColor = colors[0];
            var lastColor = colors[colors.Length - 1];
            var maxDistanceLeft = 0;
            var maxDistanceRight = 0;
            for (var index = colors.Length - 1; index >= 0; index--)
            {
                if (colors[index] != firstColor)
                {
                    maxDistanceLeft = index;
                    break;
                }
            }

            for (var index = 0; index < colors.Length; index++)
            {
                if (colors[index] != lastColor)
                {
                    maxDistanceRight = colors.Length - index - 1;
                    break;
                }
            }

            return Math.Max(maxDistanceLeft, maxDistanceRight);
        }
    }
}

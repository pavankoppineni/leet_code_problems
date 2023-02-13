using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/furthest-building-you-can-reach/
    /// </summary>
    public class Leetcode_1642_FurthestBuildingYouCanReach_V1
    {
        public int CalculateFurthestBuilding(int[] heights, int bricks, int ladders)
        {
            var farthestBuilding = 0;
            for (var index = 0; index < heights.Length - 1; index++)
            {
                var current = heights[index];
                var next = heights[index + 1];

                //When : current is greater than next
                //Then : Do nothing
                if (current >= next)
                {
                    farthestBuilding = index + 1;
                    continue;
                }

                //When : current is less than or equal to next
                var diff = next - current;
                if (diff >= bricks)
                {
                    if (ladders <= 0)
                    {
                        break;
                    }
                    ladders -= 1;
                }
                else
                {
                    if (bricks <= 0)
                    {
                        break;
                    }
                    bricks -= diff;
                }
                farthestBuilding = index + 1;
            }
            return farthestBuilding;
        }
    }
}

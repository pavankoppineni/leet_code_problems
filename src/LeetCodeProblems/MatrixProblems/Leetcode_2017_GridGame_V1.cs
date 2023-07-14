using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/grid-game/
    /// </summary>
    public class Leetcode_2017_GridGame_V1
    {
        public long GridGame(int[][] grid)
        {
            long roboTwoOptimalPoints = long.MaxValue;
            long rowOneSum = 0;
            long rowTwoSum = 0;
            for (var col = 0; col < grid[0].Length; col++)
            {
                rowOneSum += grid[0][col];
                rowTwoSum += grid[1][col];
            }
            long rowTwoPrefixSum = 0;
            long rowOnePrefixSum = 0;
            for(var col = 0; col < grid[0].Length; col++)
            {
                var current = Math.Max(rowTwoPrefixSum, rowOneSum - (rowOnePrefixSum + grid[0][col]));
                if (current < roboTwoOptimalPoints)
                {
                    roboTwoOptimalPoints = currentRobotTwoOptimal;
                }
                rowOnePrefixSum += grid[0][col];
                rowTwoPrefixSum += grid[1][col];
            }
            return roboTwoOptimalPoints;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-moves-to-reach-target-score/
    /// </summary>
    public class Leetcode_2139_MinimumMovesToReachTargetScore_V1
    {
        public int CalculateMinimumMoves(int target, int maxDoubles)
        {
            var minimumMoves = 0;
            while (target > 1 && maxDoubles > 0)
            {
                if ((target & 1) == 0)
                {
                    target /= 2;
                    maxDoubles--;
                }
                else
                {
                    target -= 1;
                }
                minimumMoves += 1;
            }
            return minimumMoves + target - 1;
        }
    }
}

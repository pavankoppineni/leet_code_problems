using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_1007_MinimumDominoRotationsForEqualRow
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/
    /// </summary>
    public class Leetcode_1007_MinimumDominoRotationsForEqualRow_V1
    {
        public int MinDominoRotations(int[] tops, int[] bottoms)
        {
            var topCount = Calculate(tops, bottoms, tops[0]);
            var bottomsCount = Calculate(tops, bottoms, bottoms[0]);
            if (topCount == -1)
            {
                return bottomsCount;
            }
            if (bottomsCount == -1)
            {
                return topCount;
            }
            return Math.Min(topCount, bottomsCount);
        }

        private int Calculate(int[] top, int[] bottom, int value)
        {
            var topCount = 0;
            var bottomCount = 0;
            for (var index = 0; index < top.Length; index++)
            {
                if (top[index] != value && bottom[index] != value)
                {
                    return -1;
                }

                if (top[index] != value)
                {
                    topCount++;
                }

                if (bottom[index] != value)
                {
                    bottomCount++;
                }
            }

            return Math.Min(topCount, bottomCount);
        }
    }
}

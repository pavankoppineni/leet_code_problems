using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_45_JumpGame_II
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game-ii/
    /// </summary>
    public class Leetcode_45_JumpGame2_Recursion
    {
        public int MinJumps(int[] jumps)
        {
            return MinJumps(0, jumps, 0);
        }

        private int MinJumps(int position, int[] jumps, int steps)
        {
            if (position >= jumps.Length - 1)
            {
                return steps;
            }
            var jump = jumps[position];
            var allJumps = new List<int>();
            while (jump > 0)
            {
                allJumps.Add(MinJumps(position + jump, jumps, steps + 1));
                jump--;
            }
            return allJumps.Min();
        }
    }
}

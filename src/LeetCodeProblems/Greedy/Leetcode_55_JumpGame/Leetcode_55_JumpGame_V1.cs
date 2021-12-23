using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_55_JumpGame
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game/
    /// </summary>
    public class Leetcode_55_JumpGame_V1
    {
        public bool CanJump(int[] jumps)
        {
            var destination = jumps.Length - 1;
            var maxJump = 0;
            for (var index = 0; index < jumps.Length - 1; index++)
            {
                maxJump = Math.Max(maxJump, index + jumps[index]);
                if (maxJump >= destination)
                {
                    return true;
                }
                if (index == maxJump)
                {
                    return false;
                }
            }
            return false;
        }
    }
}

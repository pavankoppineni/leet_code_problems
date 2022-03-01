using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_877_StoneGame
{
    /// <summary>
    /// https://leetcode.com/problems/stone-game/
    /// </summary>
    public class Leetcode_877_StoneGame_Recursion
    {
        private int[] _piles;
        public bool StoneGame(int[] piles)
        {
            _piles = piles;
            return StoneGame(0, piles.Length - 1, 0, 0, 0);
        }

        private bool StoneGame(int start, int end, int alice, int bob, int turn)
        {
            if (start == end)
            {
                return alice > bob + _piles[start];
            }

            if (turn == 0)
            {
                var left = StoneGame(start + 1, end, alice + _piles[start], bob, 1);
                var right = StoneGame(start, end - 1, alice + _piles[end], bob, 1);
                return left || right;
            }
            else
            {
                var left = StoneGame(start + 1, end, alice, bob + _piles[start], 0);
                var right = StoneGame(start, end - 1, alice, bob + _piles[end], 0);
                return left || right;
            }
        }
    }
}

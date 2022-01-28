using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_322_CoinChange
{
    /// <summary>
    /// https://leetcode.com/problems/coin-change/
    /// </summary>
    public class Leetcode_322_CoinChange_V1
    {
        private int _minCount = -1;
        private int[] _coins;
        public int MinCount(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            _coins = coins;
            CalcualteCount(0, amount, 0);
            return _minCount;
        }

        private void CalcualteCount(int index, int amount, int count)
        {
            //Case 1 : When amount is zero
            if (amount == 0)
            {
                if (_minCount == -1)
                {
                    _minCount = count;
                }
                else
                {
                    _minCount = Math.Min(count, _minCount);
                }
                return;
            }

            //Case 2 : When index is greater than or equal to length of coins
            if (index >= _coins.Length)
            {
                return;
            }
            for (var i = index; i < _coins.Length; i++)
            {
                if (_coins[i] > amount)
                {
                    CalcualteCount(i + 1, amount, count);
                }
                else
                {
                    CalcualteCount(i, amount - _coins[i], count + 1);
                }
            }
        }
    }
}

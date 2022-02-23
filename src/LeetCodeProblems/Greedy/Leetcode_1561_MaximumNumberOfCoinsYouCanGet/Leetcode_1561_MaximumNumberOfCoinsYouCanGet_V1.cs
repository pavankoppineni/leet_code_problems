using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_1561_MaximumNumberOfCoinsYouCanGet
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-coins-you-can-get/
    /// </summary>
    public class Leetcode_1561_MaximumNumberOfCoinsYouCanGet_V1
    {
        public int MaxCoins(int[] coins)
        {
            var sum = 0;
            Array.Sort(coins);
            var triplets = coins.Length / 3;
            var index = coins.Length - 1;
            while (triplets > 0)
            {
                sum += coins[index];
                index -= 2;
                triplets--;
            }
            return sum;
        }
    }
}

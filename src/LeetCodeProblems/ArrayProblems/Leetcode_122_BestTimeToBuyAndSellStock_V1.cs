using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
    /// </summary>
    public class Leetcode_122_BestTimeToBuyAndSellStock_V1
    {
        public int FindMaxProfit(int[] values)
        {
            var maxProfit = 0;
            for (var index = 1; index < values.Length; index++)
            {
                if (values[index] > values[index - 1])
                {
                    maxProfit += values[index] - values[index - 1];
                }
            }
            return maxProfit;
        }
    }
}

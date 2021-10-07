using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_121_BestTimeToBuyAndSellStock
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public class Leetcode_121_BestTimeToBuyAndSellStock_V2
    {
        public int CalculateProfit(int[] values)
        {
            var maxProfit = 0;
            var min = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                var value = values[index];
                var currentProfit = value - min;
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }

                if (value < min)
                {
                    min = value;
                }
            }

            return maxProfit;
        }
    }
}

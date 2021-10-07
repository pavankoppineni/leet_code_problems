using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public class Leetcode_121_BestTimeToBuyAndSellStock_V1
    {
        public int GetMaxProfit(int[] values)
        {
            var maxProfit = 0;
            var currentMin = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                var currentValue = values[index];
                var currentProfit = currentValue - currentMin;
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }

                if (currentValue < currentMin)
                {
                    currentMin = currentValue;
                }
            }

            return maxProfit;
        }
    }
}

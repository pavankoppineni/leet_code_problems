using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_188_BestTimeToBuyAndSellStockIV
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv/
    /// </summary>
    public class Leetcode_188_BestTimeToBuyAndSellStockIV_V1
    {
        private int _tansactionCount;
        private int[] _values;
        private IDictionary<string, int> _lookup;
        public int CalculateMaximumProfit(int[] values, int k)
        {
            if(values.Length == 0)
            {
                return 0;
            }
            _tansactionCount = k;
            _values = values;
            var profit = int.MinValue;
            _lookup = new Dictionary<string, int>();
            for (var index = 0; index < _values.Length; index++)
            {
                var currentProfit = CalculateMaximumProfit(index, 0, 0, TransactionType.Sell);
                profit = Math.Max(profit, currentProfit);
            }
            return profit;
        }

        private int CalculateMaximumProfit(int index, int value, int sellCount, TransactionType transactionType)
        {
            var key = $"{index}_{transactionType}";
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }

            if (sellCount == _tansactionCount || index >= _values.Length)
            {
                return 0;
            }

            var profit = int.MinValue;
            if (transactionType == TransactionType.Buy)
            {
                var currentIndex = index;
                while (currentIndex < _values.Length)
                {
                    var currentProfit = _values[index] - value;
                    currentProfit += CalculateMaximumProfit(currentIndex + 1, 0, sellCount + 1, TransactionType.Sell);
                    profit = Math.Max(currentProfit, profit);
                    currentIndex++;
                }
            }
            else
            {
                var currentIndex = index;
                while (currentIndex < _values.Length)
                {
                    var currentProfit = CalculateMaximumProfit(currentIndex + 1, _values[currentIndex], sellCount, TransactionType.Buy);
                    profit = Math.Max(currentProfit, profit);
                    currentIndex++;
                }
                _lookup.Add(key, profit);
            }
            return profit;
        }
    }

    public enum TransactionType
    {
        Buy,
        Sell
    }
}

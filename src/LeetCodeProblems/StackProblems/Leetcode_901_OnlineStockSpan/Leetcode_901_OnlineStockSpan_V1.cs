using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StackProblems.Leetcode_901_OnlineStockSpan
{
    /// <summary>
    /// https://leetcode.com/problems/online-stock-span/
    /// </summary>
    public class Leetcode_901_OnlineStockSpan_V1
    {
        private IList<int> _values;
        public Leetcode_901_OnlineStockSpan_V1()
        {
            _values = new List<int>();
        }

        public int Next(int price)
        {
            _values.Add(price);
            var max = 0;
            var index = _values.Count - 1;
            while (index >= 0)
            {
                if (price >= _values[index])
                {
                    max += 1;
                    index--;
                }
                else
                {
                    break;
                }
            }
            return max;
        }
    }
}

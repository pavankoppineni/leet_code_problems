using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StackProblems.Leetcode_901_OnlineStockSpan
{
    /// <summary>
    /// https://leetcode.com/problems/online-stock-span/
    /// </summary>
    public class Leetcode_901_OnlineStockSpan_V2
    {
        private Stack<(int price, int index)> _values;
        private int _index;
        public Leetcode_901_OnlineStockSpan_V2()
        {
            _values = new Stack<(int price, int index)>();
            _index = -1;
        }

        public int Next(int price)
        {
            if (_index == -1)
            {
                _values.Push((price, 0));
                _index += 1;
                return 1;
            }

            _index += 1;
            var highestConsecutivePrice = 0;
            while (_values.Count > 0)
            {
                var topItem = _values.Peek();
                if (price > topItem.price)
                {
                    _values.Pop();
                    highestConsecutivePrice = _index - topItem.index;
                }
                else
                {
                    _values.Push((price, _index));
                    highestConsecutivePrice = _index - topItem.index;
                    break;
                }
            }

            return highestConsecutivePrice;
        }
    }
}

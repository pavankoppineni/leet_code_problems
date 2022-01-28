using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_983_MinimumCostForTickets
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-cost-for-tickets/
    /// </summary>
    public class Leetcode_983_MinimumCostForTickets_Recursion
    {
        private int[] _days;
        private int[] _costs;
        //private IDictionary<int, int> _table;
        public int CalculateMinimumCost(int[] days, int[] costs)
        {
            _days = days;
            _costs = costs;
            //_table = new Dictionary<int, int>();
            return CalculateMinimumCost(0, 0);
        }

        private int CalculateMinimumCost(int index, int cost)
        {
            //if (_table.ContainsKey(index))
            //{
            //    return _table[index];
            //}

            if (index < 0)
            {
                return cost;
            }

            if (index >= _days.Length)
            {
                return cost;
            }

            //One day pass
            var oneDayPass = CalculateMinimumCost(index + 1, cost);
            var oneDayPassCost = oneDayPass + _costs[0];

            //Seven day pass
            var sevenDayPassIndex = CalculateIndex(index + 1, _days.Length - 1, _days[index] + 7);
            var sevenDayPass = CalculateMinimumCost(sevenDayPassIndex, cost);
            var sevenDayPassCost = sevenDayPass + _costs[1];

            //Thirty day pass
            var thirtyDayPassIndex = CalculateIndex(index + 1, _days.Length - 1, _days[index] + 30);
            var thirtyDayPass = CalculateMinimumCost(thirtyDayPassIndex, cost);
            var thirtyDayPassCost = thirtyDayPass + _costs[2];

            //_table.Add(index, Math.Min(oneDayPassCost, Math.Min(sevenDayPassCost, thirtyDayPassCost)));
            //return _table[index];
            return Math.Min(thirtyDayPassCost, Math.Min(sevenDayPassCost, oneDayPassCost));
        }

        private int CalculateIndex(int start, int end, int value)
        {
            if (start > end)
            {
                return -1;
            }

            if (start == end)
            {
                if (_days[start] >= value)
                {
                    return start;
                }
                return -1;
            }

            var mid = start + ((end - start) >> 1);
            var midValue = _days[mid];
            //Case 1 : When mid is greater than or equal to value
            if (midValue >= value)
            {
                return CalculateIndex(start, mid, value);
            }
            //Case 2 : When mid is less than value
            else
            {
                return CalculateIndex(mid + 1, end, value);
            }
        }
    }
}

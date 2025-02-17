using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
    /// </summary>
    public class Leetcode_2260_MinimumConsecutiveCardsToPickUp_V1
    {
        public int CalculateMinimumConsecutiveCards(int[] values)
        {
            var minValue = int.MaxValue;
            var lookup = new Dictionary<int, int>();
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, index);
                    continue;
                }
                var prevIndex = lookup[value];
                var currentMin = index - prevIndex;
            }
            return minValue;
        }
    }
}

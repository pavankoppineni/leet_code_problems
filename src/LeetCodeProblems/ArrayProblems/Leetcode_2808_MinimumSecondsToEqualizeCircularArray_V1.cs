using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-seconds-to-equalize-a-circular-array/
    /// </summary>
    public class Leetcode_2808_MinimumSecondsToEqualizeCircularArray_V1
    {
        public int CalculateMinimumNumberOfSeconds(int[] values)
        {
            var minValue = int.MaxValue;
            var lookup = ConstructLookup(values);
            foreach (var lookUpItem in lookup)
            {
                var currentValue = CalculateMinimumSeconds(lookUpItem.Key, lookUpItem.Value, values.Length);
                minValue = Math.Min(minValue, currentValue);
            }
            return minValue;
        }

        private int CalculateMinimumSeconds(int key, IList<int> values, int length)
        {
            var maxValue = int.MinValue;
            for (var index = 1; index < values.Count; index++)
            {
                var current = values[index];
                var previous = values[index - 1];
                if (current - previous == 1)
                {
                    continue;
                }

                var diff = current - previous - 1;
                var currentValue = CalculateDiff(diff);
                maxValue = Math.Max(maxValue, currentValue);
            }

            var first = values[0];
            var last = values[values.Count - 1];
            var exclusion = length - (last - first + 1);
            var remainingValue = CalculateDiff(exclusion);
            return Math.Max(remainingValue, maxValue);

            static int CalculateDiff(int difference)
            {
                var reminder = difference / 2;
                return difference % 2 == 0 ? reminder : reminder + 1;
            }
        }

        private IDictionary<int, IList<int>> ConstructLookup(int[] values)
        {
            var index = 0;
            var lookup = new Dictionary<int, IList<int>>();
            foreach (var value in values)
            {
                if (!lookup.ContainsKey(value))
                {
                    lookup.Add(value, new List<int>());
                }
                lookup[value].Add(index);
                index += 1;
            }
            return lookup;
        }
    }
}

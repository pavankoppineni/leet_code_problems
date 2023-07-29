using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-index-of-a-valid-split/
    /// </summary>
    public class Leetcode_2780_MinimumIndexOfValidSplit_V1
    {
        public int CalculateMinimumIndex(IList<int> values)
        {
            var length = values.Count;
            var lookup = new Dictionary<int, int>();
            var prefixCountLookup = new Dictionary<int, int>();
            for (var index = 0; index < length; index++)
            {
                if (!lookup.ContainsKey(values[index]))
                {
                    lookup.Add(values[index], 0);
                }
                lookup[values[index]] += 1;
            }

            var minimumIndex = -1;
            for (var index = 0; index < length; index++)
            {
                var value = values[index];
                var totalCount = lookup[value];
                if (!prefixCountLookup.ContainsKey(value))
                {
                    prefixCountLookup.Add(value, 0);
                }
                prefixCountLookup[value] += 1;
                var leftFrequency = prefixCountLookup[value] * 2;
                var rightFrequency = (lookup[value] - prefixCountLookup[value]) * 2;
                if (leftFrequency > index + 1 && rightFrequency > (length - (index + 1)))
                {
                    minimumIndex = index;
                    break;
                }
            }
            return minimumIndex;
        }
    }
}

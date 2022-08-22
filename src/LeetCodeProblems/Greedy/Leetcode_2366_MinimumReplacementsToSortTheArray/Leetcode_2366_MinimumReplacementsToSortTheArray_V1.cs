using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_2366_MinimumReplacementsToSortTheArray
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-replacements-to-sort-the-array/
    /// </summary>
    public class Leetcode_2366_MinimumReplacementsToSortTheArray_V1
    {
        public int CalculateMinimumReplacements(int[] values)
        {
            if (values.Length == 1)
            {
                return 0;
            }

            var previous = values[values.Length - 1];
            var numberOfReplacements = 0;
            for (var index = values.Length - 2; index >= 0; index--)
            {
                if (previous >= values[index])
                {
                    previous = values[index];
                    continue;
                }

                var reminder = values[index] % previous;
                var quotient = values[index] / previous;
                if (reminder == 0)
                {
                    numberOfReplacements += quotient - 1;
                }
                else
                {
                    numberOfReplacements += quotient;
                    previous = reminder;
                }
            }
            return numberOfReplacements;
        }
    }
}

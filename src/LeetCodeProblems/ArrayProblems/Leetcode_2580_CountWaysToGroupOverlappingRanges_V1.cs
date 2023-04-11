using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-ways-to-group-overlapping-ranges/
    /// </summary>
    public class Leetcode_2580_CountWaysToGroupOverlappingRanges_V1
    {
        public int CountWays(int[][] ranges)
        {
            var rangeList = new Range[ranges.Length];
            for (var index = 0; index < ranges.Length; index++)
            {
                rangeList[index] = new Range(ranges[index][0], ranges[index][1]);
            }
            Array.Sort(rangeList, Range.Comparer);

            var mergedRanges = new List<Range>();
            var previousRange = rangeList[0];
            for (var index = 1; index < ranges.Length; index++)
            {
                var currentRange = rangeList[index];
                if (previousRange.End >= currentRange.Start)
                {
                    previousRange.End = Math.Max(previousRange.End, currentRange.End);
                }
                else
                {
                    mergedRanges.Add(previousRange);
                    previousRange = currentRange;
                }
            }
            mergedRanges.Add(previousRange);
            var denominator = Math.Pow(10, 9) + 7;
            var numberOfWays = Math.Pow(2, mergedRanges.Count);
            return (int)(numberOfWays % denominator);
        }
    }

    public class Range : IComparer<Range>
    {
        public static IComparer<Range> Comparer = new Range();
        public Range() { }
        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }
        public int Start { get; set; }
        public int End { get; set; }

        public int Compare(Range x, Range y)
        {
            if (x.Start == y.Start)
            {
                return x.End.CompareTo(y.End);
            }
            return x.Start.CompareTo(y.Start);
        }
    }
}

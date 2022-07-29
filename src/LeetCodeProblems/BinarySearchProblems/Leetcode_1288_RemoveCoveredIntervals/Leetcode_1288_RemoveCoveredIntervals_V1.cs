using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_1288_RemoveCoveredIntervals
{
    /// <summary>
    /// https://leetcode.com/problems/remove-covered-intervals/
    /// </summary>
    public class Leetcode_1288_RemoveCoveredIntervals_V1
    {
        private IList<Interval> _intervals;
        public int CalculateCoveredIntervals(int[][] intervals)
        {
            var intervalLookup = new Dictionary<int, int>();
            foreach (var interval in intervals)
            {
                var start = interval[0];
                var end = interval[1];
                if (intervalLookup.ContainsKey(start))
                {
                    var max = Math.Max(end, intervalLookup[start]);
                    intervalLookup[start] = max;
                }
                else
                {
                    intervalLookup.Add(start, end);
                }
            }

            var intervalList = new List<Interval>();
            foreach (var interval in intervalLookup)
            {
                intervalList.Add(new Interval(interval.Key, interval.Value));
            }
            intervalList.Sort(Interval.Comparison);
            _intervals = intervalList;
            var count = 0;
            var index = 0;
            while (index < _intervals.Count)
            {
                var endIndex = FindCoveredInterval(_intervals[index], index, _intervals.Count - 1, -1);
                if (index == endIndex)
                {
                    index++;
                }
                else
                {
                    index = endIndex + 1;
                }
                count++;
            }
            return count;
        }

        private int FindCoveredInterval(Interval interval, int start, int end, int endIndex)
        {
            if (start > end)
            {
                return endIndex;
            }

            var mid = start + (end - start) / 2;

            if (interval.End < _intervals[mid].Start)
            {
                return FindCoveredInterval(interval, start, mid - 1, endIndex);
            }
            return 1;
        }

        public class Interval
        {
            public Interval(int start, int end)
            {
                Start = start;
                End = end;
            }
            public int Start { get; set; }
            public int End { get; set; }

            public static int Comparison(Interval one, Interval two)
            {
                var result = one.End.CompareTo(two.End);
                if (result == 0)
                {
                    return one.Start.CompareTo(two.Start);
                }
                return result;
            }
        }
    }
}

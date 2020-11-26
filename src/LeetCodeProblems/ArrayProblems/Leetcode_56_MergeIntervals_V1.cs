using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/merge-intervals/
    /// </summary>
    public class Leetcode_56_MergeIntervals_V1
    {
        private int[][] intervals;
        public int[][] Merge(int[][] intervals)
        {
            this.intervals = intervals;
            Array.Sort(this.intervals, IntervalComparer.Comparer);

            var previousStartInterval = intervals[0][0];
            var previousEndInterval = intervals[0][1];

            var mergedIntervals = new List<int[]>();

            var currentIndex = 1;
            while (currentIndex < intervals.Length)
            {
                var currentStartInterval = intervals[currentIndex][0];
                var currentEndInterval = intervals[currentIndex][1];

                //Case  1 : Previous end interval is less than current start interval
                if (previousEndInterval < currentStartInterval)
                {
                    mergedIntervals.Add(new int[] { previousStartInterval, previousEndInterval });
                    previousStartInterval = currentStartInterval;
                    previousEndInterval = currentEndInterval;
                    currentIndex += 1;
                }
                // Case 2 : Previous end interval is greater than or equal to start interval
                else
                {
                    previousEndInterval = Math.Max(previousEndInterval, currentEndInterval);
                    currentIndex += 1;
                }
            }

            mergedIntervals.Add(new int[] { previousStartInterval, previousEndInterval });


            return mergedIntervals.ToArray();
        }

        public class IntervalComparer : IComparer<int[]>
        {
            public static IntervalComparer Comparer = new IntervalComparer();

            public int Compare(int[] x, int[] y)
            {
                return x[0].CompareTo(y[0]);
            }
        }
    }
}

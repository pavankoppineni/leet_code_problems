using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/insert-interval/
    /// </summary>
    public class LeetCode_57_InsertInterval_V1
    {
        private int[][] intervals;
        private int length;

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            this.intervals = intervals;
            this.length = this.intervals.Length;

            if (newInterval[0] > this.intervals[length - 1][1])
            {
                return InsertNewIntervalOutSideIntervals(newInterval, false);
            }
            else if (newInterval[1] < this.intervals[0][0])
            {
                return InsertNewIntervalOutSideIntervals(newInterval, true);
            }
            else if (newInterval[0] <= this.intervals[0][0] && newInterval[1] >= this.intervals[length - 1][1])
            {
                var mergedIntervals = new int[1][];
                mergedIntervals[0] = newInterval;
                return mergedIntervals;
            }
            else
            {
                var startIndex = FindIndex(0, length - 1, newInterval[0]);
                var endIndex = FindIndex(0, length - 1, newInterval[1]);

                if (endIndex.index == -1)
                {
                    var mergedIntervals = AppendIndervals(0, startIndex.index);
                    var minInterval = Math.Min(newInterval[0], intervals[startIndex.index][0]);
                    mergedIntervals.Add(new int[] { minInterval, newInterval[1] });
                    return mergedIntervals.ToArray();
                }

                if (startIndex.isInside)
                {
                    if (endIndex.isInside)
                    {
                        var mergedleftIntervals = AppendIndervals(0, startIndex.index);
                        mergedleftIntervals.Add(new int[] { intervals[startIndex.index][0], intervals[endIndex.index][1] });
                        var mergedRightIntervals = AppendIndervals(endIndex.index + 1, length);
                        mergedleftIntervals.AddRange(mergedRightIntervals);
                        return mergedleftIntervals.ToArray();
                    }
                    else
                    {
                        var mergedleftIntervals = AppendIndervals(0, startIndex.index);
                        mergedleftIntervals.Add(new int[] { intervals[startIndex.index][0], newInterval[1] });
                        var mergedRightIntervals = AppendIndervals(endIndex.index, length);
                        mergedleftIntervals.AddRange(mergedRightIntervals);
                        return mergedleftIntervals.ToArray();
                    }
                }
                else
                {
                    if (endIndex.isInside)
                    {
                        var mergedLeftIntervals = AppendIndervals(0, startIndex.index);
                        mergedLeftIntervals.Add(new int[] { newInterval[0], intervals[endIndex.index][1] });
                        var mergedRightIntervals = AppendIndervals(endIndex.index + 1, length);
                        mergedLeftIntervals.AddRange(mergedRightIntervals);
                        return mergedLeftIntervals.ToArray();
                    }
                    else
                    {
                        var mergedLeftIntervals = AppendIndervals(0, startIndex.index);
                        mergedLeftIntervals.Add(newInterval);
                        var mergedRightIntervals = AppendIndervals(endIndex.index, length);
                        mergedLeftIntervals.AddRange(mergedRightIntervals);
                        return mergedLeftIntervals.ToArray();
                    }
                }
            }
        }

        private List<int[]> AppendIndervals(int startInclusive, int endExclusive)
        {
            var mergedIntervals = new List<int[]>();
            while (startInclusive < endExclusive)
            {
                mergedIntervals.Add(new int[] { intervals[startInclusive][0], intervals[startInclusive][1] });
                startInclusive += 1;
            }

            return mergedIntervals;
        }

        private int[][] InsertNewIntervalOutSideIntervals(int[] newInterval, bool addFirst)
        {
            var mergedIntervals = new List<int[]>();
            if (addFirst)
            {
                mergedIntervals.Add(newInterval);
                mergedIntervals.AddRange(intervals);
            }
            else
            {
                mergedIntervals.AddRange(intervals);
                mergedIntervals.Add(newInterval);
            }

            return mergedIntervals.ToArray();
        }

        private (int index, bool isInside) FindIndex(int start, int end, int value)
        {
            if(start == end)
            {
                if (value < intervals[start][0])
                {
                    return (start, false);
                }
                else if (value <= intervals[start][1])
                {
                    return (start, true);
                }
                else
                {
                    return (-1, false);
                }
            }

            if (start > end)
            {
                return (-1, false);
            }

            var mid = (start + end) >> 1;

            if (value < intervals[mid][0])
            {
                return FindIndex(start, mid, value);
            }
            
            if(value > intervals[mid][1])
            {
                return FindIndex(mid + 1, end, value);
            }

            return (mid, true);
        }
    }
}

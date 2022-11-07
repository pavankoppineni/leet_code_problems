using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-profit-in-job-scheduling/
    /// </summary>
    public class Leetcode_1235_MaximumProfitInJobScheduling_V1
    {
        private Job[] _jobs;
        public int CalculateMaximumProfit(int[] startTimes, int[] endTimes, int[] profits)
        {
            throw new NotImplementedException();
        }

        private int CalculateMaximumProfit(int start, int end)
        {
            throw new NotImplementedException();
        }

        private int SearchNextJob(int startIndex, int endIndex, int value)
        {
            throw new NotImplementedException();
        }
    }

    public class Job : IComparer<Job>
    {
        private Job() { }
        public static IComparer<Job> Comparer = new Job();
        public Job(int startTime, int endTime, int profit)
        {
            StartTime = startTime;
            EndTime = endTime;
            Profit = profit;
        }

        public int StartTime { get; }
        public int EndTime { get; }
        public int Profit { get; }

        public int Compare(Job x, Job y)
        {
            if (x.StartTime == y.StartTime)
            {
                return x.EndTime.CompareTo(y.EndTime);
            }
            return x.StartTime.CompareTo(y.StartTime);
        }
    }
}

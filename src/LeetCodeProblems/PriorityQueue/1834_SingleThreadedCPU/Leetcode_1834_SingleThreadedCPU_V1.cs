using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.PriorityQueue._1834_SingleThreadedCPU
{
    /// <summary>
    /// https://leetcode.com/problems/single-threaded-cpu/
    /// </summary>
    public class Leetcode_1834_SingleThreadedCPU_V1
    {
        public int[] GetOrder(int[][] tasks)
        {
            Array.Sort(tasks, TasksComparer.Default);
            return null;
        }
    }

    public class TasksComparer : IComparer<int[]>
    {
        public static IComparer<int[]> Default = new TasksComparer();
        public int Compare(int[] x, int[] y)
        {
            var processingTime = x[1].CompareTo(y[1]);
            if (x[1].CompareTo(y[1]) == 0)
            {
                return x[0].CompareTo(y[0]);
            }
            return processingTime;
        }
    }
}

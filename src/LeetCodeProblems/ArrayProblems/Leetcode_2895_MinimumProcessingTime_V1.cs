using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-processing-time/
    /// </summary>
    public class Leetcode_2895_MinimumProcessingTime_V1
    {
        public int CalculateMinimumProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            processorTime = processorTime.OrderBy(x => x).ToList();
            tasks = tasks.OrderBy(x => x).ToList();
            var minimumTime = int.MinValue;
            var currentTaskIndex = tasks.Count - 1;
            for (var index = 0; index < processorTime.Count; index++)
            {
                minimumTime = Math.Max(processorTime[index] + tasks[currentTaskIndex], minimumTime);
                currentTaskIndex = currentTaskIndex - 4;
            }
            return minimumTime;
        }
    }
}

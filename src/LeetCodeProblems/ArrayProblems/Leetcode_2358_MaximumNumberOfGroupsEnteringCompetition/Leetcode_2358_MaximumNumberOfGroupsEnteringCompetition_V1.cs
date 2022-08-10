using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2358_MaximumNumberOfGroupsEnteringCompetition
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-groups-entering-a-competition/
    /// </summary>
    public class Leetcode_2358_MaximumNumberOfGroupsEnteringCompetition_V1
    {
        public int MaxGroups(int[] values)
        {
            Array.Sort(values);
            var count = 1;
            var previousSum = values[0];
            var previousCount = 1;
            var currentCount = 0;
            var currentSum = 0;
            for (var index = 1; index < values.Length; index++)
            {
                if (currentSum + values[index] > previousSum && currentCount + 1 > previousCount)
                {
                    previousSum = currentSum + values[index];
                    previousCount = currentCount + 1;
                    count++;
                    currentCount = 0;
                    currentSum = 0;
                }
                else
                {
                    currentSum += values[index];
                    currentCount += 1;
                }
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/partition-string-into-substrings-with-values-at-most-k/
    /// </summary>
    public class Leetcode_2522_PartitionStringIntoSubstringsWithValuesAtMostK_V1
    {
        public int CalculateMinimumPartitions(string str, int k)
        {
            var numberOfPartions = 0;
            long previousValue = 0;
            foreach (var item in str)
            {
                var value = item - '0';
                if (value > k)
                {
                    return -1;
                }
                long currentValue = previousValue * 10 + value;
                if (currentValue > k)
                {
                    numberOfPartions += 1;
                    previousValue = value;
                }
                else
                {
                    previousValue = currentValue;
                }
            }
            return numberOfPartions + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_2405_OptimalPartitionOfString
{
    /// <summary>
    /// https://leetcode.com/contest/weekly-contest-310/problems/optimal-partition-of-string/
    /// </summary>
    public class Leetcode_2405_OptimalPartitionOfString_V1
    {
        public int CalculatePartitions(string str)
        {
            var numberOfPartitions = 0;
            var lookup = new HashSet<char>();
            foreach (var c in str)
            {
                if (lookup.Contains(c))
                {
                    numberOfPartitions++;
                    lookup.Clear();
                    lookup.Add(c);
                }
                else
                {
                    lookup.Add(c);
                }
            }
            if(lookup.Count > 0)
            {
                numberOfPartitions += 1;
            }
            return numberOfPartitions;
        }
    }
}

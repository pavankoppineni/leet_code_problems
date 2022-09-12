using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_763_PartitionLabels
{
    /// <summary>
    /// https://leetcode.com/problems/partition-labels/
    /// </summary>
    public class Leetcode_763_PartitionLabels_V1
    {
        public IList<int> GeneratePartitions(string str)
        {
            var lookup = new Dictionary<char, Range>();
            for (var index = 0; index < str.Length; index++)
            {
                if (lookup.ContainsKey(str[index]))
                {
                    lookup[str[index]].End = index;
                }
                else
                {
                    lookup.Add(str[index], new Range(index));
                }
            }
            if (lookup.Count == 1)
            {
                return new[] { str.Length };
            }

            var partitions = new List<int>();
            var ranges = lookup.Values.ToArray();
            var start = ranges[0].Start;
            var end = ranges[0].End;
            for (var index = 1; index < ranges.Length; index++)
            {
                if (ranges[index].Start > end)
                {
                    partitions.Add(end - start + 1);
                    start = ranges[index].Start;
                    end = ranges[index].End;    
                }
                else if (ranges[index].End > end)
                {
                    end = ranges[index].End;
                }
            }
            partitions.Add(end - start + 1);
            return partitions;
        }
    }

    public class Range
    {
        public Range(int position)
        {
            this.Start = position;
            this.End = position;
        }
        public int Start { get; set; }
        public int End { get; set; }
    }
}

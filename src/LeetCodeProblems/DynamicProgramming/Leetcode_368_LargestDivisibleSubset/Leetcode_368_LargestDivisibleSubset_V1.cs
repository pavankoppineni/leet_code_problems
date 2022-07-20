using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_368_LargestDivisibleSubset
{
    /// <summary>
    /// https://leetcode.com/problems/largest-divisible-subset/
    /// </summary>
    public class Leetcode_368_LargestDivisibleSubset_V1
    {
        public IList<int> FindLargestDivisibleSubset(int[] values)
        {
            Array.Sort(values);
            var subsets = new List<int>[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                subsets[index] = new List<int>() { values[index] };
            }

            for (var index = 1; index < subsets.Length; index++)
            {
                List<int> subset = null;
                var previousIndex = index - 1;
                while (previousIndex >= 0)
                {
                    if (values[index] % values[previousIndex] == 0)
                    {
                        if (subset == null)
                        {
                            subset = subsets[previousIndex];
                        }
                        if (subsets[previousIndex].Count > subset.Count)
                        {
                            subset = subsets[previousIndex];
                        }
                    }
                    previousIndex--;
                }
                if (subset == null)
                {
                    continue;
                }
                subsets[index].AddRange(subset);
            }

            var maxSubset = subsets[0];
            foreach (var subset in subsets)
            {
                if (subset.Count > maxSubset.Count)
                {
                    maxSubset = subset;
                }
            }
            return maxSubset;
        }
    }
}

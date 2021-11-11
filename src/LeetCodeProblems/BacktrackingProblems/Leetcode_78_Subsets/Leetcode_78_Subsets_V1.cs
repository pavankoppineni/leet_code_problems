using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    public class Leetcode_78_Subsets_V1
    {
        private int[] values;
        private IList<IList<int>> subsets;

        public IList<IList<int>> GenerateSubsets(int[] values)
        {
            this.values = values;
            subsets = new List<IList<int>>();
            var subset = new Stack<int>();
            GenerateSubsets(0, subset);
            return subsets;
        }

        private void GenerateSubsets(int index, Stack<int> subset)
        {
            if (index == values.Length)
            {
                subsets.Add(subset.ToArray());
                return;
            }

            GenerateSubsets(index + 1, subset);
            subset.Push(values[index]);
            GenerateSubsets(index + 1, subset);
            subset.Pop();
        }
    }
}

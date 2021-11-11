using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    public class Leetcode_78_Subsets_V2
    {
        private IList<IList<int>> subsets;
        private int[] values;
        public IList<IList<int>> GenerateSubsets(int[] values)
        {
            this.values = values;
            subsets = new List<IList<int>>();
            var subset = new Stack<int>();
            GenerateSubsets(0, subset);
            return subsets;
        }

        private void GenerateSubsets(int index, Stack<int> stack)
        {
            if (index == values.Length)
            {
                subsets.Add(stack.ToArray());
                return;
            }
            GenerateSubsets(index + 1, stack);
            stack.Push(values[index]);
            GenerateSubsets(index + 1, stack);
            stack.Pop();
        }
    }
}

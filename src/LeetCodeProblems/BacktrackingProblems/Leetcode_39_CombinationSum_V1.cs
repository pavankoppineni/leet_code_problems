using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum/
    /// </summary>
    public class Leetcode_39_CombinationSum_V1
    {
        private int[] values;
        private IList<IList<int>> combinations;

        public IList<IList<int>> FindCombinations(int[] values, int sum)
        {
            combinations = new List<IList<int>>();
            this.values = values;
            var combination = new Stack<int>();
            FindCombinations(0, combination, sum);
            return combinations;
        }

        private void FindCombinations(int index, Stack<int> combination, int sum)
        {
            if(sum == 0)
            {
                this.combinations.Add(combination.ToArray());
                return;
            }

            if (sum < 0)
            {
                return;
            }

            for (var currentIndex = index; currentIndex < values.Length; currentIndex++)
            {
                combination.Push(values[currentIndex]);
                FindCombinations(currentIndex, combination, sum - values[currentIndex]);
                combination.Pop();
            }
        }
    }
}

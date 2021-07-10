using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum-iii/
    /// </summary>
    public class Leetcode_216_CombinationSumIII_V1
    {
        private IList<IList<int>> combinations;
        private Stack<int> combination;
        private int len;
        public IList<IList<int>> FindValidCombinations(int k, int sum)
        {
            len = k;
            combinations = new List<IList<int>>();
            combination = new Stack<int>();
            FindValidCombinations(0, 1, sum);
            return combinations;
        }

        private void FindValidCombinations(int index, int k, int sum)
        {
            if (index == len)
            {
                if (sum == 0)
                {
                    combinations.Add(combination.ToArray());
                    return;
                }
                else
                {
                    return;
                }
            }

            if (sum < 0)
            {
                return;
            }

            for (var i = k; i <= 9; i++)
            {
                combination.Push(i);
                FindValidCombinations(index + 1, i + 1, sum - i);
                combination.Pop();
            }
        }
    }
}

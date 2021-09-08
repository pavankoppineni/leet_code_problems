using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum/
    /// </summary>
    public class Leetcode_39_CombinationSum_V2
    {
        private int[] _values;
        private IList<IList<int>> _combinations;
        public IList<IList<int>> CalculateCombinationSum(int[] values, int sum)
        {
            _values = values;
            _combinations = new List<IList<int>>();
            GenerateCombinationSum(sum, 0, new Stack<int>());
            return _combinations;
        }

        private void GenerateCombinationSum(int sum, int index, Stack<int> combination)
        {
            if(sum < 0)
            {
                return;
            }
            if(sum == 0)
            {
                _combinations.Add(combination.ToArray());
                return;
            }

            for (var currentIndex = index; currentIndex < _values.Length; currentIndex++)
            {
                var remaining = sum - _values[currentIndex];
                combination.Push(_values[currentIndex]);
                GenerateCombinationSum(remaining, currentIndex, combination);
                combination.Pop();
            }
        }
    }
}

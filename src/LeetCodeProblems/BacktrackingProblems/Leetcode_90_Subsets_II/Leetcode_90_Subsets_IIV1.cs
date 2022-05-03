using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_90_Subsets_II
{
    /// <summary>
    /// https://leetcode.com/problems/subsets-ii/
    /// </summary>
    public class Leetcode_90_Subsets_IIV1
    {
        private IDictionary<int, int> _valueLookup;
        private IList<int> _values;
        private IList<IList<int>> _subsets;
        public IList<IList<int>> GenerateSubsets(int[] values)
        {
            _subsets = new List<IList<int>>();
            _valueLookup = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (_valueLookup.ContainsKey(value))
                {
                    _valueLookup[value]++;
                }
                else
                {
                    _valueLookup[value] = 1;
                }
            }
            _values = _valueLookup.Keys.ToList();
            GenerateSubsets(0, new Stack<int>());
            return _subsets;
        }

        private void GenerateSubsets(int index, Stack<int> stack)
        {
            if (index >= _values.Count)
            {
                _subsets.Add(stack.ToList());
                return;
            }
            GenerateSubsets(index + 1, stack);
            var value = _values[index];
            for (var count = 0; count < _valueLookup[value]; count++)
            {
                stack.Push(value);
                GenerateSubsets(index + 1, stack);
            }
            for (var count = 0; count < _valueLookup[value]; count++)
            {
                stack.Pop();
            }
        }
    }
}

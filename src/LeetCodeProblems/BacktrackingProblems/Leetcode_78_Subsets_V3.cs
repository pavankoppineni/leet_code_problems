using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/subsets/
    /// </summary>
    public class Leetcode_78_Subsets_V3
    {
        private Stack<int> _currentStack;
        private int[] _values;
        private IList<IList<int>> _subsets;
        public IList<IList<int>> GenerateSubsets(int[] values)
        {
            _currentStack = new Stack<int>();
            _values = values;
            _subsets = new List<IList<int>>();
            GenerateSubsets(0);
            return _subsets;
        }

        private void GenerateSubsets(int index)
        {
            if (index == _values.Length)
            {
                _subsets.Add(_currentStack.ToArray());
                return;
            }
            GenerateSubsets(index + 1);
            _currentStack.Push(_values[index]);
            GenerateSubsets(index + 1);
            _currentStack.Pop();
        }
    }
}

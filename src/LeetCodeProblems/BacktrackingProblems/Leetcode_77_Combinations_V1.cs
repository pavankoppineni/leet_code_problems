using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/combinations/
    /// </summary>
    public class Leetcode_77_Combinations_V1
    {
        private IList<IList<int>> _combinations;
        private int _size;
        private int _upperBound;
        public IList<IList<int>> GenerateCombinations(int n, int k)
        {
            _size = k;
            _upperBound = n;
            _combinations = new List<IList<int>>();
            GenerateCombinations(new Stack<int>(), 0, 1);
            return _combinations;
        }

        private void GenerateCombinations(Stack<int> stack, int level, int i)
        {
            if (level == _size)
            {
                _combinations.Add(stack.ToArray());
                return;
            }
            for (var index = i; index <= _upperBound; index++)
            {
                stack.Push(index);
                GenerateCombinations(stack, level + 1, index + 1);
                stack.Pop();
            }
        }
    }
}

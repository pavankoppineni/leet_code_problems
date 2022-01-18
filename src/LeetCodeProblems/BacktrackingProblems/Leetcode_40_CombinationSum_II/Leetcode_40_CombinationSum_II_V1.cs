using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_40_CombinationSum_II
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum-ii/
    /// </summary>
    public class Leetcode_40_CombinationSum_II_V1
    {
        private IDictionary<int, int> _table;
        private IList<IList<int>> _items;
        private Stack<int> _stack;
        private int[] _keys;
        private int[] _countArray;
        private int _length;
        public IList<IList<int>> GenerateCombinations(int[] candidates, int target)
        {
            _stack = new Stack<int>();
            _items = new List<IList<int>>();
            _table = new Dictionary<int, int>();
            foreach (var candidate in candidates)
            {
                if (_table.ContainsKey(candidate))
                {
                    _table[candidate] += 1;
                }
                else
                {
                    _table.Add(candidate, 1);
                }
            }
            _keys = _table.Keys.ToArray();
            _countArray = _table.Values.ToArray();
            _length = _keys.Length;
            GenerateCombinations(0, target);
            return _items;
        }

        private void GenerateCombinations(int index, int target)
        {
            if (index >= _length)
            {
                return;
            }
            if (target == 0)
            {
                _items.Add(_stack.ToArray());
                return;
            }
            if (target < 0)
            {
                return;
            }
            var count = _countArray[index];
            GenerateCombinations(index + 1, target);

            if (count > 0)
            {
                var value = _keys[index];
                _countArray[index] -= 1;
                _stack.Push(value);
                GenerateCombinations(index, target - value);
                _countArray[index] += 1;
                _stack.Pop();
            }
        }
    }
}

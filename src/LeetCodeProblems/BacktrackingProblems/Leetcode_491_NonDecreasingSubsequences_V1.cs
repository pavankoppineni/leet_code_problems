using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/non-decreasing-subsequences/
    /// </summary>
    public class Leetcode_491_NonDecreasingSubsequences_V1
    {
        private int[] _nums;
        private IList<IList<int>> _subsequences;
        private HashSet<string> _lookup;
        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            _subsequences = new List<IList<int>>();
            _nums = nums;
            _lookup = new HashSet<string>();
            var stack = new Stack<int>();
            for (var index = 0; index < _nums.Length; index++)
            {
                stack.Push(_nums[index]);
                FindSubsequences(index + 1, stack, _nums[index], _nums[index].ToString());
                stack.Pop();
            }
            return _subsequences;
        }

        private void FindSubsequences(int index, Stack<int> stack, int previous, string lookupItem)
        {
            if (index >= _nums.Length)
            {
                return;
            }

            for (; index < _nums.Length; index++)
            {
                if (_nums[index] >= previous)
                {
                    var newLookupItem = $"{lookupItem}-{_nums[index]}";
                    stack.Push(_nums[index]);
                    if (!_lookup.Contains(newLookupItem))
                    {
                        _lookup.Add(newLookupItem);
                        var sequence = stack.ToArray();
                        Array.Reverse(sequence);
                        _subsequences.Add(sequence);
                    }
                    FindSubsequences(index + 1, stack, _nums[index], newLookupItem);
                    stack.Pop();
                }
            }
        }
    }
}

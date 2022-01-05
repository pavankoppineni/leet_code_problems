using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_96_UniqueBinarySearchTrees
{
    /// <summary>
    /// https://leetcode.com/problems/unique-binary-search-trees/
    /// </summary>
    public class Leetcode_96_UniqueBinarySearchTrees_V1
    {
        private IDictionary<int, int> _table;
        public int CreateUniqueBinarySearchTrees(int number)
        {
            _table = new Dictionary<int, int>();
            return CreateUniqueBinarySearchTrees(1, number);
        }

        private int CreateUniqueBinarySearchTrees(int startExclusive, int endExclusive)
        {
            if (endExclusive < startExclusive)
            {
                return 1;
            }
            var diff = endExclusive - startExclusive;
            if (_table.ContainsKey(diff))
            {
                return _table[diff];
            }
            var nodes = 0;
            for (int i = startExclusive; i <= endExclusive; i++)
            {
                var leftNodes = CreateUniqueBinarySearchTrees(startExclusive, i - 1);
                var rightNodes = CreateUniqueBinarySearchTrees(i + 1, endExclusive);
                nodes += leftNodes * rightNodes;
            }
            _table.Add(diff, nodes);
            return nodes;
        }
    }
}

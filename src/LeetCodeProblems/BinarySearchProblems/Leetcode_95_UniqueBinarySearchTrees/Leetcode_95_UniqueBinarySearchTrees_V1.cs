using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_95_UniqueBinarySearchTrees
{
    /// <summary>
    /// https://leetcode.com/problems/unique-binary-search-trees-ii/
    /// </summary>
    public class Leetcode_95_UniqueBinarySearchTrees_V1
    {
        public IList<Node95> CreateUniqueBinarySearchTrees(int number)
        {
            return CreateUniqueBinarySearchTrees(1, number);
        }

        private IList<Node95> CreateUniqueBinarySearchTrees(int startExclusive, int endExclusive)
        {
            if (endExclusive < startExclusive)
            {
                return null;
            }
            var nodes = new List<Node95>();
            for (int i = startExclusive; i <= endExclusive; i++)
            {
                var leftNodes = CreateUniqueBinarySearchTrees(startExclusive, i - 1);
                var rightNodes = CreateUniqueBinarySearchTrees(i + 1, endExclusive);
            }
            return nodes;
        }
    }

    public class Node95
    {
        public int Value { get; set; }
        public Node95 Left { get; set; }
        public Node95 Right { get; set; }
    }
}

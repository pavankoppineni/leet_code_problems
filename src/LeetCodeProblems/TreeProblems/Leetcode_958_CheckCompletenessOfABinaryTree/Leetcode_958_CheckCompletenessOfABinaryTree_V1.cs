using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_958_CheckCompletenessOfABinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/check-completeness-of-a-binary-tree/
    /// </summary>
    public class Leetcode_958_CheckCompletenessOfABinaryTree_V1
    {
        private IDictionary<int, List<Node958_V1>> _levels;
        public bool IsCompleteTree(Node958_V1 node)
        {
            throw new NotImplementedException();
        }

        private int CalculateHeight(Node958_V1 node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftHeight = CalculateHeight(node.Left);
            var rightHeight = CalculateHeight(node.Right);
            return 1 + Math.Max(leftHeight, rightHeight);
        }

        private void InorderTraversal(Node958_V1 node, int level)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.Left, level + 1);
            _levels[level].Add(node);
            InorderTraversal(node.Right, level + 1);
        }
    }

    public class Node958_V1
    {
        public Node958_V1 Left { get; set; }
        public Node958_V1 Right { get; set; }
        public int Value { get; set; }
    }
}

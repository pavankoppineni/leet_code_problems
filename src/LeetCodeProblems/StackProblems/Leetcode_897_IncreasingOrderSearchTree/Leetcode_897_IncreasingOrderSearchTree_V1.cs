using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StackProblems.Leetcode_897_IncreasingOrderSearchTree
{
    /// <summary>
    /// https://leetcode.com/problems/increasing-order-search-tree/
    /// </summary>
    public class Leetcode_897_IncreasingOrderSearchTree_V1
    {
        public TreeNode IncreasingBST(TreeNode node)
        {
            var stack = new Stack<TreeNode>();
            stack = PostOrder(node, stack);
            var root = stack.Pop();
            var currentRoot = root;
            while (stack.Count > 0)
            {
                currentRoot.right = stack.Pop();
                currentRoot = currentRoot.right;
            }
            return root;
        }

        private Stack<TreeNode> PostOrder(TreeNode node, Stack<TreeNode> stack)
        {
            if (node == null)
            {
                return stack;
            }
            PostOrder(node.right, stack);
            stack.Push(node);
            PostOrder(node.left, stack);
            return stack;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
        }
    }
}

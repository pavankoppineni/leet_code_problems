using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/invert-binary-tree/
    /// </summary>
    public class Leetcode_226_InvertBinaryTree_V1
    {
        public TreeNode InvertBinaryTree(TreeNode rootNode)
        {
            PostOrderTraversal(rootNode);
            return rootNode;
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            var tempLeft = node.Left;
            node.Left = node.Right;
            node.Right = tempLeft;
        }
    }
}

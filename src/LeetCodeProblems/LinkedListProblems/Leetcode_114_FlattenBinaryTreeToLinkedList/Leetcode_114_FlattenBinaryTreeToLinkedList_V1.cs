using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedListProblems.Leetcode_114_FlattenBinaryTreeToLinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
    /// </summary>
    public class Leetcode_114_FlattenBinaryTreeToLinkedList_V1
    {
        public TreeNode Flatten(TreeNode treeNode)
        {
            PreOrderTraversal(treeNode);
            return treeNode;
        }

        private TreeNode PreOrderTraversal(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            var leftNode = PreOrderTraversal(node.left);
            var rightNode = PreOrderTraversal(node.right);
            var currentNode = node;
            while (leftNode != null)
            {
                currentNode.right = leftNode;
                currentNode = leftNode;
                leftNode = leftNode.right;
            }
            while (rightNode != null)
            {
                currentNode.right = rightNode;
                currentNode = rightNode;
                rightNode = rightNode.right;
            }
            node.left = null;
            return node;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
    }
}

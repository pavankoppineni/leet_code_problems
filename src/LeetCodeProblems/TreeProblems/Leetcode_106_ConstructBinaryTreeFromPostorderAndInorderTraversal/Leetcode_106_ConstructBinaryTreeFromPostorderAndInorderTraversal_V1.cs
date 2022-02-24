using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_106_ConstructBinaryTreeFromPostorderAndInorderTraversal
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    /// </summary>
    public class Leetcode_106_ConstructBinaryTreeFromPostorderAndInorderTraversal_V1
    {
        private IDictionary<int, int> _indexTable;
        private int[] _postorder, _inorder;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            _postorder = postorder;
            _inorder = inorder;
            _indexTable = new Dictionary<int, int>();

            for (var index = 0; index < inorder.Length; index++)
            {
                _indexTable[inorder[index]] = index;
            }

            return BuildTree(0, _inorder.Length - 1, _postorder.Length - 1);
        }

        private TreeNode BuildTree(int start, int end, int postOrderIndex)
        {
            if(postOrderIndex < 0 || postOrderIndex >= _postorder.Length)
            {
                return null;
            }
            if (start > end)
            {
                return null;
            }

            var node = new TreeNode
            {
                val = _postorder[postOrderIndex]
            };
            var inorderIndex = _indexTable[node.val];
            var rightTreeNodesCount = end - inorderIndex + 1;
            node.left = BuildTree(start, inorderIndex - 1, postOrderIndex - rightTreeNodesCount);
            node.right = BuildTree(inorderIndex + 1, end, postOrderIndex - 1);
            return node;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode right;
        public TreeNode left;
    }
}

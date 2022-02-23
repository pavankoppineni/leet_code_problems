using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_105_ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    /// </summary>
    public class Leetcode_105_ConstructBinaryTreeFromPreorderAndInorderTraversal_V1
    {
        private IDictionary<int, int> _indexTable;
        private int[] _preorder, _inorder;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            _preorder = preorder;
            _inorder = inorder;
            _indexTable = new Dictionary<int, int>();

            for (var index = 0; index < inorder.Length; index++)
            {
                _indexTable[inorder[index]] = index;
            }

            return BuildTree(0, _inorder.Length - 1, 0);
        }

        private TreeNode BuildTree(int inorderStart, int inorderEnd, int rootIndex)
        {
            if (rootIndex < 0 || rootIndex >= _indexTable.Count)
            {
                return null;
            }

            if(inorderStart > inorderEnd)
            {
                return null;
            }

            if (inorderStart == inorderEnd)
            {
                return new TreeNode { val = _inorder[inorderEnd] };
            }

            var value = _preorder[rootIndex];
            var node = new TreeNode { val = value };
            var inorderIndex = _indexTable[value];
            var leftTreeLength = inorderIndex - inorderStart + 1;
            node.left = BuildTree(inorderStart, inorderIndex - 1, rootIndex + 1);
            node.right = BuildTree(inorderIndex + 1, inorderEnd, rootIndex + leftTreeLength);
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

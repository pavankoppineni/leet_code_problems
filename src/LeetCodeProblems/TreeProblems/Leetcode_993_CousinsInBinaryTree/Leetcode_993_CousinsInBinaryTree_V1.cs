using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_993_CousinsInBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/cousins-in-binary-tree/
    /// </summary>
    public class Leetcode_993_CousinsInBinaryTree_V1
    {
        private (int value, int height, int? parent) _nodeX, _nodeY;
        public bool IsCousins(TreeNode tree, int x, int y)
        {
            _nodeX = (x, 0, null);
            _nodeY = (y, 0, null);
            DFSTraversal(tree, null, 0);
            if (_nodeX.height == _nodeY.height)
            {
                return _nodeX.parent != _nodeY.parent;
            }
            return false;
        }

        private void DFSTraversal(TreeNode node, TreeNode parent, int height)
        {
            if (node == null)
            {
                return;
            }
            DFSTraversal(node.Left, node, height + 1);
            if (node.Value == _nodeX.value)
            {
                _nodeX.height = height;
                _nodeX.parent = parent?.Value;
            }
            if (node.Value == _nodeY.value)
            {
                _nodeY.height = height;
                _nodeY.parent = parent?.Value;
            }
            DFSTraversal(node.Right, node, height + 1);
        }
    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}

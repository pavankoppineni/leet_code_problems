using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    public class Leetcode_124_BinaryTreeMaximumPathSum_V1
    {
        private int _treeMaxPathSum = int.MinValue;
        public int Calculate(TreeNode124 tree)
        {
            return InternalCalculate(tree).Value;
        }

        private int? InternalCalculate(TreeNode124 node)
        {
            if (node == null)
            {
                return null;
            }

            var left = InternalCalculate(node.left);
            var right = InternalCalculate(node.right);

            if (left == null)
            {
                // When : Node is leaf
                if (right == null)
                {
                    _treeMaxPathSum = Math.Max(node.val, _treeMaxPathSum);
                    return node.val;
                }

                // When : Node has right child
                var currentRightPathSum = Math.Max(node.val + right.Value, node.val);
                _treeMaxPathSum = Math.Max(currentRightPathSum, _treeMaxPathSum);
                return currentRightPathSum;
            }

            // When : Node has left child
            if (right == null)
            {
                var currentLeftPathSum = Math.Max(node.val + left.Value, node.val);
                _treeMaxPathSum = Math.Max(currentLeftPathSum, _treeMaxPathSum);
                return currentLeftPathSum;
            }

            // When : Node has left and right child
            var leftAndRightPathSum = node.val + right.Value + left.Value;
            _treeMaxPathSum = Math.Max(_treeMaxPathSum, leftAndRightPathSum);
            _treeMaxPathSum = Math.Max(_treeMaxPathSum, leftAndRightPathSum - left.Value);
            _treeMaxPathSum = Math.Max(_treeMaxPathSum, leftAndRightPathSum - right.Value);
            _treeMaxPathSum = Math.Max(_treeMaxPathSum, node.val);

            var maxChildPath = Math.Max(leftAndRightPathSum - left.Value, leftAndRightPathSum - right.Value);
            var currentMaxPath = Math.Max(node.val, maxChildPath);
            return currentMaxPath;
        }
    }

    public class TreeNode124
    {
        public int val;
        public TreeNode124 left;
        public TreeNode124 right;
    }
}

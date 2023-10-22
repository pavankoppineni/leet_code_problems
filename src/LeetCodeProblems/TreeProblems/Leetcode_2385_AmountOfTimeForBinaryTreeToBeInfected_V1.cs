using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/amount-of-time-for-binary-tree-to-be-infected
    /// </summary>
    public class Leetcode_2385_AmountOfTimeForBinaryTreeToBeInfected_V1
    {
        private int _maxDistance;
        public int CalculateAmountOfTime(TreeNode2385 root, int start)
        {
            if (root.val == start)
            {
                var leftHeight = CalculateDistanceFromRoot(root.left, start, 0);
                var righHeight = CalculateDistanceFromRoot(root.right, start, 0);
                return Math.Max(leftHeight.distance, righHeight.distance);
            }
            CalculateDistanceFromRoot(root, start, 0);
            return _maxDistance;
        }

        private (TreeNode2385 startNode, int distance) CalculateDistanceFromRoot(TreeNode2385 node, int value, int distance)
        {
            if (node == null)
            {
                return (null, distance);
            }

            if (node.val == value)
            {
                return (node, distance);
            }

            var leftDistance = CalculateDistanceFromRoot(node.left, value, distance + 1);
            var rightDistance = CalculateDistanceFromRoot(node.right, value, distance + 1);

            //When : No start node exists
            if (leftDistance.startNode == null && rightDistance.startNode == null)
            {
                return (null, Math.Max(leftDistance.distance, rightDistance.distance));
            }

            _maxDistance = Math.Max(leftDistance.distance + rightDistance.distance, _maxDistance);
            return leftDistance.startNode == null ? rightDistance : leftDistance;
        }
    }

    public class TreeNode2385
    {
        public TreeNode2385 left;
        public TreeNode2385 right;
        public int val;
    }
}

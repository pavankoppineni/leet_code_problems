using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-sum-in-a-binary-tree/
    /// </summary>
    public class Leetcode_2583_KthLargestSumInBinaryTree_V1
    {
        private IDictionary<int, int> _levelSumLookup;
        public int CalculateKthSum(TreeNode2583 node, int k)
        {
            _levelSumLookup = new Dictionary<int, int>();
            CalculateLevelSum(node, 0);
            var sumList = _levelSumLookup.Values.OrderBy(x => x).ToList();
            return sumList[k];
        }

        private void CalculateLevelSum(TreeNode2583 node, int level)
        {
            if (node == null)
            {
                return;
            }
            if (!_levelSumLookup.ContainsKey(level))
            {
                _levelSumLookup.Add(level, 0);
            }
            _levelSumLookup[level] += node.val;
            CalculateKthSum(node.left, level + 1);
            CalculateLevelSum(node.right, level + 1);
        }
    }

    public class TreeNode2583
    {
        public TreeNode2583(int val, TreeNode2583 left, TreeNode2583 right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public int val { get; }
        public TreeNode2583 left { get; }
        public TreeNode2583 right { get; }
    }
}

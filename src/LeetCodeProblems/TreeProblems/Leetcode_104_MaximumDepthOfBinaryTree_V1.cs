using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class Leetcode_104_MaximumDepthOfBinaryTree_V1
    {
        public int FindMaximumDepth(TreeNode node)
        {
            return FindMaximumDepth(node, 0);
        }

        private int FindMaximumDepth(TreeNode node, int currentHeight)
        {
            if (node == null)
            {
                return currentHeight;
            }
            currentHeight += 1;
            var leftDepth = FindMaximumDepth(node.Left, currentHeight);
            var rightDepth = FindMaximumDepth(node.Right, currentHeight);
            return Math.Max(leftDepth, rightDepth);
        }
    }
}

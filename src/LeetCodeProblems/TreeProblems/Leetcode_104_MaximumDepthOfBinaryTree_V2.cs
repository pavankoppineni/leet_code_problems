using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class Leetcode_104_MaximumDepthOfBinaryTree_V2
    {
        public int FindMaximumDepth(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return 0;
            }

            var leftTreeDepth = FindMaximumDepth(treeNode.Left);
            var rightTreeDepth = FindMaximumDepth(treeNode.Right);
            return 1 + Math.Max(leftTreeDepth, rightTreeDepth);
        }
    }
}

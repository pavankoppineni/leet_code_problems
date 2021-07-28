using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public class Leetcode_111_MinimumDepthOfBinaryTree_V1
    {
        public int MinDepth(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return 0;
            }

            var leftTreeDepth = MinDepth(treeNode.Left);
            var rightTreeDepth = MinDepth(treeNode.Right);
            return 1 + Math.Min(leftTreeDepth, rightTreeDepth);
        }
    }
}

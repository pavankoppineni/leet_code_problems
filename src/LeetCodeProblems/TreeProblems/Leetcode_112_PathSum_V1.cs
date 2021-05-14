using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum/
    /// </summary>
    public class Leetcode_112_PathSum_V1
    {
        public bool HasPathSum(TreeNode node, int targetSum)
        {
            targetSum -= node.Value;
            return false;
        }
    }
}

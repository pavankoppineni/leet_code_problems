using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_112_PathSum
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum/
    /// </summary>
    public class Leetcode_112_PathSum_V1
    {
        public bool FindPathFromRootToLeaf(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Left == null && root.Right == null)
            {
                return root.Value == targetSum;
            }

            var leftResult = FindPathFromRootToLeaf(root.Left, targetSum - root.Value);
            if (leftResult)
            {
                return true;
            }
            return FindPathFromRootToLeaf(root.Right, targetSum - root.Value);
        }
    }
}

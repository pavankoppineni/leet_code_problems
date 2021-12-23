using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_113_PathSum
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum-ii/
    /// </summary>
    public class Leetcode_113_PathSum_V1
    {
        private IList<IList<int>> _pathSums;
        public IList<IList<int>> PathSum(TreeNode treeNode, int targetSum)
        {
            _pathSums = new List<IList<int>>();
            FindPathSum(treeNode, targetSum, new Stack<int>());
            return _pathSums;
        }

        private void FindPathSum(TreeNode treeNode, int targetSum, Stack<int> path)
        {
            if (treeNode == null)
            {
                return;
            }

            if (treeNode.Left == null && treeNode.Right == null)
            {
                if (treeNode.Value == targetSum)
                {
                    path.Push(treeNode.Value);
                    var pathArr = path.ToArray();
                    Array.Reverse(pathArr);
                    _pathSums.Add(pathArr);
                    path.Pop();
                }
                return;
            }

            path.Push(treeNode.Value);
            FindPathSum(treeNode.Right, targetSum - treeNode.Value, path);
            FindPathSum(treeNode.Left, targetSum - treeNode.Value, path);
            path.Pop();
        }
    }
}

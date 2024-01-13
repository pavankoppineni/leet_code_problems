using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
    /// </summary>
    public class Leetcode_1026_MaximumDifferenceBetweenNodeAndAncestor_V1
    {
        int maxDifference = -1;
        public int CalculateDifference(TreeNode1026 root)
        {
            CalculateDifference(root.left, root.val, root.val);
            CalculateDifference(root.right, root.val, root.val);
            return maxDifference;
        }

        private void CalculateDifference(TreeNode1026 current, int max, int min)
        {
            if (current == null)
            {
                return;
            }
            var maxCurrentDiff = Math.Abs(current.val - max);
            var minCurrentDiff = Math.Abs(current.val - min);
            var currentDifference = Math.Max(maxCurrentDiff, minCurrentDiff);
            maxCurrentDiff = Math.Max(maxCurrentDiff, currentDifference);
            max = Math.Max(max, current.val);
            min = Math.Min(min, current.val);
            CalculateDifference(current.left, max, min);
            CalculateDifference(current.right, max, min);
        }
    }


    public class TreeNode1026
    {
        public int val;
        public TreeNode1026 left;
        public TreeNode1026 right;
        public TreeNode1026(int val = 0, TreeNode1026 left = null, TreeNode1026 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

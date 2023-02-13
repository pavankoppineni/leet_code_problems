using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sum-root-to-leaf-numbers/
    /// </summary>
    public class Leetcode_129_SumRootToLeafNumbers_V1
    {
        private int _sum;
        public int CalculateSum(TreeNode129 root)
        {
            CalculateSum(root, 0);
            return _sum;
        }

        private void CalculateSum(TreeNode129 root, int prev)
        {
            if (root == null)
            {
                return;
            }

            if (root.right == null && root.left == null)
            {
                prev = prev * 10 + root.val;
                _sum += prev;
                return;
            }

            prev = prev * 10 + root.val;
            CalculateSum(root.right, prev);
            CalculateSum(root.left, prev);
        }
    }

    public class TreeNode129
    {
        public TreeNode129 left { get; set; }
        public TreeNode129 right { get; set; }
        public int val { get; set; }
    }
}

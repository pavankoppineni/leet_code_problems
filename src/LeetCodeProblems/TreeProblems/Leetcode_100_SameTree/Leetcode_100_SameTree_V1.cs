using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_100_SameTree
{
    /// <summary>
    /// https://leetcode.com/problems/same-tree/
    /// </summary>
    public class Leetcode_100_SameTree_V1
    {
        public bool IsIdentical(TreeNode x, TreeNode y)
        {
            if (x != null && y != null)
            {
                if (x.val != y.val)
                {
                    return false;
                }
                return IsIdentical(x.left, y.left) && IsIdentical(x.right, y.right);
            }
            return x == null && y == null;
        }
    }

    public class TreeNode : IEqualityComparer<TreeNode>
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public bool Equals(TreeNode x, TreeNode y)
        {
            if (x != null && y != null)
            {
                if (x.val != y.val)
                {
                    return false;
                }
                return Equals(x.left, y.left) && Equals(x.right, y.right);
            }
            return x == null && y == null;
        }

        public int GetHashCode(TreeNode obj)
        {
            return obj.GetHashCode();
        }
    }
}

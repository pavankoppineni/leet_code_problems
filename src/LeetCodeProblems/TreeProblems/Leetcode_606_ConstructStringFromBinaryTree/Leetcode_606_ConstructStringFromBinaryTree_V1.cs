using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_606_ConstructStringFromBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/construct-string-from-binary-tree/
    /// </summary>
    public class Leetcode_606_ConstructStringFromBinaryTree_V1
    {
        public string ConstructString(TreeNode root)
        {
            if(root == null)
            {
                return string.Empty;
            }

            if (root.left == null && root.right == null)
            {
                return root.val.ToString();
            }

            string leftString = "()";
            if (root.left != null)
            {
                leftString = $"({ ConstructString(root.left) })";
            }

            string rightString = string.Empty;
            if (root.right != null)
            {
                rightString = $"({ConstructString(root.right)})";
            }

            return $"{root.val}{leftString}{rightString}";
        }
    }

    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public override string ToString()
        {
            if (left == null && right == null)
            {
                return val.ToString();
            }

            string leftString = "()";
            if (left != null)
            {
                leftString = $"({ left.ToString()})";
            }

            string rightString = string.Empty;
            if (right != null)
            {
                rightString = $"({right.ToString()})";
            }

            return $"{val}{leftString}{rightString}";
        }
    }
}

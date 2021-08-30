using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-search-tree/
    /// </summary>
    public class Leetcode_98_ValidateBinarySearchTree_V2
    {
        public bool ValidateBinarySearchTree(TreeNode treeNode)
        {
            return ValidateBinarySearchTree(treeNode, null, null);
        }

        private bool ValidateBinarySearchTree(TreeNode treeNode, TreeNode left, TreeNode right)
        {
            if (treeNode == null)
            {
                return true;
            }

            if (left != null)
            {
                if (treeNode.Value < left.Value)
                {
                    return false;
                }
            }

            if (right != null)
            {
                if (treeNode.Value > right.Value)
                {
                    return false;
                }
            }

            var leftResult = ValidateBinarySearchTree(treeNode.Left, left, treeNode);
            if (!leftResult)
            {
                return false;
            }

            return ValidateBinarySearchTree(treeNode.Right, treeNode, right);
        }
    }
}

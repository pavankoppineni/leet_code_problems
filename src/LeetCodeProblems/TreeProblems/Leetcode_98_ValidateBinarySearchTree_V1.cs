using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/validate-binary-search-tree/
    /// </summary>
    public class Leetcode_98_ValidateBinarySearchTree_V1
    {
        public bool IsValidBST(TreeNode node)
        {
            return IsValidBST(node, null, null);
        }

        private bool IsValidBST(TreeNode node, TreeNode left, TreeNode right)
        {
            if (node == null)
            {
                return true;
            }

            //Case 1 : When left node is not null
            if (left != null)
            {
                if (node.Value <= left.Value)
                {
                    return false;
                }
            }

            //Case 2 : When right node is not null
            if (right != null)
            {
                if (node.Value >= right.Value)
                {
                    return false;
                }
            }

            var isLeftValid = IsValidBST(node.Left, left, node);
            if (!isLeftValid)
            {
                return false;
            }
            return IsValidBST(node.Right, node, right);
        }
    }
}

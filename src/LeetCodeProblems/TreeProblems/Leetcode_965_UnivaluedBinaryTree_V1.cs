using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/univalued-binary-tree/
    /// </summary>
    public class Leetcode_965_UnivaluedBinaryTree_V1
    {
        public bool IsUnivalTree(TreeNode node, int value)
        {
            if (node == null)
            {
                return true;
            }
            if (node.Value == value)
            {
                var result = IsUnivalTree(node.Left, value);
                if (result)
                {
                    return IsUnivalTree(node.Right, value);
                }
            }
            return false;
        }

        public bool IsUnivalTree(TreeNode node)
        {
            return IsUnivalTree(node, node.Value);
        }
    }
}

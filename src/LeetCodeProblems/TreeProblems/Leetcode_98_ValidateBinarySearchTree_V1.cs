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
            return IsValidBST(node.Value, node);
        }

        private bool IsValidBST(int parent, TreeNode node)
        {
            if(node == null)
            {
                return true;
            }

            var left = node.Left;
            var right = node.Right;

            bool leftTreeResult;
            bool rightTreeResult;

            //Case 1 : Validate left node
            if(left != null)
            {
                if (left.Value > node.Value)
                {
                    return false;
                }
            }

            //Case 2 : Validate right node
            if(right != null)
            {
                if (right.Value < node.Value)
                {
                    return false;
                }

                if(right.Value > parent)
                {
                    return false;
                }
            }

            //Check One : Check left side of tree
            leftTreeResult = IsValidBST(node.Value, node.Left);
            if (leftTreeResult)
            {
                rightTreeResult = IsValidBST(node.Value, node.Right);
            }
            else
            {
                return false;
            }

            if (rightTreeResult)
            {
                //Check 1 : Check left value
                if (left != null)
                {

                }

                //Check 2 : Check right value
                if (right != null)
                {

                }
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DFS
{
    /// <summary>
    /// https://leetcode.com/problems/evaluate-boolean-binary-tree/
    /// </summary>
    public class Leetcode_2331_EvaluateBooleanBinaryTree_V1
    {
        public bool EvaluateTree(TreeNode root)
        {
            return Evaluate(root);
        }

        private static bool Evaluate(TreeNode node)
        {
            var value = node.val;
            switch (value)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                case 2:
                    var leftOR = Evaluate(node.left);
                    if (leftOR)
                    {
                        return true;
                    }
                    return Evaluate(node.right);
                default:
                    var leftAnd = Evaluate(node.left);
                    if (!leftAnd)
                    {
                        return false;
                    }
                    return Evaluate(node.right);
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }

            
        }
    }
}

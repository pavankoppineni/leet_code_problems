using LeetCodeProblems.TreeProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public class Leetcode_102_BinaryTreeLevelOrderTraversal_V1
    {
        private IList<IList<int>> levelOrderItems;

        public IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            levelOrderItems = new List<IList<int>>();
            LevelOrderTraversal(root, 0);
            return levelOrderItems;
        }

        private void LevelOrderTraversal(TreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }
            //Case 1 : Level exists in dictionary
            if (level >= levelOrderItems.Count)
            {
                levelOrderItems.Add(new List<int>());
            }   
            LevelOrderTraversal(node.Left, level + 1);
            levelOrderItems[level].Add(node.Value);
            LevelOrderTraversal(node.Right, level + 1);
        }
    }
}

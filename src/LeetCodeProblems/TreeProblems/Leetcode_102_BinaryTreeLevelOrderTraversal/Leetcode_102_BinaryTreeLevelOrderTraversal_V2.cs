using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_102_BinaryTreeLevelOrderTraversal
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public class Leetcode_102_BinaryTreeLevelOrderTraversal_V2
    {
        public IList<IList<int>> LevelOrderTraversal(Node102V2 node)
        {
            var levelItems = new Dictionary<int, IList<int>>();
            LevelOrderTraversal(levelItems, node, 0);
            var result = new List<IList<int>>(levelItems.Count);
            foreach (var item in levelItems)
            {
                foreach (var value in item.Value)
                {
                    result[item.Key].Add(value);
                }
            }

            return result;
        }

        private void LevelOrderTraversal(IDictionary<int, IList<int>> levelItems, Node102V2 node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (levelItems.ContainsKey(level))
            {
                levelItems.Add(level, new List<int>());
            }
            LevelOrderTraversal(levelItems, node.Left, level + 1);
            levelItems[level].Add(node.Value);
            LevelOrderTraversal(levelItems, node.Right, level + 1);
        }
    }

    public class Node102V2
    {
        public int Value { get; set; }
        public Node102V2 Left { get; set; }
        public Node102V2 Right { get; set; }
    }
}

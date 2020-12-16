using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-largest-value-in-each-tree-row/
    /// </summary>
    public class Leetcode_515_FindLargestValueInEachTreeRow_V1
    {
        public IList<int> FindLargestValues(TreeNode515 root)
        {
            var largestValues = new List<int>();
            var buffer = new Queue<(int level, TreeNode515 node)>();
            var currentLevel = 0;
            buffer.Enqueue((0, root));
            largestValues.Add(root.Value);
            while (buffer.Count > 0)
            {
                var currentItem = buffer.Dequeue();
                var currentNode = currentItem.node;
                if (currentItem.level > currentLevel)
                {
                    currentLevel = currentItem.level;
                    largestValues.Add(currentNode.Value);
                }
                else
                {
                    if (currentNode.Value > largestValues[currentLevel])
                    {
                        largestValues[currentLevel] = currentNode.Value;
                    }
                }
                if (currentNode.Left != null)
                {
                    buffer.Enqueue((currentItem.level + 1, currentNode.Left));
                }
                if (currentNode.Right != null)
                {
                    buffer.Enqueue((currentItem.level + 1, currentNode.Right));
                }
            }
            return largestValues;
        }

        public class TreeNode515
        {
            public TreeNode515(int value)
            {
                Value = value;
            }
            public TreeNode515 Left { get; set; }
            public TreeNode515 Right { get; set; }
            public int Value { get;  }
        }
    }
}

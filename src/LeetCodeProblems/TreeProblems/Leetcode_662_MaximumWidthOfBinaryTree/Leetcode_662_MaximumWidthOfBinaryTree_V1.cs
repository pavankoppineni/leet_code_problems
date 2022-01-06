using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_662_MaximumWidthOfBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-width-of-binary-tree/
    /// </summary>
    public class Leetcode_662_MaximumWidthOfBinaryTree_V1
    {
        IDictionary<int, (int min, int max)> _levels;
        public int WidthOfBinaryTree(Node root)
        {
            _levels = new Dictionary<int, (int min, int max)>();
            WidthOfBinaryTree(root, 0, 1);
            int maxWidth = 1;
            foreach (var level in _levels.Values)
            {
                var currentWidth = Math.Abs(level.max - level.min) + 1;
                if (currentWidth > maxWidth)
                {
                    maxWidth = currentWidth;
                }
            }
            return maxWidth;
        }

        public void WidthOfBinaryTree(Node root, int level, int width)
        {
            if (root == null)
            {
                return;
            }

            if (_levels.ContainsKey(level))
            {
                (var min, var max) = _levels[level];
                if (width < min)
                {
                    _levels[level] = (width, max);
                }
                else if (width > max)
                {
                    _levels[level] = (min, width);
                }
            }
            else
            {
                _levels.Add(level, (width, width));
            }
            WidthOfBinaryTree(root.right, level + 1, 2 * width);
            WidthOfBinaryTree(root.left, level + 1, 2 * width + 1);
        }
    }

    public class Node
    {
        public int val;
        public Node right;
        public Node left;
    }
}

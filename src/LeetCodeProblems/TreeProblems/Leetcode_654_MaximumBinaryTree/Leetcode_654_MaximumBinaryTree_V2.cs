using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_654_MaximumBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-binary-tree/
    /// </summary>
    public class Leetcode_654_MaximumBinaryTree_V2
    {
        public Node654_V2 Construct(int[] values)
        {
            return Construct(values, 0, values.Length - 1);
        }

        private Node654_V2 Construct(int[] values, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var parent = Create(values, start, end);
            parent.node.Left = Construct(values, start, parent.maxIndex - 1);
            parent.node.Right = Construct(values, parent.maxIndex + 1, end);
            return parent.node;
        }

        private (Node654_V2 node, int maxIndex) Create(int[] values, int start, int end)
        {
            var max = values[start];
            var maxIndex = start;
            while (start <= end)
            {
                if (values[start] > max)
                {
                    max = values[start];
                    maxIndex = start;
                }
                start += 1;
            }
            var node = new Node654_V2
            {
                Value = max
            };
            return (node, maxIndex);
        }
    }

    public class Node654_V2
    {
        public Node654_V2 Left { get; set; }
        public Node654_V2 Right { get; set; }
        public int Value { get; set; }
    }
}

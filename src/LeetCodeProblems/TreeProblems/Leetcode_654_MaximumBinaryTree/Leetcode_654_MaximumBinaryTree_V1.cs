using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_654_MaximumBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-binary-tree/
    /// </summary>
    public class Leetcode_654_MaximumBinaryTree_V1
    {
        public Node654V1 ConstructMaximumBinaryTree(int[] values)
        {
            return ConstructMaximumBinaryTree(values, 0, values.Length - 1);
        }

        private Node654V1 ConstructMaximumBinaryTree(int[] values, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var maxIndex = FindMaxIndex(values, start, end);
            var node = new Node654V1 { Value = values[maxIndex] };
            node.Left = ConstructMaximumBinaryTree(values, start, maxIndex - 1);
            node.Right = ConstructMaximumBinaryTree(values, maxIndex + 1, end);
            return node;
        }

        private int FindMaxIndex(int[] values, int start, int end)
        {
            var maxIndex = start;
            for (var index = start; index <= end; index++)
            {
                if (values[index] > values[maxIndex])
                {
                    maxIndex = index;
                }
            }

            return maxIndex;
        }
    }

    public class Node654V1
    {
        public int Value { get; set; }
        public Node654V1 Left { get; set; }
        public Node654V1 Right { get; set; }
    }
}

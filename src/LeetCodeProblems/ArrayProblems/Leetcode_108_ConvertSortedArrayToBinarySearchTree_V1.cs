using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    public class Node108
    {
        public int Value { get; set; }
        public Node108 Left { get; set; }
        public Node108 Right { get; set; }
    }

    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    public class Leetcode_108_ConvertSortedArrayToBinarySearchTree_V1
    {
        public Node108 Convert(int[] values)
        {
            return Convert(values, 0, values.Length - 1);
        }

        private Node108 Convert(int[] values, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var mid =  start + ((end - start + 1) >> 1);
            var node = new Node108 { Value = values[mid] };
            node.Left = Convert(values, start, mid - 1);
            node.Right = Convert(values, mid + 1, end);
            return node;
        }
    }
}

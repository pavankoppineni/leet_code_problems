using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedListProblems
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/
    /// </summary>
    public class Leetcode_430_FlattenMultilevelDoublyLinkedList_V1
    {
        public Node430 Flatten(Node430 node)
        {
            return null;
        }
    }

    public class Node430
    {
        public int Value { get; set; }
        public Node430 Next { get; set; }
        public Node430 Previous { get; set; }
        public Node430 Child { get; set; }

        public static Node430 CreateNode(int value)
        {
            var node = new Node430
            {
                Value = value
            };
            return node;
        }
    }
}

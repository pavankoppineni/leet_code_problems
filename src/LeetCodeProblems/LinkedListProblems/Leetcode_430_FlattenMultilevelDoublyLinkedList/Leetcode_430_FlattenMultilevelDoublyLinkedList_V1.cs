using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedListProblems.Leetcode_430_FlattenMultilevelDoublyLinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/
    /// </summary>
    public class Leetcode_430_FlattenMultilevelDoublyLinkedList_V1
    {
        public Node Flatten(Node node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.next == null && node.child == null)
            {
                return node;
            }
            var currentNode = node;
            var childNode = node.child;
            var nextNode = node.next;
            var flattenChildNode = Flatten(currentNode.child);
            var flattenNextNode = Flatten(currentNode.next);
            while (flattenChildNode != null)
            {
                currentNode.next = flattenChildNode;
                flattenChildNode.prev = currentNode;
                currentNode = flattenChildNode;
                flattenChildNode = flattenChildNode.next;
            }
            while (flattenNextNode != null)
            {
                currentNode.next = flattenNextNode;
                flattenNextNode.prev = currentNode;
                currentNode = flattenNextNode;
                flattenNextNode = flattenNextNode.next;
            }
            node.child = null;
            return node;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node prev;
        public Node child;
    }
}

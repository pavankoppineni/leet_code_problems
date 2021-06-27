using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LinkedListProblems
{
    /// <summary>
    /// https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
    /// </summary>
    public class Leetcode_1721_SwppingNodesInLinkedList_V1
    {

        public Node1721 SwapNodes(Node1721 head, int k)
        {
            Node1721 kthNodeFromBeginning = null;
            Node1721 kthNodeFromEnd = null;
            var current = head;
            var currentIndex = 0;
            while (current != null)
            {
                currentIndex += 1;
                if (currentIndex == k)
                {
                    kthNodeFromBeginning = current;
                    break;
                }
                current = current.Next;
            }
            var temp = kthNodeFromBeginning;
            var tempCurrent = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
                tempCurrent = tempCurrent.Next;
            }
            kthNodeFromEnd = tempCurrent;
            var val = kthNodeFromBeginning.Value;
            kthNodeFromBeginning.Value = kthNodeFromEnd.Value;
            kthNodeFromEnd.Value = val;
            return head;
        }

        public class Node1721
        {
            public int Value { get; set; }
            public Node1721 Next { get; set; }
        }
    }
}

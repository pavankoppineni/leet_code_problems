using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_230_KthSmallestElementInBST
{
    /// <summary>
    /// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
    /// </summary>
    public class Leetcode_230_KthSmallestElementInBST_V1
    {
    }

    public class Tree230V1
    {
        public Node230V1 Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node230V1 { Value = value };
            }
        }

        private Node230V1 Insert(Node230V1 node, int value)
        {
            if (node == null)
            {
                return new Node230V1 { Value = value };
            }

            if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                //node.Left = Insert(node)
            }

            return null;
        }
    }

    public class Node230V1
    {
        public int Value { get; set; }
        public Node230V1 Left { get; set; }
        public Node230V1 Right { get; set; }
    }
}

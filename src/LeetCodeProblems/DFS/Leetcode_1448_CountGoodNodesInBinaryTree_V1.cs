using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DFS
{
    /// <summary>
    /// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
    /// </summary>
    public class Leetcode_1448_CountGoodNodesInBinaryTree_V1
    {
        public int CalculateGoodNodes(Node1448 node)
        {
            var count = 0;
            CalculateGoodNodes(node, node.val, ref count);
            return count;
        }

        private void CalculateGoodNodes(Node1448 node, int max, ref int count)
        {
            if (node == null)
            {
                return;
            }
            if (node.val >= max)
            {
                count += 1;
            }
            CalculateGoodNodes(node.left, node.val > max ? node.val : max, ref count);
            CalculateGoodNodes(node.right, node.val > max ? node.val : max, ref count);
        }

        public class Node1448
        {
            public int val;
            public Node1448 left;
            public Node1448 right;
            public Node1448(int val = 0, Node1448 left = null, Node1448 right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}

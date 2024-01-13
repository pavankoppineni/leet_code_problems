using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    /// </summary>
    public class Leetcode_116_PopulatingNextRightPointersInEachNode_V1
    {
        private IDictionary<int, Node116> _nodesLookup;
        public Node116 Connect(Node116 root)
        {
            _nodesLookup = new Dictionary<int, Node116>();
            ConstructTree(root, 0);
            return root;
        }

        private void ConstructTree(Node116 node, int level)
        {
            if (node == null)
            {
                return;
            }
            if (!_nodesLookup.ContainsKey(level))
            {
                _nodesLookup.Add(level, node);
            }
            else
            {
                _nodesLookup[level].next = node;
                _nodesLookup[level] = node;
            }
            ConstructTree(node.left, level + 1);
            ConstructTree(node.right, level + 1);
        }
        
        public class Node116
        {
            internal int val;
            internal Node116 left;
            internal Node116 right;
            internal Node116 next;
        }
    }
}

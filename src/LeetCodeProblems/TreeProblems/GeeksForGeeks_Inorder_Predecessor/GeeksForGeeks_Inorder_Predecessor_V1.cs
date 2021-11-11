using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.GeeksForGeeks_Inorder_Predecessor
{
    /// <summary>
    /// https://www.geeksforgeeks.org/inorder-predecessor-successor-given-key-bst/
    /// </summary>
    public class GeeksForGeeks_Inorder_Predecessor_V1
    {
        public int FindPredecessor(GeeksForGeeksNode node)
        {
            if (node.Left == null)
            {
                return node.Value;
            }

            var predecessor = GetInorderPredecessor(node.Left);
            return predecessor.Value;
        }

        private GeeksForGeeksNode GetInorderPredecessor(GeeksForGeeksNode node)
        {
            var current = node;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current;
        }
    }

    public class GeeksForGeeksNode
    {
        public int Value { get; set; }
        public GeeksForGeeksNode Left { get; set; }
        public GeeksForGeeksNode Right { get; set; }
    }
}

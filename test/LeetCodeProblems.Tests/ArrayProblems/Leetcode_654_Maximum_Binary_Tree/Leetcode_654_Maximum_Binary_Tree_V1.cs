using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_654_Maximum_Binary_Tree
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-binary-tree/
    /// </summary>
    public class Leetcode_654_Maximum_Binary_Tree_V1
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Parent { get; set; }
        }

        public Node ConstructMaximumBinaryTree(int[] values)
        {
            var rootNode = new Node { Value = values[0] };
            var stack = new Stack<int>();
            stack.Push(0);

            for (var index = 1; index < values.Length; index++)
            {
                var value = values[index];
                var peekIndex = stack.Peek();
                var peekValue = values[peekIndex];

                //Case 1 : When value is greater than or equal to peek value
                //Action : Make value as root node
                if (peekValue >= value)
                {
                    var newRootNode = new Node { Value = values[index] };
                    newRootNode.Left = rootNode;
                    rootNode.Parent = newRootNode;
                    rootNode = newRootNode;
                }
                //Case 2 : When value is less than
                else
                {

                }
            }
            return rootNode;
        }
    }
}

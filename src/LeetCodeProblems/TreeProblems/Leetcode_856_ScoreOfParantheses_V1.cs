using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/score-of-parentheses/
    /// </summary>
    public class LeetCode_856_ScoreOfParantheses_V1
    {
        public int CalculateScoreOfParantheses(string parantheses)
        {
            var node = ComputeTree(parantheses);
            return -1;
        }

        private Node ComputeTree(string parantheses)
        {
            var node = Node.Create();
            var current = node;
            for (var index = 0; index < parantheses.Length; index++)
            {
                if (parantheses[index] == '{')
                {
                    var childNode = Node.Create();
                    childNode.Parent = current;
                    current.Children.Add(childNode);
                    current = childNode;
                }
                else
                {
                    current = current.Parent;
                }
            }

            return node;
        }
    }

    public class Node
    {
        public Node Parent { get; set; }
        public IList<Node> Children { get; set; }

        public static Node Create()
        {
            var node = new Node
            {
                Children = new List<Node>()
            };
            return node;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/score-of-parentheses/
    /// </summary>
    public class Leetcode_856_ScoreOfParatheses_V1
    {
        public int CalculateScore(string parantheses)
        {
            var node = CreateParanthesesTree(parantheses);
            return CalculateScore(node);
        }

        private int CalculateScore(Node_856 node)
        {
            return node.CalculateScore();
        }

        private Node_856 CreateParanthesesTree(string parantheses)
        {
            Node_856 parent = Node_856.Create(null);
            for (var index = 0; index < parantheses.Length; index++)
            {
                //Case 1 : When value is '('
                if (parantheses[index] == '(')
                {
                    var node = Node_856.Create(parent);
                    parent.Children.Add(node);
                    parent = node;
                }
                //Case 2 : When value is ')'
                else
                {
                    parent = parent.Parent;
                }
            }
            return parent;
        }
    }

    public class Node_856
    {
        public Node_856 Parent { get; set; }
        public IList<Node_856> Children { get; set; }

        public static Node_856 Create(Node_856 parent)
        {
            return new Node_856
            {
                Parent = parent,
                Children = new List<Node_856>()
            };
        }

        public int CalculateScore()
        {
            if (Children.Count == 0)
            {
                return 1;
            }
            var score = 0;
            foreach (var childNode in Children)
            {
                score += childNode.CalculateScore();
            }
            if (Parent == null)
            {
                return score;
            }
            return 2 * score;
        }
    }
}

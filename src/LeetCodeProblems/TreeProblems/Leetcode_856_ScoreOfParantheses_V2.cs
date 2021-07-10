using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/score-of-parentheses/
    /// </summary>
    public class Leetcode_856_ScoreOfParantheses_V2
    {
        public int CalculateScore(string parantheses)
        {
            var tree = CreateTree(parantheses);
            return tree.ComputeScore();
        }

        private Node_856 CreateTree(string parntheses)
        {
            Node_856 current = Node_856.Create(null);
            foreach (var item in parntheses)
            {
                if (item == '{')
                {
                    var newNode = Node_856.Create(current);
                    current.Children.Add(newNode);
                    current = newNode;
                }
                else
                {
                    current = current.Parent;
                }
            }
            return current;
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
                Children = new List<Node_856>(),
                Parent = parent
            };
        }

        public int ComputeScore()
        {
            if (Children.Count == 0)
            {
                return 1;
            }

            var score = 0;
            foreach (var chilItem in Children)
            {
                score += chilItem.ComputeScore();
            }

            if (Parent == null)
            {
                return score;
            }

            return 2 * score;
        }
    }
}

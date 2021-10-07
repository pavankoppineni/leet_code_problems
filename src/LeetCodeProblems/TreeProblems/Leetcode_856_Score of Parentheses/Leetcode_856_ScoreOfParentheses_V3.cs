using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_856_Score_of_Parentheses
{
    /// <summary>
    /// https://leetcode.com/problems/score-of-parentheses/
    /// </summary>
    public class Leetcode_856_ScoreOfParentheses_V3
    {
        public int ComputeScore(string parantheses)
        {
            var tree = ConstructTree(parantheses);
            return tree.ComputeScore();
        }

        private Node856V3 ConstructTree(string parantheses)
        {
            Node856V3 current = Node856V3.Create(null);
            foreach (var item in parantheses)
            {
                if (item == '{')
                {
                    var newNode = Node856V3.Create(current);
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

    public class Node856V3
    {
        public Node856V3(Node856V3 parent)
        {
            Children = new List<Node856V3>();
            Parent = parent;
        }
        public Node856V3 Parent { get; set; }
        public IList<Node856V3> Children { get; set; }

        public static Node856V3 Create(Node856V3 parent)
        {
            return new Node856V3(parent);
        }

        public int ComputeScore()
        {
            if (Children.Count == 0)
            {
                return 1;
            }

            var score = 0;
            foreach (var childItem in Children)
            {
                score += childItem.ComputeScore();
            }

            if (Parent == null)
            {
                return score;
            }

            return 2 * score;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StackProblems
{
    /// <summary>
    /// https://leetcode.com/problems/score-of-parentheses/
    /// </summary>
    public class Leetcode_856_ScoreOfParentheses_V1
    {
        public int CalculateScore(string s)
        {
            var root = new Node856(null);
            var currentParent = root;
            for (var index = 0; index < s.Length; index++)
            {
                if (s[index] == '(')
                {
                    var node = new Node856(currentParent);
                    currentParent.Children.Add(node);
                    currentParent = node;
                }
                else
                {
                    currentParent = currentParent.Parent;
                }
            }
            return root.CalculateScore();
        }

        public class Node856
        {
            public Node856(Node856 parent)
            {
                Parent = parent;
                Children = new List<Node856>();
            }

            public Node856 Parent { get; set; }
            public IList<Node856> Children { get; set; }

            private int Score()
            {
                if (Children.Count == 0)
                {
                    return 1;
                }
                var totalScore = 0;
                foreach (var child in Children)
                {
                    totalScore += child.Score();
                }
                return 2 * totalScore;
            }

            public int CalculateScore()
            {
                var totalScore = 0;
                foreach (var child in Children)
                {
                    totalScore += child.Score();
                }
                return totalScore;
            }
        }
    }
}

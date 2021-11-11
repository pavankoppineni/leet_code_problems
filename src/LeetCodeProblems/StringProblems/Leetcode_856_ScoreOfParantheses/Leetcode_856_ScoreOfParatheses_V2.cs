using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/score-of-parentheses/
    /// </summary>
    public class Leetcode_856_ScoreOfParatheses_V2
    {
        public int CalculateScore(string parantheses)
        {
            var root = new Node_856_V2();
            var currentRoot = root;

            for(var index = 0; index < parantheses.Length; index++)
            {
                //Case 1 : Opening parantheses
                if(parantheses[index] == '{')
                {
                    var newNode = new Node_856_V2{ Parent = currentRoot};
                    currentRoot.Children.Add(newNode);
                    currentRoot = newNode;
                }
                //Case 2 : Closing parantheses
                else
                {
                    currentRoot = currentRoot.Parent;
                }
            }

            return root.CalculateScore();
        }
    }

    public class Node_856_V2
    {
        public Node_856_V2()
        {
            Children = new List<Node_856_V2>();
        }

        public Node_856_V2 Parent { get; set;}
        public IList<Node_856_V2> Children {get; set;}

        public int CalculateScore()
        {
            if(Children.Count == 0)
            {
                return 1;
            }
            
            var score = 0;
            foreach(var item in Children)
            {
                score += item.CalculateScore();
            }

            if(Parent == null)
            {
                return score;
            }

            return 2 * score;
        }
    }
}

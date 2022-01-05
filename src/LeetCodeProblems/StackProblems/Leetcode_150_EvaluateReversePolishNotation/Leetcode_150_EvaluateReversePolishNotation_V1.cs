using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StackProblems.Leetcode_150_EvaluateReversePolishNotation
{
    /// <summary>
    /// https://leetcode.com/problems/evaluate-reverse-polish-notation/
    /// </summary>
    public class Leetcode_150_EvaluateReversePolishNotation_V1
    {
        public int Evaluate(string[] tokens)
        {
            var stack = new Stack<int>();
            for (var index = 0; index < tokens.Length; index++)
            {
                var isOperator = IsOperator(tokens[index]);
                if (isOperator)
                {
                    var rightOperand = stack.Pop();
                    var leftOperand = stack.Pop();
                    var result = Evaluate(leftOperand, rightOperand, tokens[index]);
                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(tokens[index]));
                }
            }
            return stack.Pop();
        }

        private bool IsOperator(string token)
        {
            switch (token)
            {
                case "-":
                case "+":
                case "*":
                case "/":
                    return true;
                default:
                    return false;
            }
        }

        private int Evaluate(int left, int right, string token)
        {
            switch (token)
            {
                case "-":
                    return left - right;
                case "+":
                    return left + right;
                case "*":
                    return left * right;
                default:
                    return left / right;
            }
        }
    }
}

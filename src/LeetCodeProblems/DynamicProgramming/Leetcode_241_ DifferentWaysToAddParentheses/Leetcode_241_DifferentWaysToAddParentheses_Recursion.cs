using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_241__DifferentWaysToAddParentheses
{
    /// <summary>
    /// https://leetcode.com/problems/different-ways-to-add-parentheses/
    /// </summary>
    public class Leetcode_241_DifferentWaysToAddParentheses_Recursion
    {
        private IList<ExpressionItem> _expressionItems;
        public IList<int> DiffWaysToCompute(string expression)
        {
            _expressionItems = new List<ExpressionItem>();
            var numberIndex = 0;
            for (var index = 1; index < expression.Length; index++)
            {
                switch (expression[index])
                {
                    case '+':
                        var subStr = expression.Substring(numberIndex, index - numberIndex);
                        _expressionItems.Add(ExpressionItem.CreateOperand(subStr));
                        _expressionItems.Add(ExpressionItem.CreateOperator(Operator.Addition));
                        numberIndex = index + 1;
                        break;
                    case '-':
                        var subStr1 = expression.Substring(numberIndex, index - numberIndex);
                        _expressionItems.Add(ExpressionItem.CreateOperand(subStr1));
                        _expressionItems.Add(ExpressionItem.CreateOperator(Operator.Subtraction));
                        numberIndex = index + 1;
                        break;
                    case '*':
                        var subStr2 = expression.Substring(numberIndex, index - numberIndex);
                        _expressionItems.Add(ExpressionItem.CreateOperand(subStr2));
                        _expressionItems.Add(ExpressionItem.CreateOperator(Operator.Multiplication));
                        numberIndex = index + 1;
                        break;
                }
            }
            var remainingStr = expression.Substring(numberIndex, expression.Length - numberIndex);
            _expressionItems.Add(ExpressionItem.CreateOperand(remainingStr));
            var nodes = GenerateExpressions(0, _expressionItems.Count - 1);
            var result = new List<int>();
            foreach (var node in nodes)
            {
                result.Add(node.Eval());
            }
            return result;
        }

        private IList<Node> GenerateExpressions(int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var nodes = new List<Node>();
            if (start == end)
            {
                var node = Node.CreateOperand(_expressionItems[start].Value);
                nodes.Add(node);
                return nodes;
            }

            for (var index = start + 1; index < end; index += 2)
            {
                var leftNodes = GenerateExpressions(start, index - 1);
                var rightNodes = GenerateExpressions(index + 1, end);
                foreach (var leftNode in leftNodes)
                {
                    foreach (var rightNode in rightNodes)
                    {
                        var rootNode = Node.CreateOperator(_expressionItems[index].OperatorType);
                        rootNode.Left = leftNode;
                        rootNode.Right = rightNode;
                        nodes.Add(rootNode);
                    }
                }
            }

            return nodes;
        }
    }

    public class ExpressionItem
    {
        public int? Value { get; set; }
        public bool IsOperator { get; set; }
        public Operator? OperatorType { get; set; }

        public static ExpressionItem CreateOperator(Operator operatorType)
        {
            return new ExpressionItem { OperatorType = operatorType, IsOperator = true };
        }

        public static ExpressionItem CreateOperand(string value)
        {
            return new ExpressionItem { IsOperator = false, Value = int.Parse(value) };
        }
    }

    public enum Operator
    {
        Addition,
        Subtraction,
        Multiplication,
    }

    public class Node
    {
        public int? Value { get; set; }
        public bool IsOperator { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Operator? OperatorType { get; set; }

        public static Node CreateOperand(int? value)
        {
            return new Node { Value = value };
        }

        public static Node CreateOperator(Operator? operatorType)
        {
            return new Node { OperatorType = operatorType, IsOperator = true };
        }

        public int Eval()
        {
            if (IsOperator)
            {
                switch (OperatorType)
                {
                    case Leetcode_241__DifferentWaysToAddParentheses.Operator.Addition:
                        return Left.Eval() + Right.Eval();
                    case Leetcode_241__DifferentWaysToAddParentheses.Operator.Subtraction:
                        return Left.Eval() - Right.Eval();
                    default:
                        return Left.Eval() * Right.Eval();
                }
            }
            else
            {
                return Value.Value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_282_ExpressionAddOperators
{
    /// <summary>
    /// https://leetcode.com/problems/expression-add-operators/
    /// </summary>
    public class Leetcode_282_ExpressionAddOperators_V1
    {
        private string _number;
        private char[] _operators = new char[] { '+', '-', '*' };
        private IDictionary<string, IList<Node_282>> _lookup;
        public IList<string> GenerateOperators(string number, int target)
        {
            _number = number;
            _lookup = new Dictionary<string, IList<Node_282>>();
            var operations = GenerateOperations(0, number.Length);
            return null;
        }

        private IList<Node_282> GenerateOperations(int start, int end)
        {
            if (start > end)
            {
                return Array.Empty<Node_282>();
            }

            var key = $"{start}_{end}";
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }

            var rootNodes = new List<Node_282>();
            if (start == end)
            {
                rootNodes.Add(Node_282.Create(_number[start]));
                _lookup.Add(key, rootNodes);
                return rootNodes;
            }

            for (var index = start; index < end; index++)
            {
                var leftNodes = GenerateOperations(start, index);
                var rightNodes = GenerateOperations(index + 1, end);
                foreach (var op in _operators)
                {
                    var rootNode = Node_282.Create(op);
                    foreach (var leftNode in leftNodes)
                    {
                        foreach (var rightNode in rightNodes)
                        {
                            rootNode.Left = leftNode;
                            rootNode.Right = rightNode;
                        }
                    }
                    rootNodes.Add(rootNode);
                }
            }

            _lookup.Add(key, rootNodes);
            return rootNodes;
        }
    }

    public class Node_282
    {
        public char Value { get; set; }
        public Node_282 Left { get; set; }
        public Node_282 Right { get; set; }
        public static Node_282 Create(char value)
        {
            return new Node_282 { Value = value };
        }
    }
}

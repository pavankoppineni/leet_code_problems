using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-nodes-with-the-highest-score/
    /// </summary>
    public class Leetcode_2049_CountNodesWithHighestScore_V1
    {
        private int _totalNodes;
        private IDictionary<long, int> _sizeScoreLookup;

        public int CalculateHighestScore(int[] parents)
        {
            _sizeScoreLookup = new Dictionary<long, int>();
            _totalNodes = parents.Length;
            var tree = ConstructTree(parents);
            CalculateChildCount(tree);
            CalculateSizeScore(tree);
            var maxValue = long.MinValue;
            var count = 0;
            foreach (var lookupItem in _sizeScoreLookup)
            {
                if (lookupItem.Key > maxValue)
                {
                    maxValue = lookupItem.Key;
                    count = lookupItem.Value;
                }
            }
            return count;
        }

        private void CalculateSizeScore(Node_2049 node)
        {
            if (node == null)
            {
                return;
            }

            CalculateSizeScore(node.Left);
            CalculateSizeScore(node.Right);
            long leftCount = node.LeftCount == 0 ? 1 : node.LeftCount;
            long rightCount = node.RightCount == 0 ? 1 : node.RightCount;
            long remainingNodesCount = _totalNodes - node.TotalChildCount - 1 == 0 ? 1 : _totalNodes - node.TotalChildCount - 1;
            long sizeScore = leftCount * rightCount * remainingNodesCount;
            if (!_sizeScoreLookup.ContainsKey(sizeScore))
            {
                _sizeScoreLookup.Add(sizeScore, 0);
            }
            _sizeScoreLookup[sizeScore] += 1;
        }
        private Node_2049 ConstructTree(int[] parents)
        {
            var lookup = new Dictionary<int, Node_2049>
            {
                { 0, new Node_2049(0) }
            };
            for (var index = 0; index < parents.Length; index++)
            {
                if (parents[index] == -1)
                {
                    continue;
                }
                if (!lookup.ContainsKey(index))
                {
                    lookup.Add(index, new Node_2049(index));
                }
                var currentNode = lookup[index];
                var parent = parents[index];
                if (!lookup.ContainsKey(parent))
                {
                    lookup.Add(parent, new Node_2049(parent));
                }
                var parentNode = lookup[parent];
                if (parentNode.Left == null)
                {
                    parentNode.Left = currentNode;
                }
                else
                {
                    parentNode.Right = currentNode;
                }
            }
            return lookup[0];
        }
        private int CalculateChildCount(Node_2049 node)
        {
            if (node == null)
            {
                return 0;
            }
            var leftCount = CalculateChildCount(node.Left);
            var rightCount = CalculateChildCount(node.Right);
            node.LeftCount = leftCount;
            node.RightCount = rightCount;
            return leftCount + rightCount + 1;
        }
    }

    public class Node_2049
    {
        public Node_2049(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public Node_2049 Left { get; set; }
        public Node_2049 Right { get; set; }
        public int LeftCount { get; set; }
        public int RightCount { get; set; }
        public int TotalChildCount => LeftCount + RightCount;
    }
}

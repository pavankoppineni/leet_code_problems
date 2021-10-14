using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems.Leetcode_637_AverageOfLevelsInBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/average-of-levels-in-binary-tree/
    /// </summary>
    public class Leetcode_637_AverageOfLevelsInBinaryTree_V1
    {
        private IDictionary<int, Pair> levels;
        public IList<double> AverageOfLevels(Node637V1 node)
        {
            levels = new Dictionary<int, Pair>();
            InorderTraversal(node, 0);
            var averageLevels = new double[levels.Count];
            foreach (var level in levels)
            {
                averageLevels[level.Key] = level.Value.CalculateAverage();
            }
            return averageLevels;
        }

        private void InorderTraversal(Node637V1 node, int level)
        {
            if (node == null)
            {
                return;
            }
            InorderTraversal(node.Left, level + 1);
            if (levels.ContainsKey(level))
            {
                var pair = levels[level];
                pair.TotalNodes += 1;
                pair.TotalSum += node.Value;
                levels[level] = pair;
            }
            else
            {
                var pair = new Pair { TotalNodes = 1, TotalSum = node.Value };
                levels.Add(level, pair);
            }
            InorderTraversal(node.Right, level + 1);
        }
    }

    public struct Pair
    {
        public int TotalSum { get; set; }
        public int TotalNodes { get; set; }
        public double CalculateAverage()
        {
            return TotalSum / (double)TotalNodes;
        }
    }

    public class Node637V1
    {
        public Node637V1 Left { get; set; }
        public Node637V1 Right { get; set; }
        public int Value { get; set; }
    }
}

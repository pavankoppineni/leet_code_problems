using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-good-nodes/
    /// </summary>
    public class Leetcode_3249_CountTheNumberOfGoodNodes_V1
    {
        public int CalculateGoodNodes(int[][] edges)
        {
            if (edges.Length == 0)
            {
                return 0;
            }

            var tree = ConstructTree(edges);
            return 0;
        }

        private (int height, int goodNodes) CalculateGoodNodes(Node3249 node)
        {
            if (node == null)
            {
                return (0, 0);
            }

            if (node.Children.Count == 0)
            {
                return (0, 1);
            }

            var heightSet = new HashSet<int>();
            var goodNodesCount = 0;
            foreach (var child in node.Children)
            {
                var result = CalculateGoodNodes(child);
                heightSet.Add(result.height);
                goodNodesCount += result.goodNodes;
            }

            return (0, 1);
        }

        private static Node3249 ConstructTree(int[][] edges)
        {
            var lookup = new Dictionary<int, Node3249>();
            foreach (var edge in edges)
            {
                var from = edge[0];
                var to = edge[1];
                if (!lookup.ContainsKey(from))
                {
                    var fromNode = Node3249.Create(from);
                    lookup.Add(from, fromNode);
                }

                if (!lookup.ContainsKey(to))
                {
                    var toNode = Node3249.Create(to);
                    lookup.Add(to, toNode);
                }

                lookup[from].Children.Add(lookup[to]);
                lookup[to].Children.Add(lookup[from]);
            }
            return lookup[0];
        }
    }

    public class Node3249
    {
        public int Value { get; set; }
        public IList<Node3249> Children { get; set; }
        public static Node3249 Create(int value)
        {
            return new Node3249
            {
                Value = value,
                Children = new List<Node3249>()
            };
        }
    }
}

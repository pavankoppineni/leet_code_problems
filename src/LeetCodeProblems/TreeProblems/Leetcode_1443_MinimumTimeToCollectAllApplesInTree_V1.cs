using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-to-collect-all-apples-in-a-tree/
    /// </summary>
    public class Leetcode_1443_MinimumTimeToCollectAllApplesInTree_V1
    {
        public int CalculateMinimumTime(int n, int[][] edges, IList<bool> hasApple)
        {
            if (n <= 1)
            {
                return 0;
            }

            var root = ConstructTree(edges, hasApple);
            var result = CalculateMinimumTime(root);
            if (result.foundApple)
            {
                return result.time - 2;
            }

            return 0;
        }

        private (int time, bool foundApple) CalculateMinimumTime(TreeNode1443 node)
        {
            // When : node is null
            if (node == null)
            {
                return (0, false);
            }

            if (node.Visited)
            {
                return (0, false);
            }
            node.Visited = true;

            // When : When node is leaf
            // Then : check node has apple
            if (node.Children.Count == 0)
            {
                // When : leaf has an apple
                if (node.HasApple)
                {
                    return (2, true);
                }

                // When : lead node doesn't have an apple
                return (0, false);
            }

            var hasApple = node.HasApple;
            var time = 0;
            foreach (var child in node.Children)
            {
                var result = CalculateMinimumTime(child);
                hasApple |= result.foundApple;
                time += result.time;
            }

            // When : Child tree's have apple
            if (hasApple)
            {
                return (time + 2, true);
            }

            return (0, false);
        }

        private static TreeNode1443 ConstructTree(int[][] edges, IList<bool> hasApple)
        {
            var lookup = new Dictionary<int, TreeNode1443>();
            foreach (var edge in edges)
            {
                var from = edge[0];
                var to = edge[1];
                if (!lookup.ContainsKey(from))
                {
                    var parentNodeToAdd = TreeNode1443.Create(from, hasApple[from]);
                    lookup.Add(from, parentNodeToAdd);
                }

                if (!lookup.ContainsKey(to))
                {
                    var childNodeToAdd = TreeNode1443.Create(to, hasApple[to]);
                    lookup.Add(to, childNodeToAdd);
                }

                var parentNode = lookup[from];
                var childNode = lookup[to];
                parentNode.Children.Add(childNode);
                childNode.Children.Add(parentNode);
            }
            return lookup[0];
        }
    }

    public class TreeNode1443
    {
        public int Value { get; set; }
        public bool HasApple { get; set; }
        public bool Visited {  get; set; }
        public IList<TreeNode1443> Children { get; init; } = new List<TreeNode1443>();

        public static TreeNode1443 Create(int value, bool hasApple)
        {
            return new TreeNode1443 
            { 
                Value = value, 
                HasApple = hasApple 
            };
        }
    }
}

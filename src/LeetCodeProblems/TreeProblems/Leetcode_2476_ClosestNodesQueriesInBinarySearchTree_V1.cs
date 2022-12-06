using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/closest-nodes-queries-in-a-binary-search-tree/
    /// </summary>
    public class Leetcode_2476_ClosestNodesQueriesInBinarySearchTree_V1
    {
        public IList<IList<int>> ClosestNodes(TreeNode2476 root, IList<int> queries)
        {
            var result = new List<IList<int>>();
            foreach (var query in queries)
            {
                var minMaxResult = CalculateMinMax(query, root, -1, -1);
                var resultItem = new List<int>
                {
                    minMaxResult.min,
                    minMaxResult.max
                };
                result.Add(resultItem);
            }
            return result;
        }

        private (int min, int max) CalculateMinMax(int query, TreeNode2476 node, int min, int max)
        {
            if (node == null)
            {
                return (min, max);
            }
            //When : Query is equal to node value
            //Then : Return min and max
            if (query == node.Value)
            {
                return (query, query);
            }

            //When : Query is greater than node value
            //Then : Set node value as min
            if (query > node.Value)
            {
                return CalculateMinMax(query, node.Right, node.Value, max);
            }

            //When : Query is less than node value
            //Then : Set node value as max
            return CalculateMinMax(query, node.Left, min, node.Value);
        }
    }

    public class TreeNode2476
    {
        public int Value { get; set; }
        public TreeNode2476 Left { get; set; }
        public TreeNode2476 Right { get; set; }
    }
}

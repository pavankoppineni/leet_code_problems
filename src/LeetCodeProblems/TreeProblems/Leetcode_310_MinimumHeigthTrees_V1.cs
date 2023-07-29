using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-height-trees/
    /// </summary>
    public class Leetcode_310_MinimumHeigthTrees_V1
    {
        private IDictionary<int, IList<int>> _tree;
        private bool[] _visited;
        public IList<int> CalculateMinimumHeightTreeRoots(int nodes, int[][] edges)
        {
            if (nodes == 1)
            {
                return new List<int>() { 0 };
            }
            _tree = ConstructTree(edges);
            _visited = new bool[nodes];
            var heightMemoryTable = new Dictionary<int, IList<int>>();
            var minimumHeight = int.MaxValue;
            for (var index = 0; index < nodes; index++)
            {
                var height = CalculateHeight(index);
                if (!heightMemoryTable.ContainsKey(height))
                {
                    heightMemoryTable.Add(height, new List<int>());
                }
                heightMemoryTable[height].Add(index);
                minimumHeight = Math.Min(minimumHeight, height);
            }
            return heightMemoryTable[minimumHeight];
        }

        private int CalculateHeight(int node)
        {
            if (_tree[node].Count == 0)
            {
                return 0;
            }

            if (_visited[node])
            {
                return 0;
            }
            _visited[node] = true;
            var height = -1;
            foreach (var children in _tree[node])
            {
                if (_visited[children])
                {
                    continue;
                }
                var currentHeight = CalculateHeight(children) + 1;
                height = Math.Max(height, currentHeight);
            }
            _visited[node] = false;
            return height;
        }

        private IDictionary<int, IList<int>> ConstructTree(int[][] edges)
        {
            var tree = new Dictionary<int, IList<int>>();
            foreach (var edge in edges)
            {
                var from = edge[0];
                var to = edge[1];
                if (!tree.ContainsKey(from))
                {
                    tree.Add(from, new List<int>());
                }
                if (!tree.ContainsKey(to))
                {
                    tree.Add(to, new List<int>());
                }
                tree[from].Add(to);
                tree[to].Add(from);
            }
            return tree;
        }
    }
}

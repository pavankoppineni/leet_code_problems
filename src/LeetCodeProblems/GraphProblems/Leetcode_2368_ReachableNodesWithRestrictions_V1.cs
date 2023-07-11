using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.GraphProblems
{
    /// <summary>
    /// https://leetcode.com/problems/reachable-nodes-with-restrictions/
    /// </summary>
    public class Leetcode_2368_ReachableNodesWithRestrictions_V1
    {
        private IDictionary<int, List<int>> _graph;
        private bool[] _visited;
        private ISet<int> _restrictedNodes;
        public int CalculateReachablesNodes(int n, int[][] edges, int[] restricted)
        {
            _restrictedNodes = new HashSet<int>();
            _visited = new bool[n];
            _graph = CreateGraph(edges);
            foreach (var restrictedNode in restricted)
            {
                _restrictedNodes.Add(restrictedNode);
            }
            return CalculateReachableNodes(0);
        }

        private int CalculateReachableNodes(int index)
        {
            if (_restrictedNodes.Contains(index))
            {
                return 0;
            }

            if (_visited[index])
            {
                return 0;
            }
            _visited[index] = true;
            if (!_graph.ContainsKey(index))
            {
                return 1;
            }

            var count = 0;
            foreach (var node in _graph[index])
            {
                if (_visited[node])
                {
                    continue;
                }
                count += CalculateReachableNodes(node);
            }
            return count + 1;
        }

        private static IDictionary<int, List<int>> CreateGraph(int[][] edges)
        {
            var graph = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                {
                    graph.Add(edge[0], new List<int>());
                }
                if (!graph.ContainsKey(edge[1]))
                {
                    graph.Add(edge[1], new List<int>());
                }
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }
            return graph;
        }
    }
}

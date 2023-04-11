using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/all-paths-from-source-to-target/
    /// </summary>
    public class Leetcode_797_AllPathsFromSourceToTarget_V1
    {
        private IList<IList<int>> _paths;
        private int[][] _graph;
        public IList<IList<int>> GenerateAllPaths(int[][] graph)
        {
            _graph = graph;
            _paths = new List<IList<int>>();
            var path = new Stack<int>();
            path.Push(0);
            GenerateAllPaths(0, path);
            path.Pop();
            return _paths;
        }

        private void GenerateAllPaths(int node, Stack<int> path)
        {
            if (node == _graph.Length - 1)
            {
                var pathList = path.ToArray();
                Array.Reverse(pathList);
                _paths.Add(pathList);
                return;
            }

            foreach (var destination in _graph[node])
            {
                path.Push(destination);
                GenerateAllPaths(destination, path);
                path.Pop();
            }
        }
    }
}

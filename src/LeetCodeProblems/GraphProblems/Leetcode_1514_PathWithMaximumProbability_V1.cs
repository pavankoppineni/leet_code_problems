using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.GraphProblems
{
    /// <summary>
    /// https://leetcode.com/problems/path-with-maximum-probability/
    /// </summary>
    public class Leetcode_1514_PathWithMaximumProbability_V1
    {
        public decimal CalculateMaximumProbability(int n, int[][] edges, double[] succProbability, int startNode, int endNode)
        {
            var graph = new Graph_1514_Builder()
                                .AddEdges(edges)
                                .AddProbabilities(succProbability)
                                .Build();
            return 0;
        }

        public class ProbabilityCalculator
        {
            private readonly bool[] _visited;
            private readonly IDictionary<int, List<(int vertex, double probability)>> _graph;
            private readonly int _endVertex;
            public ProbabilityCalculator(IDictionary<int, List<(int vertex, double probability)>> graph,
                int endVertex)
            {
                _graph = graph;
                _endVertex = endVertex;
                _visited = new bool[graph.Count];
            }

            public double Calculate(int startVertex)
            {
                _visited[startVertex] = true;
                return 0;
            }
        }

        internal class Graph_1514_Builder
        {
            private readonly IDictionary<int, List<(int vertex, double probability)>> _graph;
            private int[][] _edges;
            private double[] _probabilities;

            internal Graph_1514_Builder()
            {
                _graph = new Dictionary<int, List<(int vertex, double probability)>>();
            }

            public Graph_1514_Builder AddEdges(int[][] edges)
            {
                _edges = edges;
                return this;
            }

            public Graph_1514_Builder AddProbabilities(double[] probabilities)
            {
                _probabilities = probabilities;
                return this;
            }

            private void AddEdge(int start, int end, double probability)
            {
                if (!_graph.ContainsKey(start))
                {
                    _graph.Add(start, []);
                }
                _graph[start].Add((end, probability));
            }

            public IDictionary<int, List<(int vertex, double probability)>> Build()
            {
                for (var index = 0; index < _edges.Length; index++)
                {
                    var edge = _edges[index];
                    AddEdge(edge[0], edge[1], _probabilities[index]);
                    AddEdge(edge[1], edge[0], _probabilities[index]);
                }
                return _graph;
            }
        }
    }
}

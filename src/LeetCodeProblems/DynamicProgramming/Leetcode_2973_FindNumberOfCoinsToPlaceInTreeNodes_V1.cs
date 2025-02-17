using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/find-number-of-coins-to-place-in-tree-nodes/
    /// </summary>
    public class Leetcode_2973_FindNumberOfCoinsToPlaceInTreeNodes_V1
    {
        private long[] _coins;
        public long[] CalculateCoins(int[][] edges, int[] cost)
        {
            _coins = new long[cost.Length];
            var tree = ConstructTree(edges, cost);
            return Array.Empty<long>();
        }

        private (long[] values, int count) CalculateCoins(Node2973 node)
        {
            var count = 1;
            if (node.Children.Count == 0)
            {
                _coins[node.Index] = 1;
                return (new long[] { node.Cost }, count);
            }

            var coinsSet = new List<long[]>();
            foreach (var child in node.Children)
            {
                var coins = CalculateCoins(child);
                count += coins.count;
                coinsSet.Add(coins.values);
            }

            var mergedCoins = Divide(coinsSet, 0, coinsSet.Count - 1);
            return (mergedCoins, count);
        }

        private long[] Divide(IList<long[]> coins, int start, int end)
        {
            if (start == end)
            {
                return coins[start];
            }

            var half = (end - start) >> 1;
            var mid = start + half;
            var leftCoins = Divide(coins, start, mid);
            var rightCoins = Divide(coins, mid + 1, end);
            return Merge(leftCoins, rightCoins);
        }

        private long[] Merge(long[] leftCoins, long[] rightCoins)
        {
            var coins = new long[leftCoins.Length + rightCoins.Length];
            var leftIndex = 0;
            var rightIndex = 0;
            var index = 0;
            while (leftIndex < leftCoins.Length && rightIndex < rightCoins.Length)
            {
                if (leftCoins[leftIndex] < rightCoins[rightIndex])
                {
                    coins[index] = leftCoins[leftIndex];
                    leftIndex++;
                    index++;
                    continue;
                }
                coins[index] = rightCoins[rightIndex];
                rightIndex++;
                index++;
            }
            while (leftIndex < leftCoins.Length)
            {
                coins[index] = leftCoins[leftIndex];
                leftIndex++;
            }
            while (rightIndex < rightCoins.Length)
            {
                coins[index] = rightCoins[rightIndex];
                rightIndex++;
            }
            return coins;
        }

        private Node2973 ConstructTree(int[][] edges, int[] cost)
        {
            var lookup = new Dictionary<int, Node2973>();
            foreach (var edge in edges)
            {
                var nodeStart = edge[0];
                var nodeEnd = edge[1];
                if (!lookup.ContainsKey(nodeStart))
                {
                    lookup.Add(nodeStart, Node2973.Create(cost[nodeStart], nodeStart));
                }
                var childNode = Node2973.Create(cost[nodeEnd], nodeEnd);
                lookup[nodeStart].Children.Add(childNode);
                if (!lookup.ContainsKey(nodeEnd))
                {
                    lookup.Add(nodeEnd, childNode);
                }
            }
            return lookup[0];
        }
    }

    public class Node2973
    {
        public int Cost { get; set; }
        public int Index {  get; set; }
        public IList<Node2973> Children { get; set; } = new List<Node2973>();

        public static Node2973 Create(int cost, int index)
        {
            return new Node2973
            {
                Cost = cost,
                Index = index
            };
        }
    }
}

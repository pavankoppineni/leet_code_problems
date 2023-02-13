using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.TreeProblems
{
    /// <summary>
    /// https://leetcode.com/problems/time-needed-to-inform-all-employees/
    /// </summary>
    public class Leetcode_1376_TimeNeededToInformAllEmployees_V1
    {
        public int CalculateNumberOfMinutes(int n, int headId, int[] manager, int[] informTime)
        {
            var root = ConstructTree(n, headId, manager, informTime);
            return CalculateNumberOfMinutes(root);
        }

        private Node1376 ConstructTree(int n, int headId, int[] manager, int[] informTime)
        {
            var lookup = new Dictionary<int, Node1376>();
            for (var index = 0; index < n; index++)
            {
                lookup.Add(index, Node1376.Create(index, informTime[index]));
            }
            lookup[headId].Manager = -1;

            for (var index = 0; index < manager.Length; index++)
            {
                if (headId == index)
                {
                    continue;
                }
                var currentEmployee = lookup[index];
                var managerOfCurrentEmployee = lookup[manager[index]];
                managerOfCurrentEmployee.Subordinates.Add(currentEmployee);
            }

            return lookup[headId];
        }

        private int CalculateNumberOfMinutes(Node1376 node)
        {
            if (node.Subordinates.Count == 0)
            {
                return 0;
            }

            var informTime = 0;
            foreach (var subordinate in node.Subordinates)
            {
                var currentInformTime = node.InformTime + CalculateNumberOfMinutes(subordinate);
                informTime = Math.Max(informTime, currentInformTime);
            }
            return informTime;
        }
    }

    public class Node1376
    {
        public int Index { get; private set; }
        public int Manager { get; set; }
        public int InformTime { get; private set; }
        public IList<Node1376> Subordinates { get; private set; }

        public static Node1376 Create(int index, int informTime)
        {
            var node = new Node1376()
            {
                InformTime = informTime,
                Index = index,
                Subordinates = new List<Node1376>()
            };
            return node;
        }
    }
}

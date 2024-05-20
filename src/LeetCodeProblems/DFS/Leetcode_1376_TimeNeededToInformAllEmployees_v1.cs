using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DFS
{
    /// <summary>
    /// https://leetcode.com/problems/time-needed-to-inform-all-employees/
    /// </summary>
    public class Leetcode_1376_TimeNeededToInformAllEmployees_v1
    {
        public int CalculateTimeNeeded(int n, int headId, int[] manager, int[] informTime)
        {
            var tree = ConstructTree(manager, headId, informTime);
            return tree.CalculateTotalTime();
        }

        private Node1376 ConstructTree(int[] managers, int headId, int[] informTime)
        {
            var employeeLookup = new Dictionary<int, Node1376>();
            for (var index = 0; index < managers.Length; index++)
            {
                // When : manager is -1
                if (managers[index] == -1)
                {
                    if (!employeeLookup.ContainsKey(index))
                    {
                        var headNode = new Node1376(index, informTime[index]);
                        employeeLookup.Add(index, headNode);
                    }
                    continue;
                }

                if (!employeeLookup.TryGetValue(index, out Node1376 subOrdinate))
                {
                    subOrdinate = new Node1376(index, informTime[index]);
                    employeeLookup.Add(index, subOrdinate);
                }

                var managerId = managers[index];
                if (!employeeLookup.TryGetValue(managerId, out Node1376 managerNode))
                {
                    managerNode = new Node1376(managerId, informTime[managerId]);
                    employeeLookup.Add(managerId, managerNode);
                }
                employeeLookup[managerId].AddChild(subOrdinate);
            }

            return employeeLookup[headId];
        }

        internal class Node1376
        {
            internal Node1376(int empId, int informTime)
            {
                EmpId = empId;
                ChildNodes = new List<Node1376>();
                InformTime = informTime;
            }

            internal int InformTime { get; }
            internal int EmpId { get; }
            internal IList<Node1376> ChildNodes { get; }

            internal void AddChild(Node1376 subOrdinate)
            {
                ChildNodes.Add(subOrdinate);
            }

            internal int CalculateTotalTime()
            {
                if (ChildNodes.Count == 0)
                {
                    return 0;
                }

                var max = -1;
                foreach (var node in ChildNodes)
                {
                    max = Math.Max(max, node.CalculateTotalTime());
                }
                return InformTime + max;
            }
        }
    }
}

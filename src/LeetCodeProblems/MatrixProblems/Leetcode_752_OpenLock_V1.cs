using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.MatrixProblems
{
    /// <summary>
    /// https://leetcode.com/problems/open-the-lock
    /// </summary>
    public class Leetcode_752_OpenLock_V1
    {
        private HashSet<string> _visited = new HashSet<string>();
        private HashSet<string> _deadEnds;
        private string _target;
        public int CalculateMinimumMoves(string[] deadends, string target)
        {
            _deadEnds = deadends.ToHashSet();
            _target = target;
            return 0;
        }

        private int CalculateMinimumMoves()
        {
            var queue = new Queue<int[]>();
            queue.Enqueue([0, 0, 0, 0]);
            while(queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
            }
            return 0;
        }

        private bool ReachedTarget(string target)
        {
            return false;
        }
    }
}

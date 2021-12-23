using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BFS.Leetcode_1306_JumpGame
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game-iii/
    /// </summary>
    public class Leetcode_1306_JumpGame_V1
    {
        private int _jumpsLength;
        public bool CanReach(int[] jumps, int start)
        {
            _jumpsLength = jumps.Length;
            var visited = new bool[jumps.Length];
            var reachable = false;
            var queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                var index = queue.Dequeue();
                if (!IsValidIndex(index))
                {
                    continue;
                }
                if (jumps[index] == 0)
                {
                    reachable = true;
                    break;
                }
                if (visited[index])
                {
                    continue;
                }
                visited[index] = true;
                queue.Enqueue(index + jumps[index]);
                queue.Enqueue(index - jumps[index]);
            }
            return reachable;
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < _jumpsLength;
        }
    }
}

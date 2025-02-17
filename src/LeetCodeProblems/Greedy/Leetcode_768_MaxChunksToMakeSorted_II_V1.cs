using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/max-chunks-to-make-sorted-ii/
    /// </summary>
    public class Leetcode_769_MaxChunksToMakeSorted_II_V1
    {
        public int CalculateNumberOfChunks(int[] values)
        {
            if (values.Length == 1)
            {
                return 1;
            }

            var stack = new Stack<int>();
            stack.Push(values[0]);
            for (var index = 1; index < values.Length; index++)
            {
                var current = values[index];
                while (true)
                {
                    var prev = stack.Peek();
                    if (current <= prev)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(current);
                        break;
                    }

                    if (stack.Count == 0)
                    {
                        stack.Push(current);
                        break;
                    }
                }
            }
            return stack.Count;
        }
    }
}

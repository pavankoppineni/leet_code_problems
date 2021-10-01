using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_962_MaximumRampWidth
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-width-ramp/
    /// </summary>
    public class Leetcode_962_MaximumWidthRamp_V3
    {
        public int FindMaximumWidthRamp(int[] values)
        {
            var stack = new Stack<int>();
            stack.Push(0);
            for (var index = 1; index < values.Length; index++)
            {
                var top = stack.Peek();
                if (values[index] < values[top])
                {
                    stack.Push(index);
                }
            }

            var maxWidth = 0;
            for (var index = values.Length - 1; index >= 0; index--)
            {
                if (stack.Count == 0)
                {
                    break;
                }

                while (stack.Count > 0)
                {
                    var peekIndex = stack.Peek();
                    var peekValue = values[peekIndex];
                    var currentValue = values[index];
                    if(currentValue >= peekValue)
                    {
                        var currentMaxWidth = index - peekIndex;
                        if (currentMaxWidth > maxWidth)
                        {
                            maxWidth = currentMaxWidth;
                        }
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return maxWidth;
        }
    }
}

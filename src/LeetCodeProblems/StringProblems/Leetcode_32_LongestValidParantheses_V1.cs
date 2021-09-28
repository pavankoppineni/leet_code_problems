using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/longest-valid-parentheses/
    /// </summary>
    public class Leetcode_32_LongestValidParantheses_V1
    {
        public int FindLongestValidParantheses(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return 0;
            }

            var max = 0;
            var stack = new Stack<int>();
            for (var index = 0; index < s.Length; index++)
            {
                if (stack.Count == 0 || s[index] == '(')
                {
                    stack.Push(index);
                    continue;
                }

                if (s[index] == ')')
                {
                    var topIndex = stack.Peek();
                    if (s[topIndex] == '(')
                    {
                        stack.Pop();
                        if (stack.Count == 0)
                        {
                            topIndex = 0;
                        }
                        else
                        {
                            topIndex = stack.Peek();
                        }
                        var len = index - topIndex;
                        if (len > max)
                        {
                            max = len;
                        }
                    }
                    else
                    {
                        stack.Push(index);
                    }
                }
            }
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/
    /// </summary>
    public class Leetcode_22_GenerateParentheses_V1
    {
        public IList<string> GenerateParantheses(int n)
        {
            GenerateParantheses(0, n, 0, 0, new Stack<char>());
            return null;
        }

        private void GenerateParantheses(int index, int length, int openCount, int closeCount, Stack<char> parantheses)
        {
            if (closeCount == length)
            {
                var arr = parantheses.ToArray();
                Array.Reverse(arr);
                Debug.WriteLine(new string(arr));
                return;
            }
            if (openCount < length)
            {
                parantheses.Push('{');
                GenerateParantheses(index + 1, length, openCount + 1, closeCount, parantheses);
                parantheses.Pop();
            }

            if (openCount > closeCount)
            {
                parantheses.Push('}');
                GenerateParantheses(index + 1, length, openCount, closeCount + 1, parantheses);
                parantheses.Pop();
            }
        }
    }
}

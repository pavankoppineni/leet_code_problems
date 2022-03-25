using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_402_RemoveKDigits
{
    /// <summary>
    /// https://leetcode.com/problems/remove-k-digits/
    /// </summary>
    public class Leetcode_402_RemoveKDigits_V1
    {
        ///<inheritdoc/>
        public string RemoveKDigits(string num, int k)
        {
            if (num.Length == k)
            {
                return "0";
            }

            var stack = new Stack<char>();
            stack.Push(num[0]);
            var index = 1;
            while (k > 0 && index < num.Length)
            {
                var current = num[index];
                var previous = stack.Peek();
                if (previous > current)
                {
                    stack.Pop();
                    stack.Push(current);
                    k--;
                }
                else
                {
                    stack.Push(current);
                }
                index++;
            }
            while (index < num.Length)
            {
                stack.Push(num[index]);
                index++;
            }
            while (k > 0)
            {
                stack.Pop();
                k--;
            }
            var charArray = stack.ToArray();
            Array.Reverse(charArray);
            var result = new string(charArray);
            return int.Parse(result).ToString();
        }
    }
}

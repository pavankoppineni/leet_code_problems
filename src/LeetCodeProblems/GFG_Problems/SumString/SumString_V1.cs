using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GFG_Problems.SumString
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/sum-string3151/1
    /// </summary>
    public class SumString_V1
    {
        private IDictionary<(int start, int end), int> _lookup;
        private char[] _charArray;
        private Stack<int> _stack;
        public bool IsSumString(string str)
        {
            _lookup = new Dictionary<(int start, int end), int>();
            _stack = new Stack<int>();
            _charArray = str.ToCharArray();
            return IsSumString(0, str.Length - 1);
        }

        private bool IsSumString(int start, int end)
        {
            if (start > end)
            {
                if (_stack.Count <= 2)
                {
                    return false;
                }

                var numbersArray = _stack.ToArray();
                var lastIndex = numbersArray.Length - 1;
                for (var index = lastIndex - 2; index >= 0; index--)
                {
                    if (numbersArray[index] != numbersArray[index + 1] + numbersArray[index + 2])
                    {
                        return false;
                    }
                }
                return true;
            }

            var result = false;
            for (var index = start; index <= end; index++)
            {
                _stack.Push(GetNumber(start, index));
                result = result || IsSumString(index + 1, end);
                if (result)
                {
                    break;
                }
                _stack.Pop();
            }
            return result;
        }

        private int GetNumber(int start, int end)
        {
            if (_lookup.ContainsKey((start, end)))
            {
                return _lookup[(start, end)];
            }

            var number = 0;
            for (var index = start; index <= end; index++)
            {
                var currentNumber = _charArray[index] - '0';
                number = number * 10 + currentNumber;
            }
            _lookup.Add((start, end), number);
            return number;
        }
    }
}

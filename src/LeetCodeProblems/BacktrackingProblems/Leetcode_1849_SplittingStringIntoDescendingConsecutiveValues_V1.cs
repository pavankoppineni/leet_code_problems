using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/splitting-a-string-into-descending-consecutive-values/description/
    /// </summary>
    public class Leetcode_1849_SplittingStringIntoDescendingConsecutiveValues_V1
    {
        private IDictionary<Tuple<int, int>, long> _stringToNumber = new Dictionary<Tuple<int, int>, long>();
        private string _input;
        public bool SplitString(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 2)
            {
                return false;
            }

            _input = s;
            return SplitString(0, _input.Length - 1, long.MaxValue);
        }

        private bool SplitString(int start, int end, long previous)
        {
            if (start > end)
            {
                return true;
            }

            var result = false;
            for (var index = start; index <= end; index++)
            {
                var tuple = Tuple.Create(start, index);
                long number = 0;
                if (_stringToNumber.ContainsKey(tuple))
                {
                    number = _stringToNumber[tuple];
                }
                else
                {
                    var subStr = _input.Substring(start, index - start + 1);
                    number = long.Parse(subStr);
                    _stringToNumber.Add(tuple, number);
                }

                var len = start - index + 1;
                var diff = number - previous;
                if (diff != -1 || len == _input.Length)
                {
                    result = false;
                    break;
                }

                result |= SplitString(index + 1, end, number);
            }

            return result;
        }
    }
}

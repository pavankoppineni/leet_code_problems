using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_942_DIStringMatch
{
    /// <summary>
    /// https://leetcode.com/problems/di-string-match/
    /// </summary>
    public class Leetcode_942_DIStringMatch_V1
    {
        public const char INCREMENT = 'I';
        public const char DECREMENT = 'D';

        private string _str;
        private int[] _values;
        public int[] FindStringMatch(string str)
        {
            _str = str;
            _values = new int[str.Length + 1];
            for (var index = 0; index <= str.Length; index++)
            {
                _values[index] = index;
            }
            for (var index = 0; index <= _str.Length; index++)
            {
                Swap(index, 0);
                var result = FindStringMatch(1, str[0]);
                if (result)
                {
                    break;
                }
                Swap(index, 0);
            }
            return _values;
        }

        private bool FindStringMatch(int level, char prev)
        {
            if (level == _str.Length)
            {
                if (prev == INCREMENT)
                {
                    return _values[_str.Length] > _values[_str.Length - 1];
                }
                return _values[_str.Length] < _values[_str.Length - 1];
            }
            for (var index = level; index <= _str.Length; index++)
            {
                Swap(index, level);
                var currentValue = _values[level];
                if (prev == INCREMENT)
                {
                    if (currentValue < _values[level - 1])
                    {
                        continue;
                    }
                    if (FindStringMatch(level + 1, _str[level]))
                    {
                        return true;
                    }
                }
                else
                {
                    if (currentValue > _values[level - 1])
                    {
                        continue;
                    }
                    if (FindStringMatch(level + 1, _str[level]))
                    {
                        return true;
                    }
                }
                Swap(index, level);
            }
            return false;
        }

        private void Swap(int left, int right)
        {
            var temp = _values[left];
            _values[left] = _values[right];
            _values[right] = temp;  
        }
    }
}

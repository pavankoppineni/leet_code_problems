using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_2375_ConstructSmallestNumberFromDIString
{
    /// <summary>
    /// https://leetcode.com/problems/construct-smallest-number-from-di-string/
    /// </summary>
    public class Leetcode_2375_ConstructSmallestNumberFromDIString_V1
    {
        public const char INCREMENT = 'I';
        public const char DECREMENT = 'D';

        private string _str;
        private int[] _values;
        private string _permutation;
        public string SmallestNumber(string str)
        {
            _str = str;
            _values = new int[str.Length + 1];
            for (var index = 0; index <= str.Length; index++)
            {
                _values[index] = index + 1;
            }
            for (var index = 0; index <= _str.Length; index++)
            {
                Swap(index, 0);
                FindStringMatch(1, str[0]);
                Swap(index, 0);
            }
            return _permutation;
        }

        private void FindStringMatch(int level, char prev)
        {
            if (level == _str.Length)
            {
                var increment = prev == INCREMENT && _values[_str.Length] < _values[_str.Length - 1];
                var decrement = prev == DECREMENT && _values[_str.Length] > _values[_str.Length - 1];
                if (increment || decrement)
                {
                    return;
                }

                var currentPermitation = new string(_values.Select(item => (char)item).ToArray());
                if (_permutation == null)
                {
                    _permutation = currentPermitation;
                }
                _permutation = _permutation.CompareTo(currentPermitation) <= 0 ? _permutation : currentPermitation;
            }

            for (var index = level; index <= _str.Length; index++)
            {
                Swap(index, level);
                var currentValue = _values[level];
                if (prev == INCREMENT)
                {
                    if (currentValue > _values[level - 1])
                    {
                        FindStringMatch(level + 1, _str[level]);
                    }
                }
                else
                {
                    if (currentValue < _values[level - 1])
                    {
                        FindStringMatch(level + 1, _str[level]);
                    }
                }
                Swap(index, level);
            }
        }

        private void Swap(int left, int right)
        {
            var temp = _values[left];
            _values[left] = _values[right];
            _values[right] = temp;
        }
    }
}

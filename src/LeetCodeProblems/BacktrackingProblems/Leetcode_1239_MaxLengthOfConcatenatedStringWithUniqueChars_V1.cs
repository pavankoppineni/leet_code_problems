using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/description/
    /// </summary>
    public class Leetcode_1239_MaxLengthOfConcatenatedStringWithUniqueChars_V1
    {
        private IList<string> _values;
        public int MaxLength(IList<string> arr)
        {
            _values = new List<string>();
            var precalculatedLookup = PrecalculateUniqueCharacters(arr);
            foreach (var value in precalculatedLookup)
            {
                if (value.Value)
                {
                    _values.Add(value.Key);
                }
            }

            if (_values.Count == 0)
            {
                return 0;
            }

            if (_values.Count == 1)
            {
                return _values[0].Length;
            }

            return CalculateMaxLength(0, new HashSet<char>());
        }

        private int CalculateMaxLength(int index, ISet<char> charactersSet)
        {
            if (index >= _values.Count)
            {
                return 0;
            }

            var currentValue = _values[index];
            var countWithoutCurrent = CalculateMaxLength(index + 1, charactersSet);
            var canAddValue = CanAddValue(currentValue, charactersSet);
            if (!canAddValue)
            {
                return countWithoutCurrent;
            }

            var countWithCurrent = 0;
            foreach (var item in currentValue)
            {
                charactersSet.Add(item);
            }
            countWithCurrent = currentValue.Length + CalculateMaxLength(index + 1, charactersSet);
            foreach (var item in currentValue)
            {
                charactersSet.Remove(item);
            }

            return Math.Max(countWithCurrent, countWithoutCurrent);
        }

        private IDictionary<string, bool> PrecalculateUniqueCharacters(IList<string> arr)
        {
            var lookup = new Dictionary<string, bool>();
            foreach (var str in arr)
            {
                var hasUniqueChars = true;
                var set = new HashSet<char>();
                foreach (var ch in str)
                {
                    if (set.Contains(ch))
                    {
                        hasUniqueChars = false;
                        break;
                    }
                    set.Add(ch);
                }
                lookup[str] = hasUniqueChars;
            }

            return lookup;
        }

        private bool CanAddValue(string value, ISet<char> charactersSet)
        {
            foreach (var item in value)
            {
                if (charactersSet.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

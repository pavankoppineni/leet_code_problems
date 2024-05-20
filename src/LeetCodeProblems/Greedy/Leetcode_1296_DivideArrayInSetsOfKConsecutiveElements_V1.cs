using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    public class Leetcode_1296_DivideArrayInSetsOfKConsecutiveElements_V1
    {
        IDictionary<int, int> _lookup;
        SortedSet<int> _sortedSet;
        int _sequenceLength;
        public bool CanDivideArray(int[] numbers, int k)
        {
            _sequenceLength = k;
            (_lookup, _sortedSet) = ConstructLookup(numbers);
            var min = _sortedSet.Min();
            HasSequence(min);
            return true;
        }

        private (bool, int min) HasSequence(int start)
        {
            var result = true;
            var min = -1;
            var currentLength = 0;
            while (true)
            {
                // When : start is present in lookup
                // Then 
                if (_lookup.ContainsKey(start))
                {
                    var value = _lookup[start];
                    _lookup[start] -= 1;
                    if (value == 0)
                    {
                        _sortedSet.Remove(start);
                    }
                    else
                    {
                        if (min == -1)
                        {
                            min = start;
                        }
                    }
                    start += 1;
                    currentLength++;
                    if (currentLength == _sequenceLength)
                    {
                        break;
                    }
                    continue;
                }

                // When : start is not present in lookup
                result = false;
                break;
            }

            return (result, min);
        }

        private (IDictionary<int, int> lookup, SortedSet<int> set) ConstructLookup(int[] numbers)
        {
            var lookup = new SortedDictionary<int, int>();
            var set = new SortedSet<int>();
            foreach (var number in numbers)
            {
                if (!lookup.ContainsKey(number))
                {
                    set.Add(number);
                    lookup.Add(number, 0);
                }
                lookup[number]++;
            }
            return (lookup, set);
        }
    }
}

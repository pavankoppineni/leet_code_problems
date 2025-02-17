using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/successful-pairs-of-spells-and-potions/description/
    /// </summary>
    public class Leetcode_2300_SuccessfulPairsOfSpellsAndPortions_V1
    {
        private long _success;
        private int[] _portions;
        public int[] CalculateSuccessfulePairs(int[] spells, int[] portions, int suceess)
        {
            var result = new int[spells.Length];
            Array.Sort(portions);
            _success = suceess;
            _portions = portions;
            var index = 0;
            foreach (var spell in spells)
            {
                    var newSuccess = _success / (decimal)spell;
                    var nextIndex = SearchSuccessfulePair(newSuccess, 0, portions.Length - 1);
                    if (nextIndex < 0)
                    {
                        index++;
                        continue;
                    }

                    result[index] = _portions.Length - nextIndex;
                    index++;
            }

            return result;
        }

        private int SearchSuccessfulePair(decimal success, int start, int end)
        {
            // When : start is equal to end
            if (start == end)
            {
                if ((decimal)_portions[start] >= success)
                {
                    return start;
                }

                return -1;
            }

            //When : start is greater than end
            if (start > end)
            {
                return -1;
            }

            if (end - start == 1)
            {
                if ((decimal)_portions[start] >= success)
                {
                    return start;
                }

                if ((decimal)_portions[end] >= success)
                {
                    return end;
                }

                return -1;
            }

            var mid = ((end - start) / 2) + start;
            if ((decimal)_portions[mid] >= success)
            {
                return SearchSuccessfulePair(success, start, mid);
            }
            return SearchSuccessfulePair(success, mid + 1, end);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/relocate-marbles/
    /// </summary>
    public class Leetcode_2766_RelocateMarbles_V1
    {
        public IList<int> CalculareFinalPositions(int[] marbles, int[] from, int[] to)
        {
            var marblesDictionary = new Dictionary<int, int>();
            foreach (var marble in marbles)
            {
                if (!marblesDictionary.ContainsKey(marble))
                {
                    marblesDictionary.Add(marble, 0);
                }
                marblesDictionary[marble] += 1;
            }

            for (var index = 0; index < from.Length; index++)
            {
                var fromPosition = from[index];
                var toPosition = to[index];
                if (fromPosition == toPosition)
                {
                    continue;
                }
                if (marblesDictionary.TryGetValue(fromPosition, out int count))
                {
                    if (!marblesDictionary.ContainsKey(toPosition))
                    {
                        marblesDictionary.Add(toPosition, 0);
                    }
                    marblesDictionary[toPosition] += count;
                    marblesDictionary.Remove(fromPosition);
                }
            }

            var finalPositions = marblesDictionary.Keys
                                        .OrderBy(x => x)
                                        .ToList();
            return finalPositions;
        }
    }
}

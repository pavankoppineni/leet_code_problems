using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    public class Pair
    {
        public int Start { get; set; }
        public int End { get; set; }
    }

    /// <summary>
    /// https://leetcode.com/problems/interval-list-intersections
    /// </summary>
    public class Leetcode_986_IntervalListIntersections_V1
    {
        public int[][] CalculateIntervalIntersections(int[][] firstList, int[][] secondList)
        {
            var values = ConstructValues(firstList, secondList);
            for (var index = 1; index < values.Length; index++)
            {
                values[index] += values[index - 1];
            }
            var intersectionPairs = new List<Pair>();
            var currentPair = new Pair();
            for (var index = 1; index < values.Length; index++)
            {
                var currentValue = values[index];
                var previousValue = values[index - 1];

                if (currentValue == 2 && previousValue <= 1)
                {
                    currentPair = new Pair
                    {
                        Start = index
                    };
                    continue;
                }

                if (currentValue <= 1 && previousValue == 2)
                {
                    currentPair.End = index - 1;
                    intersectionPairs.Add(currentPair);
                    currentPair = null;
                }
            }

            var intersections = new int[intersectionPairs.Count][];
            foreach (var pair in intersectionPairs)
            {
                intersections[0] = new int[] { pair.Start, pair.End };
            }

            return intersections;
        }

        private int[] ConstructValues(int[][] firstList, int[][] secondList)
        {
            var firstListLength = firstList.Length;
            var secondListLength = secondList.Length;
            var max = Math.Max(firstList[firstListLength - 1][1], secondList[secondListLength - 1][1]);
            var values = new int[max + 2];
            foreach (var pair in firstList)
            {
                values[pair[0]] += 1;
                values[pair[1] + 1] -= 1;
            }

            foreach (var pair in secondList)
            {
                values[pair[0]] += 1;
                values[pair[1] + 1] -= 1;
            }

            return values;
        }
    }
}

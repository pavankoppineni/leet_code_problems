using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/beautiful-towers-ii/
    /// </summary>
    public class Leetcode_2866_BeautifulTowers_II_V1
    {
        private int[] _maxHeights;
        public int CalculateMaximumSumOfHeights(int[] heights)
        {
            _maxHeights = heights;
            return 0;
        }

        private int CalculateFromLeftToRight(int[] heights) 
        {
            var node = new Node
            {
                Index = 0,
                Value = heights[0],
                PreviousIndex = -1
            };

            for (var index = 1; index < heights.Length; index++)
            {
                var value = heights[index];
            }
            return 0;
        }
    }

    public class Node
    {
        public int Index { get; set; }
        public int Value { get; set; }
        public int PreviousIndex { get; set; }
    }
}

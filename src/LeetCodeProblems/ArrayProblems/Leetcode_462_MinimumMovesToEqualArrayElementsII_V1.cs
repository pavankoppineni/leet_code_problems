using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/
    /// </summary>
    public class Leetcode_462_MinimumMovesToEqualArrayElementsII_V1
    {
        public int CalculateMinimumNumberOfMoves(int[] numbers)
        {
            Array.Sort(numbers);
            var minMoves = 0;
            var midIndex = numbers.Length / 2;
            for (var index = 0; index < numbers.Length; index++)
            {
                minMoves += Math.Abs(numbers[index] - numbers[midIndex]);
            }
            return minMoves;
        }
    }
}

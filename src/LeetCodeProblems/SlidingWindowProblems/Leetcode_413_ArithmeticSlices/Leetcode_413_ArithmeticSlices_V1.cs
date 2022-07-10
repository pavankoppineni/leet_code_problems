using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SlidingWindowProblems.Leetcode_413_ArithmeticSlices
{
    /// <summary>
    /// https://leetcode.com/problems/arithmetic-slices/
    /// </summary>
    public class Leetcode_413_ArithmeticSlices_V1
    {
        public int CalaculateNumberOfArithmeticSlices(int[] values)
        {
            if (values.Length < 3)
            {
                return 0;
            }

            var numberOfArithmeticSlices = 0;
            var startIndex = 0;
            var endIndex = 1;
            var difference = values[1] - values[0];
            for (var index = 2; index < values.Length; index++)
            {
                var currentDifference = values[index] - values[index - 1];

                //Case One : When currentDifference is equal to difference
                //Action : Do nothing
                if (difference == currentDifference)
                {
                    endIndex = index;
                    continue;
                }
                //Case Two : When currentDifference is not equal to difference
                //Action : Calculate number of sub-arrays
                numberOfArithmeticSlices += CalculateArithmeticSlices(startIndex, endIndex);
                startIndex = index - 1;
                endIndex = index;
                difference = currentDifference;
            }
            numberOfArithmeticSlices += CalculateArithmeticSlices(startIndex, endIndex);
            return numberOfArithmeticSlices;
        }

        private int CalculateArithmeticSlices(int start, int end)
        {
            var sequenceLength = end - start + 1;
            if (sequenceLength < 3)
            {
                return 0;
            }
            var largestLength = sequenceLength - 2;
            return largestLength * (largestLength + 1) / 2;
        }
    }
}

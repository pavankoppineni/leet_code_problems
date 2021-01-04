using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves/
    /// </summary>
    public class Leetcode_1509_MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves_V1
    {
        public int FindMinDifference(int[] values)
        {
            //Base case
            if(values.Length <= 3)
            {
                return 0;
            }

            //Sort values
            Array.Sort(values);

            var minIndex = 0;
            var maxIndex = values.Length - 1;
            var cnt = 0;
            while (minIndex < maxIndex && cnt < 3)
            {
                //Case 1 : Min value and max value are equal
                if (values[minIndex] == values[maxIndex])
                {
                    break;
                }

                //Difference between current minimum value and second greatest value
                var differenceOne = Math.Abs(values[minIndex] - values[maxIndex - 1]);

                //Difference between current maximum value and second smallest value
                var differenceTwo = Math.Abs(values[minIndex + 1] - values[maxIndex]);

                //Case 1 : Difference one is greater than difference two
                if (differenceOne < differenceTwo)
                {
                    maxIndex -= 1;
                }
                else
                {
                    minIndex += 1;
                }
                cnt += 1;
            }

            return Math.Abs(values[minIndex] - values[maxIndex]);
        }
    }
}

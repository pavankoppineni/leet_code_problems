using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-sub-arrays-with-odd-sum/
    /// </summary>
    public class Leetcode_1524_NumberOfSubArraysWithOddSum_V1
    {
        public int CalculateNumberOfSubArrays(int[] values)
        {
            var prevIndex = -1;
            var oddNumberIndex = -1;
            var oddArrayLookup = new long[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                //When : Number is odd
                if (values[index] % 2 > 0)
                {
                    //When : First odd number
                    if (prevIndex == -1)
                    {
                        oddArrayLookup[index] = index + 1;
                    }
                    //When : This is not first odd number
                    //Then : 
                    else
                    {
                        oddArrayLookup[index] = index - prevIndex;
                    }

                    //When : 
                    //Then : 
                    if (oddNumberIndex != -1)
                    {
                        oddArrayLookup[index] += oddArrayLookup[oddNumberIndex];
                    }
                    oddNumberIndex = prevIndex;
                    prevIndex = index;
                }
                //When : Number is even
                //Then :
                else
                {
                    if (prevIndex == -1)
                    {
                        continue;
                    }
                    else
                    {
                        oddArrayLookup[index] = oddArrayLookup[prevIndex];
                    }
                }
            }

            var denominator = 1000000007;
            return (int) (oddArrayLookup.Sum() % denominator);
        }
    }

    public struct OddArrayItem
    {
        public int Left { get; set; }
        public int Right { get; set; }
    }
}

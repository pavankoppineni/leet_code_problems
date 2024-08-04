using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-alternating-subarrays/
    /// </summary>
    public class Leetcode_3101_CountAlternatingSubarrays_V1
    {
        public long CalculateNumberOfSubArrays(int[] values)
        {
            long numberOfSubarrays = 0;
            var start = 0;
            var currentIndex = 1;
            while (currentIndex < values.Length)
            {
                // When : previous and current are not same
                // Then : continue
                if (values[currentIndex] != values[currentIndex - 1])
                {
                    currentIndex++;
                    continue;
                }

                // When : previous and current are same
                // Then : 
                numberOfSubarrays += CalculateSubArrays(start, currentIndex);
                start = currentIndex;
                currentIndex++;
            }

            numberOfSubarrays += CalculateSubArrays(start, currentIndex);
            return numberOfSubarrays;
        }

        private static long CalculateSubArrays(int start, int end)
        {
            long length = end - start;
            return (length * (length + 1)) / 2;
        }
    }
}

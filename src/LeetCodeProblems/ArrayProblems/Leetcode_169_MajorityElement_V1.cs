using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/
    /// </summary>
    public class Leetcode_169_MajorityElement_V1
    {
        public int FindMajorityElement(int[] numbers)
        {
            var majorityElement = numbers[0];
            var currentCount = 1;
            for (var index = 1; index < numbers.Length; index++)
            {
                var currectElement = numbers[index];
                if (majorityElement == currectElement)
                {
                    currentCount += 1;
                }
                else
                {
                    currentCount -= 1;
                }

                if (currentCount <= 0)
                {
                    majorityElement = currectElement;
                    currentCount = 1;
                }
            }



            return majorityElement;
        }
    }
}

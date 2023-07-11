using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays/
    /// </summary>
    public class Leetcode_2657_FindThePrefixCommonArrayOfTwoArrays_V1
    {
        public int[] FindPrefixCommonArray(int[] arrayOne, int[] arrayTwo)
        {
            var result = new int[arrayOne.Length];
            var lookup = new HashSet<int>();
            var previousValue = 0;
            for (var index = 0; index < arrayOne.Length; index++)
            {
                var valueOne = arrayOne[index];
                var valueTwo = arrayTwo[index];

                //When : valueOne and valueTwo are same
                if (valueOne == valueTwo)
                {
                    previousValue += 1;
                    result[index] = previousValue;
                    lookup.Add(valueOne);
                    continue;
                }

                //When : ValueOne is part of lookup
                if (lookup.Contains(valueOne))
                {
                    previousValue += 1;
                }
                //When : ValueOne is not part of lookup
                else
                {
                    lookup.Add(valueOne);
                }

                //When : ValueTwo is part of lookup
                if (lookup.Contains(valueTwo))
                {
                    previousValue += 1;
                }
                else
                {
                    lookup.Add(valueTwo);
                }
                result[index] = previousValue;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public class Leetcode_88_MergeTwoSortedArrays_V1
    {
        public IList<int> Merge(int[] arrayOne, int[] arrayTwo)
        {
            var result = new List<int>();
            var i = 0;
            var j = 0;
            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                var valueOne = arrayOne[i];
                var valueTwo = arrayTwo[j];

                //Case 1 : When valueOne is less than valueTwo
                //Action : 
                if (valueOne < valueTwo)
                {
                    result.Add(valueOne);
                    i += 1;
                }
                //Case 2 : When valueOne is greater than valueTwo
                //Action :
                else if (valueOne > valueTwo)
                {
                    result.Add(valueTwo);
                    j += 1;
                }
                //Case 3 : When valueOne and valueTwo are equal
                //Action : 
                else
                {
                    result.Add(valueTwo);
                    result.Add(valueOne);
                    i += 1;
                    j += 1;
                }
            }

            while (i < arrayOne.Length)
            {
                result.Add(arrayOne[i]);
                i += 1;
            }

            while (j < arrayTwo.Length)
            {
                result.Add(arrayTwo[j]);
                j += 1;
            }

            return result;
        }
    }
}

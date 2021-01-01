using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sort-array-by-parity/
    /// </summary>
    public class Leetcode_905_SortArrayByParity_V1
    {
        public int[] SortyArrayByParity(int[] values)
        {
            var left = 0;
            var right = values.Length - 1;

            while (left < right)
            {
                var leftValue = values[left] & 1;
                var rightValue = values[right] & 1;

                //Case 1 : Left value and right value are odd
                //Action : Decrease right
                if (leftValue == 1 && rightValue == 1)
                {
                    right -= 1;
                }

                //Case 2 : Left value and right value are even
                //Action : Increase left
                else if (leftValue == 0 && rightValue == 0)
                {
                    left += 1;
                }

                //Case 3 : Left value is even and right value is odd
                //Action : Increase left and decrease right
                else if (leftValue == 0 && rightValue == 1)
                {
                    left += 1;
                    right -= 1;
                }

                //Case 4 : Left value is odd and right value is even
                //Action : Swap numbers
                else
                {   
                    var temp = values[left];
                    values[left] = values[right];
                    values[right] = temp;
                }
            }

            return values;
        }
    }
}

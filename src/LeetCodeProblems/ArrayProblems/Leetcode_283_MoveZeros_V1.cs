using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// </summary>
    public class Leetcode_283_MoveZeros_V1
    {
        public int[] MoveZeros(int[] array)
        {
            var slowPointer = 0;
            var fastPointer = 1;
            while (true)
            {
                if (fastPointer >= array.Length)
                {
                    break;
                }

                if(array[fastPointer] == 0)
                {
                    if (array[slowPointer] == 0)
                    {
                        fastPointer += 1;
                    }
                    else
                    {
                        slowPointer += 1;
                        fastPointer += 1;
                    }
                }
                else
                {
                    if (array[slowPointer] == 0)
                    {
                        array[slowPointer] = array[fastPointer];
                        array[fastPointer] = 0;
                    }
                    else
                    {
                        slowPointer += 1;
                        fastPointer += 1;
                    }
                }
            }
            return array;
        }
    }
}

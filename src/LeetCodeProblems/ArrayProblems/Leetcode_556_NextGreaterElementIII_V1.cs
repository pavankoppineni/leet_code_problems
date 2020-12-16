using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/next-greater-element-iii/
    /// </summary>
    public class Leetcode_556_NextGreaterElementIII_V1
    {
        public int NextGreaterElement(int number)
        {
            //Convert number to array
            var numbers = FromNumber(number);

            //Find index of number that breaks ascending order
            var minNumberIndex = FindMinimumNumberIndex(numbers);

            if(minNumberIndex == -1)
            {
                return minNumberIndex;
            }

            //Find index to swap the number with minNumberIndex number
            var swapIndex = FindSwapIndex(numbers, minNumberIndex);

            Swap(swapIndex, minNumberIndex, numbers);

            Array.Reverse(numbers, 0, minNumberIndex);

            var nextGreaterElement = 0;
            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                nextGreaterElement = nextGreaterElement * 10 + numbers[i];
            }

            return nextGreaterElement;
        }

        private int[] FromNumber(int number)
        {
            var numbers = new List<int>();
            while (number > 0)
            {
                var reminder = number % 10;
                number /= 10;
                numbers.Add(reminder);
            }

            return numbers.ToArray();
        }

        private int FindMinimumNumberIndex(int[] numbers)
        {
            var minNumberIndex = -1;
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= numbers[i - 1])
                {
                    continue;
                }
                else
                {
                    minNumberIndex = i;
                    break;
                }
            }

            return minNumberIndex;
        }

        private int FindSwapIndex(int[] numbers, int minNumberIndex)
        {
            var swapIndex = -1;
            var minNumber = numbers[minNumberIndex];
            for(var i = 0; i < minNumberIndex; i++)
            {
                if(numbers[i] > minNumber)
                {
                    swapIndex = i;
                    break;
                }
            }

            return swapIndex;
        }

        private void Swap(int i, int j, int[] numbers)
        {
            var temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}

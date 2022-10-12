using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-xor/
    /// </summary>
    public class Leetcode_2429_MinimizeXOR_V1
    {
        public int CalculateValue(int numberOne, int numberTwo)
        {
            var number = 0;
            var setOne = CalculateNumberOfSetBits(numberOne);
            var setTwo = CalculateNumberOfSetBits(numberTwo);
            var difference = setTwo.Count - setOne.Count;

            //Case 1 : When count of set bits are same
            if (difference == 0)
            {
                return numberOne;
            }

            //Case 2 : When count of set bits in number two are greater
            //than number one
            if (difference > 0)
            {
                foreach (var item in setOne)
                {
                    number |= 1 << item;
                }

                var index = 0;
                while (difference > 0)
                {
                    if (setOne.Contains(index))
                    {
                        index++;
                        continue;
                    }
                    number |= 1 << index;
                    index++;
                    difference--;
                }

                return number;
            }

            //Case 3 : When count of set bits in number two are less
            //than number one
            difference *= -1;
            foreach (var item in setOne)
            {
                if (difference > 0)
                {
                    difference--;
                    continue;
                }
                number |= 1 << item;
            }
            return number;
        }

        private HashSet<int> CalculateNumberOfSetBits(int number)
        {
            var setBitIndices = new HashSet<int>();
            var index = 0;
            var count = 0;
            while (number > 0)
            {
                if ((number & 1) == 1)
                {
                    setBitIndices.Add(index);
                    count++;
                }
                number >>= 1;
                index++;
            }
            return setBitIndices;
        }
    }
}

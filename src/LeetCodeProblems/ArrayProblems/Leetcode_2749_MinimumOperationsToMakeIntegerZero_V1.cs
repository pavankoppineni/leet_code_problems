using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-make-the-integer-zero/
    /// </summary>
    public class Leetcode_2749_MinimumOperationsToMakeIntegerZero_V1
    {
        public int CalculateMinimumOperations(int num1, int num2)
        {
            var operations = FindNumberOfSetBits(num1);
            var remainingNumber = operations * num2;
            var reminaingOperations = FindNumberOfSetBits(remainingNumber);
            return operations + reminaingOperations;
        }

        private int FindNumberOfSetBits(int number)
        {
            var setBitsCount = 0;
            var position = 0;
            while (true)
            {
                var powerOfTwo = 1 << position;
                if (powerOfTwo > number)
                {
                    break;
                }

                if ((powerOfTwo & number) > 0)
                {
                    setBitsCount += 1;
                }
                position += 1;
            }
            return setBitsCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_870_AdvantageShuffle
{
    /// <summary>
    /// https://leetcode.com/problems/advantage-shuffle/
    /// </summary>
    public class Leetcode_870_AdvantageShuffle_V1
    {
        public int[] CalcualteAdvantage(int[] arrOne, int[] arrTwo)
        {
            var result = new int[arrOne.Length];
            Array.Sort(arrOne);
            var numberArray = new List<Number>(arrTwo.Length);
            for (var index = 0; index < arrTwo.Length; index++)
            {
                var number = new Number(index, arrTwo[index]);
                numberArray.Add(number);
            }
            numberArray.Sort(new Number());
            var left = 0;
            var right = arrOne.Length - 1;
            for(var index = arrTwo.Length - 1; index >= 0; index--)
            {
                var arrOneValue = arrOne[right];
                var arrTwoValue = numberArray[index];
                //Case 1 : arrOneValue is greater than arrTwoValue
                if (arrOneValue > arrTwoValue.Value)
                {
                    result[arrTwoValue.Index] = arrOneValue;
                    right--;
                }
                //Case 2 : arrOneValue is less than or equal to arrTwoValue
                else
                {
                    result[arrTwoValue.Index] = arrOne[left];
                    left++;
                }
            }
            return result;
        }
    }

    public class Number : IComparer<Number>
    {
        public Number() { }
        public Number(int index, int value)
        {
            Index = index;
            Value = value;
        }
        public int Index { get; }
        public int Value { get; }

        public int Compare(Number x, Number y)
        {
            return x.Value.CompareTo(y.Value);
        }
    }
}

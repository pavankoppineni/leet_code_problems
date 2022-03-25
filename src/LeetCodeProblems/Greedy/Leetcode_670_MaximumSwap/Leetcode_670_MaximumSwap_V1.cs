using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_670_MaximumSwap
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-swap/
    /// </summary>
    public class Leetcode_670_MaximumSwap_V1
    {
        public int MaximumSwap(int num)
        {
            if (num <= 11)
            {
                return num;
            }

            var list = new List<int>();
            while (num > 0)
            {
                list.Add(num % 10);
                num /= 10;
            }
            var currentMaxIndex = 0;
            var maxIndex = 0;
            var minIndex = 0;
            for (var index = 1; index < list.Count; index++)
            {
                var value = list[index];
                if (value < list[currentMaxIndex])
                {
                    minIndex = index;
                    maxIndex = currentMaxIndex;
                }
                else if (value > list[currentMaxIndex])
                {
                    currentMaxIndex = index;
                }
            }
            var temp = list[maxIndex];
            list[maxIndex] = list[minIndex];
            list[minIndex] = temp;
            var maxNum = 0;
            for(var index = list.Count - 1; index >= 0; index--)
            {
                maxNum *= 10;
                maxNum += list[index];
            }
            return maxNum;
        }
    }
}

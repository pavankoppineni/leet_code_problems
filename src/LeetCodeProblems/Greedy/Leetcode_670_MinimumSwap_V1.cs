using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-swap/description/?envType=problem-list-v2&envId=greedy
    /// </summary>
    public class Leetcode_670_MinimumSwap_V1
    {
        public int Calculate(int num)
        {
            var len = num.ToString().Length;
            var numArray = new int[len];
            var lastIndex = len - 1;
            while (num > 0)
            {
                numArray[lastIndex] = num % 10;
                num /= 10;
                lastIndex--;
            }

            var maxValueItems = new MaxValueItem[numArray.Length];
            var max = -1;
            for (var index = len - 1; index >= 0; index--)
            {
                if (numArray[index] > max)
                {
                    var obj = new MaxValueItem
                    {
                        Value = numArray[index],
                        Index = index
                    };
                    maxValueItems[index] = obj;
                    max = numArray[index];
                    continue;
                }

                maxValueItems[index] = maxValueItems[index + 1];
            }

            for (var index = 0; index < maxValueItems.Length; index++)
            {
                if (numArray[index] != maxValueItems[index].Value)
                {
                    var temp = numArray[index];
                    var newIndex = maxValueItems[index].Index;
                    numArray[index] = maxValueItems[index].Value;
                    numArray[newIndex] = temp;
                    break;
                }
            }

            var cnt = 0;
            for (var index = 0; index< numArray.Length ; index++)
            {
                cnt = numArray[index] + 10 * cnt;
            }

            return cnt;
        }
    }

    public class MaxValueItem
    {
        public int Value { get; set; }
        public int Index { get; set; }
    }
}

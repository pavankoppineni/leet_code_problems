using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/non-decreasing-array/
    /// </summary>
    public class Leetcode_665_NonDecreasingArray_V1
    {
        public bool CheckPossibility(int[] values)
        {
            var cnt = 0;
            var prevItem = ValueItem.Create(values[0], int.MinValue);
            for (var index = 1; index < values.Length; index++)
            {
                var current = values[index];
                if (current >= prevItem.Value)
                {
                    prevItem.PrevValue = prevItem.Value;
                    prevItem.Value = current;
                    continue;
                }

                if (cnt >= 1)
                {
                    return false;
                }
                cnt += 1;
                if (current < prevItem.PrevValue)
                {
                    prevItem.PrevValue = prevItem.Value;
                    prevItem.Value = prevItem.Value;
                    continue;
                }
                prevItem.PrevValue = current;
                prevItem.Value = current;
            }
            return true;
        }

        public class ValueItem
        {
            public int Value { get; set; }
            public int PrevValue { get; set; }

            public static ValueItem Create(int value, int prevValue)
            {
                return new ValueItem 
                { 
                    Value = value, 
                    PrevValue = prevValue
                };
            }
        }
    }
}

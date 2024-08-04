using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-original-array-from-doubled-array/
    /// </summary>
    public class Leetcode_2007_FindOriginalArrayFromDoubledArray_V1
    {
        public int[] CalculateOriginalArray(int[] values)
        {
            var originalArrayLength = values.Length >> 1;
            var originalArray = new int[originalArrayLength];
            Array.Sort(values);
            var lookup = CreateLookup(values);
            var originalIndex = 0;
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];
                if (lookup[value] == 0)
                {
                    continue;
                }
                lookup[value] -= 1;
                var doubleValue = value * 2;

                //When : doubleValue is present
                //Then : 
                if (!lookup.ContainsKey(doubleValue))
                {
                    return Array.Empty<int>();
                }

                //When : count is zero
                //THen : return EMPTY array
                if (lookup[doubleValue] == 0)
                {
                    return Array.Empty<int>();
                }
                lookup[doubleValue] -= 1;
                originalArray[originalIndex] = value;
                originalIndex += 1;
                if (originalIndex == originalArrayLength)
                {
                    break;
                }
            }
            return originalArray;
        }

        private static IDictionary<int, int> CreateLookup(int[] values)
        {
            var sortedValues = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (!sortedValues.ContainsKey(value))
                {
                    sortedValues.Add(value, 1);
                    continue;
                }
                sortedValues[value]++;
            }
            return sortedValues;
        }
    }
}

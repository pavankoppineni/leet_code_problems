using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-all-duplicates-in-an-array/
    /// </summary>
    public class Leetcode_442_FindAllDuplicatesInArray_V1
    {
        public IList<int> FindDuplicates(int[] values)
        {
            var duplicates = new HashSet<int>();
            for (var index = 0; index < values.Length; index++)
            {
                var value = Math.Abs(values[index]);
                var duplicateValue = values[value - 1];
                if (duplicateValue < 0)
                {
                    duplicates.Add(value);
                }
                else
                {
                    values[value - 1] = -1 * values[value - 1];
                }
            }
            return duplicates.ToList();
        }
    }
}

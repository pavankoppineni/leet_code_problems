using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/total-appeal-of-a-string/
    /// </summary>
    public class Leetcode_2262_TotalAppealOfAString_V1
    {
        public long CalculateAppealSum(string str)
        {
            var totalSum = 0L;
            var lookupValues = new long[str.Length];
            var lookupIndex = new Dictionary<char, int>();
            lookupValues[0] = 1;
            lookupIndex.Add(str[0], 0);
            totalSum += lookupValues[0];
            for (var index = 1; index < str.Length; index++)
            {
                var currentChar = str[index];

                //When : currentChar is present in lookupIndex
                //Then :
                if (lookupIndex.ContainsKey(currentChar))
                {
                    var prevIndex = lookupIndex[currentChar];
                    var diff = index - prevIndex;
                    lookupValues[index] = lookupValues[index - 1] + diff;
                    totalSum += lookupValues[index];
                    lookupIndex[currentChar] = index;
                    continue;
                }

                //When : currentChar is not present in lookupIndex
                //Then : 
                lookupValues[index] = lookupValues[index - 1] + index + 1;
                totalSum += lookupValues[index];
                lookupIndex.Add(currentChar, index);
            }
            return totalSum;
        }
    }
}

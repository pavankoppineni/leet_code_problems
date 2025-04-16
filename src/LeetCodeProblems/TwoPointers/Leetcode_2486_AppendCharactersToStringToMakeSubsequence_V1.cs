using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TwoPointers
{
    /// <summary>
    /// https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/description
    /// </summary>
    public class Leetcode_2486_AppendCharactersToStringToMakeSubsequence_V1
    {
        public int CalculatedCharacters(string source, string target)
        {
            var sourcePointer = 0;
            var targetPointer = 0;
            while (sourcePointer < source.Length && targetPointer < target.Length)
            {
                // when : source and target characters are equal
                // then : increment source and target pointer
                if (source[sourcePointer] == target[targetPointer])
                {
                    sourcePointer++;
                    targetPointer++;
                    continue;
                }

                // When : source and target pointer are not equal
                // then : increment source pointer
                sourcePointer++;
            }

            return target.Length - targetPointer;
        }
    }
}

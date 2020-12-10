using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/first-unique-character-in-a-string/
    /// </summary>
    public class Leetcode_387_FirstUniqueCharacterInString_V1
    {
        public int FirstUniqChar(string s)
        {
            if (s == null || s == string.Empty)
            {
                return -1;
            }

            var charDict = new Dictionary<char, (int index, bool isDuplicate)>();
            for (var index = 0; index < s.Length; index++)
            {
                if (charDict.ContainsKey(s[index]))
                {
                    charDict[s[index]] = (index, true);
                }
                else
                {
                    charDict.Add(s[index], (index, false));
                }
            }

            var nonDuplicateIndex = -1;

            foreach (var pair in charDict)
            {
                if (!pair.Value.isDuplicate)
                {
                    nonDuplicateIndex = pair.Value.index;
                    break;
                }
            }

            return nonDuplicateIndex;
        }
    }
}

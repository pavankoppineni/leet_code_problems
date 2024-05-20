using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
    /// </summary>
    public class Leetcode_1647_MinimumDeletionsToMakeCharacterFrequenciesUnique_V1
    {
        public int CalculateMinimuOperations(string str)
        {
            var max = 1;
            var lookup = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (lookup.ContainsKey(c))
                {
                    lookup[c]++;
                    max = Math.Max(max, lookup[c]);
                    continue;
                }
                lookup.Add(c, 1);
            }
            return max;
        }
    }
}

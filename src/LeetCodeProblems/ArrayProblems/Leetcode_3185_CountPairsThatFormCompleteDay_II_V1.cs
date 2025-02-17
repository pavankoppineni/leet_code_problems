using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-that-form-a-complete-day-ii/description/
    /// </summary>
    public class Leetcode_3185_CountPairsThatFormCompleteDay_II_V1
    {
        public long CountCompletePairs(int[] hours)
        {
            var completePairs = 0L;
            var lookup = new Dictionary<int, int>();
            foreach (var hour in hours)
            {
                var modHours = hour % 24;
                var reminaingHours = 24 - modHours;
                if (lookup.ContainsKey(reminaingHours))
                {
                    completePairs += lookup[reminaingHours];
                }

                if (!lookup.ContainsKey(modHours))
                {
                    lookup.Add(modHours, 0);
                }
                lookup[modHours] += 1;
            }

            if (lookup.ContainsKey(0))
            {
                var count = lookup[0] - 1;
                completePairs += (count * (count + 1)) / 2;
            }

            return completePairs;
        }
    }
}

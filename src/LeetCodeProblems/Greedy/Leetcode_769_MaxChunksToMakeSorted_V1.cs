using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/max-chunks-to-make-sorted/
    /// </summary>
    public class Leetcode_769_MaxChunksToMakeSorted_V1
    {
        public int CalculateMaximumChunks(int[] values)
        {
            if (values.Length == 1)
            {
                return 1;
            }
            var numberOfChunks = 0;
            var currentMax = int.MinValue;
            for (var index = 0; index < values.Length; index++)
            {
                var value = values[index];

                //When : value is greater than index
                //Then 
                if (value > index)
                {
                    currentMax = Math.Max(currentMax, value);
                    continue;
                }

                //When : value is less than or equal to index
                //Then :
                if (currentMax <= index)
                {
                    numberOfChunks += 1;
                    currentMax = index;
                }
            }
            return numberOfChunks;
        }
    }
}

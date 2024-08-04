using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/steps-to-make-array-non-decreasing/
    /// </summary>
    public class Leetcode_2289_StepsToMakeArrayNonDecreasing_V1
    {
        public int CalculateNumberOfSteps(int[] values)
        {
            var currentSteps = 0;
            var steps = 0;
            var prev = values[0];
            for (var index = 1; index < values.Length; index++)
            {
                var current = values[index];
                // When : current is greater than or equal to prev
                // Then :
                if (current >= prev)
                {
                    prev = current;
                    currentSteps = 0;
                    continue;
                }
                currentSteps += 1;
                steps = Math.Max(steps, currentSteps);
            }
            return steps;
        }
    }
}

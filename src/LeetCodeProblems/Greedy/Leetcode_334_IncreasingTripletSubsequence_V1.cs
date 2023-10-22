using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/increasing-triplet-subsequence/
    /// </summary>
    public class Leetcode_334_IncreasingTripletSubsequence_V1
    {
        public bool ContainsTriplet(int[] values)
        {
            var stack = new Stack<int>();
            stack.Push(values[0]);
            for (var index = 1; index < values.Length; index++)
            {
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_42_TappingRainWater
{
    /// <summary>
    /// https://leetcode.com/problems/trapping-rain-water/
    /// </summary>
    public class Leetcode_42_TrappingRainWater_V1
    {
        public int Trap(int[] heights)
        {
            var sum = 0;
            var prefixSum = new int[heights.Length];
            prefixSum[0] = heights[0];
            var stack = new Stack<int>();
            for (var i = 1; i < heights.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + heights[i];
            }
            stack.Push(0);
            for (var i = 1; i < heights.Length; i++)
            {
                var currentMaxIndex = stack.Peek();
                if (heights[i] > heights[currentMaxIndex])
                {
                    stack.Pop();
                    stack.Push(i);
                }
            }
            return sum;
        }
    }
}

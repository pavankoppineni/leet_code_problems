using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class Leetcode_11_ContianerWithMostWater_V1
    {
        public int FindContainerWithMaxWater(int[] heights)
        {
            var currentMax = 0;
            var max = 0;
            var left = 0;
            var right = heights.Length - 1;
            while (left < right)
            {
                var leftHeight = heights[left];
                var rightHeight = heights[right];
                var distance = right - left;

                //Case 1 : Left and right are equal
                if (leftHeight == rightHeight)
                {
                    currentMax = distance * heights[left];
                    left += 1;
                    right -= 1;
                }
                //Case 2 : Left is greater than right
                else if (leftHeight > rightHeight)
                {
                    currentMax = distance * heights[right];
                    right -= 1;
                }
                //Case 3 : Left is less than right
                else
                {
                    currentMax = distance * heights[left];
                    left += 1;
                }

                if (currentMax > max)
                {
                    max = currentMax;
                }
            }

            return max;
        }
    }
}

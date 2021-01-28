using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/array-nesting/
    /// </summary>
    public class Leetcode_565_ArrayNesting_V1
    {
        public int ArrayNesting(int[] nums)
        {
            var visited = new bool[nums.Length];
            var maxCount = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var start = nums[i];
                //Case 1 : When element is visited
                if (visited[start])
                {
                    continue;
                }
                //Case 2 : When element is not visted
                else
                {
                    var count = 0;
                    do
                    {
                        visited[start] = true;
                        count += 1;
                        start = nums[start];
                    }
                    while (start != nums[i]);
                    if(count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }

            return maxCount;
        }
    }
}

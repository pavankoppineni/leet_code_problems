using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/sort-colors/
    /// </summary>
    public class Leetcode_75_SortColors_V1
    {
        private int low, mid;
        private int high;

        public int[] SortColors(int[] colors)
        {
            low = 0;
            mid = 0;
            high = colors.Length - 1;
            while (mid <= high)
            {
                switch (colors[mid])
                {
                    case 0:
                        if (low == mid)
                        {
                            low += 1;
                            mid += 1;
                        }
                        else
                        {
                            var temp_1 = colors[mid];
                            colors[mid] = colors[low];
                            colors[low] = temp_1;
                            low += 1;
                            mid += 1;
                        }
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        var temp = colors[high];
                        colors[high] = colors[mid];
                        colors[mid] = temp;
                        high--;
                        break;
                }
            }
            return colors;
        }
    }
}

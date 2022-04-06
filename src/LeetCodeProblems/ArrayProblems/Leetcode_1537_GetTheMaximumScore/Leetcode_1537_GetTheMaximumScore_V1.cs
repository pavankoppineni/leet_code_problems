using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems.Leetcode_1537_GetTheMaximumScore
{
    /// <summary>
    /// https://leetcode.com/problems/get-the-maximum-score/
    /// </summary>
    public class Leetcode_1537_GetTheMaximumScore_V1
    {
        public int CalculateMaximumSum(int[] top, int[] bottom)
        {
            var maxSum = 0;
            var topSum = 0;
            var bottomSum = 0;
            var topIndex = 0;
            var bottomIndex = 0;
            while (topIndex < top.Length && bottomIndex < bottom.Length)
            {
                if (top[topIndex] == bottom[bottomIndex])
                {
                    bottomSum += bottom[bottomIndex];
                    topSum += top[topIndex];
                    maxSum += Math.Max(bottomSum, topSum);
                    bottomSum = 0;
                    topSum = 0;
                    topIndex++;
                    bottomIndex++;
                }
                else if (top[topIndex] > bottom[bottomIndex])
                {
                    bottomSum += bottom[bottomIndex];
                    bottomIndex++;
                }
                else
                {
                    topSum += top[topIndex];
                    topIndex++;
                }
            }

            while (topIndex < top.Length)
            {
                topSum += top[topIndex];
                topIndex++;
            }
            while (bottomIndex < bottom.Length)
            {
                bottomSum += bottom[bottomIndex];
                bottomIndex++;
            }
            return (maxSum + Math.Max(topSum, bottomSum)) % 1000000007;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-make-array-equal-ii/
    /// </summary>
    public class Leetcode_2541_MinimumOperationsToMakeArrayEqualII_V1
    {
        public long MinOperations(int[] nums1, int[] nums2, int k)
        {
            if (k == 0)
            {
                for (var i = 0; i < nums1.Length; i++)
                {
                    var diff = nums1[i] - nums2[i];
                    if (diff != 0)
                    {
                        return -1;
                    }
                }
                return 0;
            }
            var positiveDifference = 0;
            var negativeDifference = 0;
            for (var i = 0; i < nums1.Length; i++)
            {
                var diff = nums1[i] - nums2[i];
                if (diff % k != 0)
                {
                    return -1;
                }
                if (diff <= 0)
                {
                    negativeDifference += diff;
                }
                else
                {
                    positiveDifference += diff;
                }
            }

            if ((negativeDifference * -1 != positiveDifference))
            {
                return -1;
            }

            return positiveDifference / k;
        }
    }
}

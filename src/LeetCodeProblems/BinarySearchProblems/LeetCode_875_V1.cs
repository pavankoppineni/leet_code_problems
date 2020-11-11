using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/koko-eating-bananas/
    /// </summary>
    public class LeetCode_875_V1
    {
        private int[] values;
        private int numberOfHours;

        public int Find(int[] values, int hours)
        {
            this.values = values;
            this.numberOfHours = hours;
            var max = values.Max();
            if (values.Length == hours)
            {
                return max;
            }
            return Find(1, max);
        }

        private int Find(int low, int high)
        {
            var currentRate = high;
            while (low <= high)
            {
                var mid = (low + high) >> 1;
                var currentNumerOfHours = GetNumberOfHours(mid);

                //Case 1 : Current number of hours is greater than number of hours
                if (currentNumerOfHours > numberOfHours)
                {
                    low = mid + 1;
                }
                //Case 2 : Curret number of hours is less than number of hours
                else
                {
                    currentRate = mid;
                    high = mid - 1;
                }
            }

            return currentRate;
        }

        private int GetNumberOfHours(int rate)
        {
            var numberOfHours = 0;
            foreach (var val in values)
            {
                if (val % rate == 0)
                {
                    numberOfHours += val / rate;
                }
                else
                {
                    numberOfHours += val / rate + 1;
                }
            }

            return numberOfHours;
        }
    }
}

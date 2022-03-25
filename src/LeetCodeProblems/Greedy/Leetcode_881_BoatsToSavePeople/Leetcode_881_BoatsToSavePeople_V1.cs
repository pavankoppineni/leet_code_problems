using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Greedy.Leetcode_881_BoatsToSavePeople
{
    /// <summary>
    /// https://leetcode.com/problems/boats-to-save-people/
    /// </summary>
    public class Leetcode_881_BoatsToSavePeople_V1
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            if (people[0] > limit)
            {
                return 0;
            }

            var left = 0;
            var right = people.Length - 1;
            var count = 0;
            while (left <= right)
            {
                if (people[right] > limit)
                {
                    right--;
                }
                else if (people[left] + people[right] <= limit)
                {
                    left++;
                    right--;
                    count += 1;
                }
                else
                {
                    right--;
                    count++;
                }
            }
            return count;
        }
    }
}

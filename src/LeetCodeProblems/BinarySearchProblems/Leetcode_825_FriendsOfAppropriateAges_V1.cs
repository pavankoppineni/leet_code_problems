using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BinarySearchProblems
{
    /// <summary>
    /// https://leetcode.com/problems/friends-of-appropriate-ages/description
    /// </summary>
    public class Leetcode_825_FriendsOfAppropriateAges_V1
    {
        public int CalculateNumberOfFriendRequests(int[] ages)
        {
            var count = 0;
            Array.Sort(ages);
            return count;
        }
    }
}

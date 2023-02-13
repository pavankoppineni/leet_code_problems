using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/make-number-of-distinct-characters-equal/
    /// </summary>
    public class Leetcode_2531_MakeNumberOfDistinctCharactersEqual_V1
    {
        public bool CheckPossibility(string str1, string str2)
        {
            var strOneLookup = ConstructLookup(str1);
            var strTwoLookup = ConstructLookup(str2);

            //When : Lookup count of str1 and str2 are same
            //Then : Return true
            if (strOneLookup.Keys.Count == strTwoLookup.Keys.Count)
            {
                return true;
            }

            //When : Difference in lookup count of str1 and str2 are 
            //greater than 2
            //Then : Return false
            if (Math.Abs(strOneLookup.Keys.Count - strTwoLookup.Keys.Count) > 2)
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupOne"></param>
        /// <param name="lookupTwo"></param>
        /// <returns></returns>
        private bool CheckPossibilityByDecreasingBigLookup(IDictionary<char, int> smallLookup, IDictionary<char, int> bigLookup)
        {
            var itemWithSingeCount = false;
            var itemPresentInboth = false;
            foreach (var bigLookupItem in bigLookup)
            {
                if (itemWithSingeCount & itemPresentInboth)
                {
                    break;
                }
                if (smallLookup.ContainsKey(bigLookupItem.Key))
                {
                    var smallLookupItem = smallLookup[bigLookupItem.Key];
                    if (smallLookupItem > 1)
                    {
                        itemPresentInboth = true;
                    }
                    continue;
                }
                if (bigLookupItem.Value == 1)
                {
                    itemWithSingeCount = true;
                }
            }
            return itemPresentInboth & itemWithSingeCount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookupOne"></param>
        /// <param name="lookupTwo"></param>
        /// <returns></returns>
        private bool CheckPossibilityByIncreasingSmallLookup(IDictionary<char, int> smallLookup, IDictionary<char, int> bigLookup)
        {
            return false;
        }

        /// <summary>
        /// Constructs lookup table for a given string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private IDictionary<char, int> ConstructLookup(string str)
        {
            var lookup = new Dictionary<char, int>();
            foreach (char item in str)
            {
                if (!lookup.ContainsKey(item))
                {
                    lookup.Add(item, 0);
                }
                lookup[item] += 1;
            }
            return lookup;
        }
    }
}

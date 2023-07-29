using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
    /// </summary>
    public class Leetcode_1282_GroupPeopleGivenTheGroupSizeTheyBelongTo_V1
    {
        public IList<IList<int>> GeneratePeopleGroups(int[] groupSizes)
        {
            var peopleGroups = new List<IList<int>>();
            var groupSizeLookup = new Dictionary<int, IList<int>>();
            for(var index = 0; index < groupSizes.Length; index++)
            {
                var groupSize = groupSizes[index];
                //When : groupSize doesn't exist
                if (!groupSizeLookup.ContainsKey(groupSize))
                {
                    groupSizeLookup.Add(groupSize, new List<int>());
                }

                //When : Number of people in group is equal to group size
                if (groupSizeLookup[groupSize].Count == groupSize)
                {
                    peopleGroups.Add(groupSizeLookup[groupSize]);
                    groupSizeLookup[groupSize] = new List<int>
                    {
                        index
                    };
                }
                //When : Number of people in group is less than group size
                else
                {
                    groupSizeLookup[groupSize].Add(index);
                }
            }
            foreach (var groupSizeLookupItem in groupSizeLookup)
            {
                if (groupSizeLookupItem.Value.Count > 0)
                {
                    peopleGroups.Add(groupSizeLookupItem.Value);
                }
            }
            return peopleGroups;
        }
    }
}

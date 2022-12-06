using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/divide-players-into-teams-of-equal-skill/
    /// </summary>
    public class Leetcode_2491_DividePlayersIntoTeamsOfEqualSkill_V1
    {
        public long CalculateChemistryOfTeams(int[] players)
        {
            var totalSum = players.Sum();
            var lookup = CreateLookup(players);
            var numberOfTeams = players.Length / 2;
            if (totalSum % numberOfTeams != 0)
            {
                return -1;
            }
            var skillOfEachTeam = totalSum / numberOfTeams;
            long chemistry = 0;
            foreach (var player in players)
            {
                if (lookup[player] == 0)
                {
                    continue;
                }
                var remainingSkill = skillOfEachTeam - player;
                if (lookup.ContainsKey(remainingSkill) && lookup[remainingSkill] > 0)
                {
                    chemistry += player * remainingSkill;
                    lookup[player] -= 1;
                    lookup[remainingSkill] -= 1;
                }
                else
                {
                    chemistry = -1;
                }
            }
            return chemistry;
        }

        private IDictionary<int, int> CreateLookup(int[] players)
        {
            var lookup = new Dictionary<int, int>();
            foreach (var player in players)
            {
                if (!lookup.ContainsKey(player))
                {
                    lookup.Add(player, 0);
                }
                lookup[player] += 1;
            }
            return lookup;
        }
    }
}

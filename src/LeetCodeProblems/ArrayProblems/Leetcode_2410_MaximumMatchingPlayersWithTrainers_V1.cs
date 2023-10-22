using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-matching-of-players-with-trainers/
    /// </summary>
    public class Leetcode_2410_MaximumMatchingPlayersWithTrainers_V1
    {
        public int CalculateMatchingPlayers(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);
            var matching = 0;
            var playerIndex = 0;
            var trainerIndex = 0;
            while (playerIndex < players.Length && trainerIndex < trainers.Length)
            {
                //When : player strength is less than trainer strength
                //Then : Increment player index and trainer index
                if (players[playerIndex] <= trainers[trainerIndex])
                {
                    matching++;
                    playerIndex++;
                }
                //When : Player strength is greater than trainer strength
                //Then : Increment trainer index
                trainerIndex++;
            }
            return matching;
        }
    }
}

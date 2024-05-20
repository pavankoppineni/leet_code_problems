using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-players-with-zero-or-one-losses/
    /// </summary>
    public class Leetcode_2225_FindPlayersWithZeroOrOneLosses_V1
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var lookup = ConstructLookup(matches);
            var winners = new List<int>();
            var losers = new List<int>();
            foreach (var lookupItem in lookup)
            {
                if (lookupItem.Value.Losses > 1)
                {
                    continue;
                }

                if (lookupItem.Value.Losses == 0)
                {
                    winners.Add(lookupItem.Key);
                    continue;
                }

                losers.Add(lookupItem.Key);
            }

            return new List<IList<int>>
            {
                winners,
                losers
            };
        }

        private static IDictionary<int, WinLosePair> ConstructLookup(int[][] matches)
        {
            var playersLookup = new SortedDictionary<int, WinLosePair>();
            foreach (var match in matches)
            {
                var winner = match[0];
                var loser = match[1];

                if (!playersLookup.ContainsKey(winner))
                {
                    playersLookup.Add(winner, WinLosePair.Create());
                }
                if (!playersLookup.ContainsKey(loser))
                {
                    playersLookup.Add(loser, WinLosePair.Create());
                }

                playersLookup[winner].Wins += 1;
                playersLookup[loser].Losses += 1;
            }

            return playersLookup;
        }

        internal class WinLosePair
        {
            internal int Wins { get; set; }
            internal int Losses { get; set; }

            internal static WinLosePair Create()
            {
                return new WinLosePair { Wins = 0, Losses = 0 };
            }
        }
    }
}

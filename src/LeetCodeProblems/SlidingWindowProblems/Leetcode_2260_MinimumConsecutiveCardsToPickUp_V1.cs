using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/description/?envType=problem-list-v2&envId=sliding-window
    /// </summary>
    public class Leetcode_2260_MinimumConsecutiveCardsToPickUp_V1
    {
        public int Calculate(int[] cards)
        {
            var found = false;
            var min = int.MaxValue;
            var lookup = new Dictionary<int, int>();
            for (var index = 0; index < cards.Length; index++)
            {
                var card = cards[index];

                // When : card is present in lookup
                if (lookup.ContainsKey(card))
                {
                    found = true;
                    var currentMin = index - lookup[card];
                    min = Math.Min(currentMin, min);
                    lookup[card] = index;
                    continue;
                }

                lookup.Add(card, index);
            }

            if(found)
            {
                return min + 1;
            }

            return -1;
        }
    }
}

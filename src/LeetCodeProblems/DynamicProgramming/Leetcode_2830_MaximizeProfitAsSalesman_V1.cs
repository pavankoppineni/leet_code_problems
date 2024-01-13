using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximize-the-profit-as-the-salesman/
    /// </summary>
    public class Leetcode_2830_MaximizeProfitAsSalesman_V1
    {
        public int CalculateMaximumProfit(int n, IList<IList<int>> offers)
        {
            throw new NotImplementedException();
        }

        internal class Offer : IComparer<Offer>
        {
            internal int Start { get; set; }
            internal int End { get; set; }
            public int Gold { get; set; }

            internal static IEnumerable<Offer> CreateOffers(IList<IList<int>> offers)
            {
                foreach (var offer in offers)
                {
                    yield return CreateOffer(offer);
                }
            }

            internal static Offer CreateOffer(IList<int> currentOffer)
            {
                return new Offer
                {
                    End = currentOffer[1],
                    Start = currentOffer[0],
                    Gold = currentOffer[2]
                };
            }

            public int Compare(Offer x, Offer y)
            {
                if (x.Start < y.Start)
                {
                    return -1;
                }

                if (x.Start == y.Start)
                {

                }
            }
        }
    }
}

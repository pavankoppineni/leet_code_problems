using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.BacktrackingProblems
{
    /// <summary>
    /// https://leetcode.com/problems/shopping-offers/description/
    /// </summary>
    public class Leetcode_638_ShoppingOffers_V1
    {
        private IList<int> _prices;
        private IList<IList<int>> _specialOffers;
        private IDictionary<string, int> _memoizationMap = new Dictionary<string, int>();
        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            _prices = price;
            _specialOffers = special;
            return CalculateMinimumCost(needs);
        }

        private int CalculateMinimumCost(IList<int> needs)
        {
            if (!HasMoreNeeds(needs))
            {
                return 0;
            }
            
            var key = GenerateNeedsKey(needs);
            if (_memoizationMap.ContainsKey(key))
            {
                return _memoizationMap[key];
            }

            var costWithoutOffers = CalculateCostWithoutOffers(needs);
            var minCost = int.MaxValue;
            for (var index = 0; index < _specialOffers.Count; index++)
            {
                var currentOffer = _specialOffers[index];
                var costWithOffer = CalculateOfferResult(needs, currentOffer);
                if (!costWithOffer.IsOfferApplicable)
                {
                    continue;
                }

                var currentCost = costWithOffer.OfferCost + CalculateMinimumCost(costWithOffer.RemainingNeeds);
                minCost = Math.Min(minCost, currentCost);
            }

            minCost = Math.Min(minCost, costWithoutOffers);
            _memoizationMap.Add(key, minCost);
            return minCost;
        }

        private string GenerateNeedsKey(IList<int> needs)
        {
            var sb = new StringBuilder();
            foreach (var need in needs)
            {
                sb.Append(need);
                sb.Append("#");
            }
            return sb.ToString();
        }

        private bool HasMoreNeeds(IList<int> currentNeeds)
        {
            return currentNeeds.Sum() > 0;
        }

        private OfferResult CalculateOfferResult(IList<int> needs, IList<int> currentOffer)
        {
            var remainingNeeds = new List<int>();
            for (var index = 0; index < needs.Count; index++)
            {
                var need = needs[index];
                var offerQuantity = currentOffer[index];

                // When : Need is less than offer quantity
                // Then : Don't consider this offer
                if (need < offerQuantity)
                {
                    return new OfferResult
                    {
                        IsOfferApplicable = false
                    };
                }

                remainingNeeds.Add(need - offerQuantity);
            }

            return new OfferResult
            {
                IsOfferApplicable = true,
                RemainingNeeds = remainingNeeds,
                OfferCost = currentOffer.Last()
            };
        }

        private int CalculateCostWithoutOffers(IList<int> needs)
        {
            var cost = 0;
            for (var index = 0; index < needs.Count; index++)
            {
                cost += _prices[index] * needs[index];
            }

            return cost;
        }
    }

    public class OfferResult
    {
        public bool IsOfferApplicable { get; set; }
        public IList<int> RemainingNeeds { get; set; }
        public int OfferCost { get; set; }
    }
}

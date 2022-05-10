using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_1359_CountAllValidPickupAndDeliveryOptions
{
    /// <summary>
    /// https://leetcode.com/problems/count-all-valid-pickup-and-delivery-options/
    /// </summary>
    public class Leetcode_1359_CountAllValidPickupAndDeliveryOptions_V1
    {
        private int _count;
        private IDictionary<(int pickupCount, int dropCount), int> _lookup;
        private IDictionary<int, int> _dropCountLookup;
        private const int MAX_VALUE = 1000000007;
        public int CalculateWays(int count)
        {
            _lookup = new Dictionary<(int pickupCount, int dropCount), int>();
            _dropCountLookup = new Dictionary<int,int>();
            var dropCount = 2;
            _dropCountLookup.Add(1, 1);
            while (dropCount <= count)
            {
                var previousValue = dropCount * _dropCountLookup[dropCount - 1];
                if (previousValue > int.MaxValue)
                {
                    previousValue %= int.MaxValue;
                }
                _dropCountLookup.Add(dropCount, previousValue);
                dropCount++;
            }
            _count = count;
            CalculateWays(0, count, 0);
            return _lookup[(count, 0)];
        }

        private int CalculateWays(int level, int pickupCount, int dropCount)
        {
            if (_lookup.ContainsKey((pickupCount, dropCount)))
            {
                return _lookup[(pickupCount, dropCount)];
            }

            if (pickupCount == 0)
            {
                return _dropCountLookup[dropCount];
            }
            if (level == _count * 2)
            {
                return 1;
            }

            var pickupWays = 0;
            var dropWays = 0;
            for (var pickupIndex = 0; pickupIndex < pickupCount; pickupIndex++)
            {
                pickupWays += CalculateWays(level + 1, pickupCount - 1, dropCount + 1);
                if (pickupWays > MAX_VALUE)
                {
                    pickupWays %= MAX_VALUE;
                }
            }
            for (var dropIndex = 0; dropIndex < dropCount; dropIndex++)
            {
                dropWays += CalculateWays(level + 1, pickupCount, dropCount - 1);
                if (dropWays > MAX_VALUE)
                {
                    dropWays %= MAX_VALUE;
                }
            }
            _lookup.Add((pickupCount, dropCount), (pickupWays + dropWays) % MAX_VALUE);
            return _lookup[(pickupCount, dropCount)];
        }
    }
}

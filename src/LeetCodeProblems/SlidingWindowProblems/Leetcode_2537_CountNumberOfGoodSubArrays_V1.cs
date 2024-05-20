using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-number-of-good-subarrays/
    /// </summary>
    public class Leetcode_2537_CountNumberOfGoodSubArrays_V1
    {
        public long CalculateNumberOfSubArrays(int[] nums, int k)
        {
            var startIndex = 0;
            var numberOfSubArrays = 0;
            var lookup = new PairLookup();
            var index = 0;
            while (index < nums.Length)
            {
                var pairs = lookup.Add(nums[index]);

                // When : pairs is not equal to k
                if (pairs < k)
                {
                    index++;
                    continue;
                }

                // when : pairs is equal to k
                numberOfSubArrays += nums.Length - index;
                lookup.Remove(nums[startIndex]);
                startIndex++;
                index++;
            }

            return numberOfSubArrays;
        }

        internal class PairLookup
        {
            private IDictionary<int, int> _valuesCount;
            private int _pairs;

            internal PairLookup()
            {
                _valuesCount = new Dictionary<int, int>();
            }

            internal int Add(int key)
            {
                if (!_valuesCount.ContainsKey(key))
                {
                    _valuesCount.Add(key, 1);
                    return _pairs;
                }

                _valuesCount[key]++;
                _pairs += _valuesCount[key] - 1;
                return _pairs;
            }

            internal int Remove(int key)
            {
                if (!_valuesCount.ContainsKey(key))
                {
                    return _pairs;
                }

                _valuesCount[key]--;
                _pairs -= _valuesCount[key];
                return _pairs;
            }
        }
    }
}

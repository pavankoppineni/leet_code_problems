using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-ways-where-square-of-number-is-equal-to-product-of-two-numbers/description/
    /// </summary>
    public class Leetcode_1577_NumberOfWaysWhereSquareOfNumberIsEqualToProductOfTwoNumbers_V1
    {
        public int CalculateTriplets(int[] nums1, int[] nums2)
        {
            return CalculateTripletCount(nums1, nums2) + CalculateTripletCount(nums2, nums1);
        }

        private int CalculateTripletCount(int[] nums1, int[] nums2)
        {
            var tripletCount = 0;

            foreach (var num1 in nums1)
            {
                var square = (long)num1 * num1;
                var freqLookup = new Dictionary<int, int>();
                for (var index = 0; index < nums2.Length; index++)
                {
                    var currentNumber = nums2[index];

                    // When : Current number is not a factor of square
                    // Then : Do nothing
                    if (square % currentNumber != 0)
                    {
                        continue;
                    }

                    var quotient = square / currentNumber;
                    if (freqLookup.ContainsKey((int)quotient))
                    {
                        tripletCount += freqLookup[(int)quotient];
                    }

                    if (!freqLookup.ContainsKey(currentNumber))
                    {
                        freqLookup.Add(currentNumber, 0);
                    }
                    freqLookup[currentNumber] += 1;
                }
            }

            return tripletCount;
        }
    }

    public class ArrayInsights
    {
        public ArrayInsights(int[] nums)
        {
            Nums = nums;
            NumberFrequencies = BuildNumberFrequencies(nums);
            SquareFrequencies = BuildSquareFrequencies(nums);
        }

        public int[] Nums { get; private set; }
        public IDictionary<int, int> NumberFrequencies { get; set; }
        public IDictionary<long, int> SquareFrequencies { get; set; }

        private static IDictionary<int, int> BuildNumberFrequencies(int[] nums)
        {
            var numberFrequencies = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!numberFrequencies.ContainsKey(num))
                {
                    numberFrequencies[num] = 0;
                }
                numberFrequencies[num]++;
            }
            return numberFrequencies;
        }

        private static IDictionary<long, int> BuildSquareFrequencies(int[] nums)
        {
            var squareFrequencies = new Dictionary<long, int>();
            foreach (var num in nums)
            {
                var square = (long)num * num;
                if (!squareFrequencies.ContainsKey(square))
                {
                    squareFrequencies[square] = 0;
                }
                squareFrequencies[square]++;
            }
            return squareFrequencies;
        }
    }
}

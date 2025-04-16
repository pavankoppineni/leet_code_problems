using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SlidingWindowProblems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-erasure-value
    /// </summary>
    public class Leetcode_1695_MaximumErasureValue_v1
    {
        public int CalculateMaximumUniqueSubarray(int[] values)
        {
            var lookup = new Dictionary<int, Element1695>();
            var maxSum = 0;
            var prefixSum = 0;
            var leftPosition = 0;
            for (var position = 0; position < values.Length; position++)
            {
                var value = values[position];
                prefixSum += value;

                // Case 1 : When value is presetn in lookup
                if (lookup.TryGetValue(value, out Element1695 existingElement))
                {
                    var previousPosition = existingElement.Position;

                    // Case 1A : When previous position is less than left position
                    if (previousPosition > leftPosition)
                    {
                        leftPosition = previousPosition + 1;
                        prefixSum = prefixSum - existingElement.PrefixSum;
                    }

                    // Case 1B : When previous position is greater than left position
                    existingElement.PrefixSum = prefixSum;
                    existingElement.Position = position;
                    maxSum = Math.Max(maxSum, prefixSum);
                    Console.WriteLine($"Sum : {maxSum} PrefixSum : {prefixSum} Position : {position}");
                    continue;
                }

                // Case 2 : When value is not present in lookup
                var element = Element1695.Create(value, prefixSum, position);
                lookup.Add(value, element);
                maxSum = Math.Max(maxSum, prefixSum);
                Console.WriteLine($"Sum : {maxSum} PrefixSum : {prefixSum} Position : {position}");
            }

            return maxSum;
        }

        public class Element1695
        {
            public int Value { get; set; }
            public int Position { get; set; }
            public int PrefixSum { get; set; }

            public static Element1695 Create(int value, int prefixSum, int position)
            {
                return new Element1695
                {
                    Value = value,
                    PrefixSum = prefixSum,
                    Position = position
                };
            }
        }
    }
}

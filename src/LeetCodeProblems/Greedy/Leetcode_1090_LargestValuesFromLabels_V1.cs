using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Greedy
{
    /// <summary>
    /// https://leetcode.com/problems/largest-values-from-labels/description/?envType=problem-list-v2&envId=greedy
    /// </summary>
    public class Leetcode_1090_LargestValuesFromLabels_V1
    {
        public int Calculate(int[] values, int[] labels, int numWanted, int useLimit)
        {
            var largestValue = 0;
            var valueItems = CreateList(values, labels);
            Array.Sort(valueItems, new ValueItem1090());
            var labelsLookup = new Dictionary<int, int>();
            for (var index = 0; index < valueItems.Length; index++)
            {
                if (numWanted <= 0)
                {
                    break;
                }

                var valueItem = valueItems[index];
                var label = valueItem.Label;

                // When : label is not present in lookup
                // Then : 
                if (!labelsLookup.ContainsKey(label))
                {
                    largestValue += valueItem.Value;
                    labelsLookup.Add(label, 1);
                    numWanted--;
                    continue;
                }

                // When : Label is present in lookup
                // Then :
                if (labelsLookup[label] < useLimit)
                {
                    largestValue += valueItem.Value;
                    labelsLookup[label] += 1;
                    numWanted--;
                    continue;
                }
            }

            return largestValue;
        }

        private static ValueItem1090[] CreateList(int[] values, int[] labels)
        {
            var valueItems = new ValueItem1090[values.Length];
            for (var index = 0; index < values.Length; index++)
            {
                var valueItem = new ValueItem1090()
                {
                    Value = values[index],
                    Label = labels[index],
                };
                valueItems[index] = valueItem;
            }

            return valueItems;
        }
    }

    public class ValueItem1090 : IComparer<ValueItem1090> 
    {
        public int Value { get; set; }
        public int Label { get; set; }

        public int Compare(ValueItem1090 x, ValueItem1090 y)
        {
            return y.Value.CompareTo(x.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/top-k-frequent-elements/
    /// </summary>
    public class LeetCode_347_TopKFrequentElements_V1
    {
        IDictionary<int, int> elementsDict;
        int[] topKElements;
        int[] elements;

        public int[] TopKFrequent(int[] elements, int k)
        {
            this.elementsDict = new Dictionary<int, int>();
            this.topKElements = new int[k];
            this.elements = elements;

            foreach(var element in elements)
            {
                if (elementsDict.ContainsKey(element))
                {
                    elementsDict[element] += 1;
                }
                else
                {
                    elementsDict.Add(element, 1);
                }
            }

            var maxHeap = new MaxHeap(elementsDict.Count);
            foreach (var pair in elementsDict)
            {
                maxHeap.Add(pair);
            }

            for (var topElementIndex = 0; topElementIndex < k; topElementIndex++)
            {
                topKElements[topElementIndex] = maxHeap.ExtractMax();
            }

            return this.topKElements;
        }

        public class MaxHeap
        {
            private KeyValuePair<int, int>[] pairs;
            private int length;
            private int count;

            public MaxHeap(int length)
            {
                this.pairs = new KeyValuePair<int, int>[length];
                this.length = length;
                this.count = 0;
            }

            private int GetParent(int index)
            {
                return (index - 1) >> 1;
            }

            private int GetLeftChild(int index)
            {
                return 2 * index + 1;
            }

            private int GetRightChild(int index)
            {
                return 2 * index + 2;
            }

            public int ExtractMax()
            {
                var root = pairs[0].Key;
                pairs[0] = pairs[count - 1];
                count -= 1;
                Heapify(0);

                return root;
            }

            public void Heapify(int index)
            {
                var maxIndex = index;
                var leftIndex = GetLeftChild(maxIndex);
                var rightIndex = GetRightChild(maxIndex);

                if(leftIndex < count)
                {
                    if (pairs[leftIndex].Value > pairs[maxIndex].Value)
                    {
                        maxIndex = leftIndex;
                    }
                }

                if (rightIndex < count)
                {
                    if (pairs[rightIndex].Value > pairs[maxIndex].Value)
                    {
                        maxIndex = rightIndex;
                    }
                }

                if (index == maxIndex)
                {
                    return;
                }

                var temp = pairs[index];
                pairs[index] = pairs[maxIndex];
                pairs[maxIndex] = temp;

                Heapify(maxIndex);
            }

            public void Add(KeyValuePair<int, int> pair)
            {
                var currentIndex = count;
                count += 1;
                if (count == 0)
                {
                    pairs[currentIndex] = pair;
                    return;
                }

                pairs[currentIndex] = pair;
                while (currentIndex > 0)
                {
                    var parent = GetParent(currentIndex);

                    // Case 1 : Value is greater than parent
                    // Action : Swap value with parent value
                    if (pair.Value > pairs[parent].Value)
                    {
                        var temp = pairs[parent];
                        pairs[parent] = pair;
                        pairs[currentIndex] = temp;
                        currentIndex = parent;
                    }

                    //Case 2 : Value is less than parent
                    //Action : Do nothing
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

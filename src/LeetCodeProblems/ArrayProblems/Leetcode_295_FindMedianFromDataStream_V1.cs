using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/find-median-from-data-stream/
    /// </summary>
    public class Leetcode_295_FindMedianFromDataStream_V1
    {
        private readonly MaxHeap maxHeap;
        private readonly MinHeap minHeap;

        public Leetcode_295_FindMedianFromDataStream_V1()
        {
            maxHeap = new MaxHeap();
            minHeap = new MinHeap();
        }

        public double FindMedian()
        {
            if (maxHeap.Count == minHeap.Count)
            {
                var maxPeek = maxHeap.Peek();
                var minPeek = minHeap.Peek();

                return (maxPeek + minPeek) / 2.0;
            }
            else if (maxHeap.Count > minHeap.Count)
            {
                return maxHeap.Peek();
            }
            else
            {
                return minHeap.Peek();
            }
        }

        public void AddNum(int num)
        {
            var maxHeapLength = maxHeap.Count;
            var minHeapLength = minHeap.Count;

            if (maxHeapLength == minHeapLength)
            {
                AddNumWhenHeapsAreEqual(num);
            }
            else
            {
                AddNumWhenHeapsAreNotEqual(num);
            }
        }

        private void AddNumWhenHeapsAreNotEqual(int num)
        {
            var maxHeapLength = maxHeap.Count;
            var minHeapLength = minHeap.Count;

            if (maxHeapLength > minHeapLength)
            {
                var median = maxHeap.Peek();
                if (num >= median)
                {
                    minHeap.Add(num);
                }
                else
                {
                    var maxHeapExtractValue = maxHeap.ExtractMax();
                    minHeap.Add(maxHeapExtractValue);
                    maxHeap.Add(num);
                }
            }
            else
            {
                var median = minHeap.Peek();
                if (num <= median)
                {
                    maxHeap.Add(num);
                }
                else
                {
                    var minHeapExtractValue = minHeap.ExtractMin();
                    maxHeap.Add(minHeapExtractValue);
                    minHeap.Add(num);
                }
            }
        }

        private void AddNumWhenHeapsAreEqual(int num)
        {
            if(maxHeap.Count == 0)
            {
                maxHeap.Add(num);
                return;
            }

            var maxHeapValue = maxHeap.Peek();
            var minHeapValue = minHeap.Peek();

            var median = (maxHeapValue + minHeapValue) / 2.0;

            if (num <= median)
            {
                maxHeap.Add(num);
            }
            else
            {
                minHeap.Add(num);
            }
        }

        public abstract class BaseHeap
        {
            protected int GetParent(int index)
            {
                return (index - 1) / 2;
            }

            protected int GetLeft(int index)
            {
                return 2 * index + 1;
            }

            protected int GetRight(int index)
            {
                return 2 * index + 2;
            }
        }

        public class MaxHeap : BaseHeap
        {
            private IList<int> values;
            private int _count;

            public MaxHeap()
            {
                values = new List<int>();
                _count = 0;
            }

            public int Count
            {
                get { return _count; }
            }

            public void Add(int num)
            {
                if (_count == 0)
                {
                    values.Add(num);
                    _count = 1;
                    return;
                }

                var currentIndex = _count;
                values.Add(num);
                _count += 1;
                while (currentIndex > 0)
                {
                    var parent = GetParent(currentIndex);
                    if (values[currentIndex] > values[parent])
                    {
                        var temp = values[currentIndex];
                        values[currentIndex] = values[parent];
                        values[parent] = temp;
                        currentIndex = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public int ExtractMax()
            {
                var root = values[0];
                var lastValue = values[_count - 1];
                values[0] = lastValue;
                values.RemoveAt(_count - 1);
                _count -= 1;
                Heapify(0);
                return root;
            }

            protected void Heapify(int index)
            {
                var maxIndex = index;
                var leftIndex = GetLeft(index);
                var rightIndex = GetRight(index);

                if (leftIndex < _count)
                {
                    if (values[leftIndex] > values[maxIndex])
                    {
                        maxIndex = leftIndex;
                    }
                }

                if (rightIndex < _count)
                {
                    if (values[rightIndex] > values[maxIndex])
                    {
                        maxIndex = rightIndex;
                    }
                }

                if (maxIndex == index)
                {
                    return;
                }

                var temp = values[maxIndex];
                values[maxIndex] = values[index];
                values[index] = temp;

                Heapify(maxIndex);
            }

            public int Peek()
            {
                return values[0];
            }
        }

        public class MinHeap : BaseHeap
        {
            private IList<int> values;
            private int _count;

            public MinHeap()
            {
                values = new List<int>();
                _count = 0;
            }

            public int Count
            {
                get { return _count; }
            }

            public void Add(int num)
            {
                if (_count == 0)
                {
                    values.Add(num);
                    _count = 1;
                    return;
                }

                var currentIndex = _count;
                values.Add(num);
                _count += 1;
                while (currentIndex > 0)
                {
                    var parent = GetParent(currentIndex);
                    if (values[currentIndex] < values[parent])
                    {
                        var temp = values[currentIndex];
                        values[currentIndex] = values[parent];
                        values[parent] = temp;
                        currentIndex = parent;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public int Peek()
            {
                return values[0];
            }

            public int ExtractMin()
            {
                var root = values[0];
                var lastValue = values[_count - 1];
                values[0] = lastValue;
                values.RemoveAt(_count - 1);
                _count -= 1;
                Heapify(0);
                return root;
            }

            protected void Heapify(int index)
            {
                var minIndex = index;
                var leftIndex = GetLeft(index);
                var rightIndex = GetRight(index);

                if(leftIndex < _count)
                {
                    if (values[leftIndex] < values[minIndex])
                    {
                        minIndex = leftIndex;
                    }
                }

                if (rightIndex < _count)
                {
                    if (values[rightIndex] < values[minIndex])
                    {
                        minIndex = rightIndex;
                    }
                }

                if(minIndex == index)
                {
                    return;
                }

                var temp = values[minIndex];
                values[minIndex] = values[index];
                values[index] = temp;

                Heapify(minIndex);
            }
        }
    }
}

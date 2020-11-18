using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-query-mutable/
    /// </summary>
    public class LeetCode_307_RangeSumQueryMutable_V1
    {
        private BinaryIndexedTree binaryIndexedTree;

        public LeetCode_307_RangeSumQueryMutable_V1(int[] nums)
        {
            this.binaryIndexedTree = new BinaryIndexedTree(nums);
            this.binaryIndexedTree.Build();
        }

        public void Update(int index, int value)
        {
            this.binaryIndexedTree.Update(index, value);
        }

        public int SumRange(int i, int j)
        {
            if (i == j)
            {
                return binaryIndexedTree[i];
            }

            if (i == 0)
            {
                return binaryIndexedTree.GetSum(j);
            }

            var sumJ = binaryIndexedTree.GetSum(j);
            var sumI = binaryIndexedTree.GetSum(i - 1);

            return sumJ - sumI;
        }

        public class BinaryIndexedTree
        {
            private int[] values;
            private int[] biaryIndexedArray;
            private int length;

            public BinaryIndexedTree(int[] values)
            {
                this.length = values.Length;
                this.values = values;
                this.biaryIndexedArray = new int[this.length + 1];
            }

            public int this[int index]
            {
                get
                {
                    return values[index];
                }
            }

            public void Build()
            {
                for (var i = 0; i < length; i++)
                {
                    Update(i, values[i], 0);
                }
            }

            public void Update(int index, int value)
            {
                var previousValue = values[index];
                values[index] = value;
                Update(index, value, previousValue);
            }

            private void Update(int index, int value, int previousValue)
            {
                var currentIndex = index + 1;
                while (currentIndex <= length)
                {
                    biaryIndexedArray[currentIndex] += value;
                    biaryIndexedArray[currentIndex] -= previousValue;
                    currentIndex += (currentIndex) & (-currentIndex);
                }
            }

            public int GetSum(int index)
            {
                var sum = 0;
                var currentIndex = index + 1;
                while (currentIndex > 0)
                {
                    sum += biaryIndexedArray[currentIndex];
                    currentIndex -= (currentIndex) & (-currentIndex);
                }
                return sum;
            }
        }
    }
}

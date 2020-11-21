using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// </summary>
    public class Leetcode_215_KthLargestElementInAnArray_V1
    {
        private MaxHeap maxHeap;

        public int FindKthLargestElement(int[] nums, int k)
        {
            maxHeap = new MaxHeap(nums.Length);
            foreach(var num in nums)
            {
                maxHeap.Insert(num);
            }

            int kthLargestElement = 0;
            for (var i = 0; i < k; i++)
            {
                kthLargestElement = maxHeap.ExtractMax();
            }

            return kthLargestElement;
        }

        public class MaxHeap
        {
            private int[] nums;
            private int length;
            private int count;

            public int GetParent(int index)
            {
                return (index - 1) / 2;
            }

            public int GetLeftChild(int index)
            {
                return 2 * index + 1;
            }

            public int GetRightChild(int index)
            {
                return 2 * index + 2;
            }

            public MaxHeap(int length)
            {
                this.nums = new int[length];
                this.length = length;
                this.count = 0;
            }

            public void Insert(int value)
            {
                if (count == 0)
                {
                    nums[0] = value;
                    count += 1;
                    return;
                }

                var currentIndex = count;
                nums[currentIndex] = value;
                count += 1;                
                while(currentIndex > 0)
                {
                    var parentIndex = GetParent(currentIndex);
                    if (nums[currentIndex] > nums[parentIndex])
                    {
                        var temp = nums[parentIndex];
                        nums[parentIndex] = nums[currentIndex];
                        nums[currentIndex] = temp;
                        currentIndex = parentIndex;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public void Heapify(int index)
            {
                var currentMaxIndex = index;
                var leftChild = GetLeftChild(index);
                var rightChild = GetRightChild(index);

                if (leftChild < count)
                {
                    if (nums[leftChild] > nums[currentMaxIndex])
                    {
                        currentMaxIndex = leftChild;
                    }
                }

                if (rightChild < count)
                {
                    if (nums[rightChild] > nums[currentMaxIndex])
                    {
                        currentMaxIndex = rightChild;
                    }
                }

                if (currentMaxIndex == index)
                {
                    return;
                }

                var temp = nums[index];
                nums[index] = nums[currentMaxIndex];
                nums[currentMaxIndex] = temp;

                Heapify(currentMaxIndex);
            }

            public int ExtractMax()
            {
                var root = nums[0];
                var lastIndex = count - 1;
                var last = nums[lastIndex];
                nums[0] = last;
                count -= 1;
                Heapify(0);
                return root;
            }
        }
    }
}

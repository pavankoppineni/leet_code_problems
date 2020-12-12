using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/next-greater-element-i/
    /// </summary>
    public class Leetcode_496_NextGreaterElementI_V1
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nextGreaterElementLookup = new Dictionary<int, int>();
            var nextGreaterElementStack = new Stack<int>();
            nextGreaterElementStack.Push(nums2[0]);
            for (var i = 1; i < nums2.Length; i++)
            {
                var currentNumber = nums2[i];
                while (nextGreaterElementStack.Count > 0)
                {
                    var previousNumber = nextGreaterElementStack.Peek();
                    if (currentNumber > previousNumber)
                    {
                        nextGreaterElementLookup.Add(previousNumber, currentNumber);
                        nextGreaterElementStack.Pop();
                    }
                    else
                    {
                        nextGreaterElementStack.Push(currentNumber);
                        break;
                    }
                }
            }

            var nextGreaterElementArray = new int[nums1.Length];
            for (var i = 0; i < nums1.Length; i++)
            {
                if(nextGreaterElementLookup.ContainsKey(nums1[i]))
                {
                    nextGreaterElementArray[i] = nextGreaterElementLookup[nums1[i]];
                }
                else
                {
                    nextGreaterElementArray[i] = -1;
                }
            }

            return nextGreaterElementArray;
        }
    }
}

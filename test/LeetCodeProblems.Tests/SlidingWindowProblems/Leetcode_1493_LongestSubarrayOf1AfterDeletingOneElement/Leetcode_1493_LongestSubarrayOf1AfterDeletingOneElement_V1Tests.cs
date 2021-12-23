using LeetCodeProblems.SlidingWindowProblems.Leetcode_1493_LongestSubarrayOf1AfterDeletingOneElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.SlidingWindowProblems.Leetcode_1493_LongestSubarrayOf1AfterDeletingOneElement
{
    [TestClass]
    public class Leetcode_1493_LongestSubarrayOf1AfterDeletingOneElement_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfBinaryValues_When_FindLongestSubArray_Then_ShouldReturnLongestSubArray()
        {
            //Given
            var values = new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 };
            var problem = new Leetcode_1493_LongestSubarrayOf1AfterDeletingOneElement_V1();
            var expectedValue = 4;

            //When
            var actualVlaue = problem.LongestSubarray(values);

            //Then
            Assert.AreEqual(expectedValue, actualVlaue);
        }
    }
}

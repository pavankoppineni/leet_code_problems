using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_581_ShortestUnsortedContinuousSubarray_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindUnsortedContinuousSubArray_Then_ShouldReturnLengthOfSubArray()
        {
            //Given
            var nums = new int[] { 2, 6, 4, 8, 10, 9, 15 };
            var problem = new Leetcode_581_ShortestUnsortedContinuousSubarray_V1();
            var expectedResukt = 5;

            //When
            var actualResult = problem.FintUnsortedArray(nums);

            //Then
            Assert.AreEqual(expectedResukt, actualResult);
        }
    }
}

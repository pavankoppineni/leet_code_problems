using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOr_EqualToThreshold_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegersAndThreshold_When_FindNumberOfSubArrays_Then_ShouldReturnNumberOfSubArrays()
        {
            //Given
            var values = new int[] { 2, 2, 2, 2, 5, 5, 5, 8 };
            var subArraySize = 3;
            var threshold = 4;
            var expectedResult = 3;
            var problem = new Leetcode_1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOr_EqualToThreshold_V1();
            //When
            var actualResult = problem.FindNumberOfSubArrays(values, subArraySize, threshold);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

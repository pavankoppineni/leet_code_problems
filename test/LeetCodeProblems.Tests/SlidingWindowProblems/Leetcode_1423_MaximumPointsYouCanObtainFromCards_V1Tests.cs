using LeetCodeProblems.SlidingWindowProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.SlidingWindowProblems
{
    [TestClass]
    public class Leetcode_1423_MaximumPointsYouCanObtainFromCards_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMaximumPoints_Then_ReturnMaximumPoints()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5, 6, 1 };
            var expectedValue = 12;
            var problem = new Leetcode_1423_MaximumPointsYouCanObtainFromCards_V1();
            var k = 3;

            //When
            var actualValue = problem.CalculateMaximumScore(values, k);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

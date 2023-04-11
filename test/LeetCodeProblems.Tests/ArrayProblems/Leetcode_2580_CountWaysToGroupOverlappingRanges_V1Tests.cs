using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2580_CountWaysToGroupOverlappingRanges_V1Tests
    {
        [TestMethod]
        public void Given_Ranges_When_CalculateWays_Then_ShouldReturnWays()
        {
            //Given
            var ranges = new int[2][]
            {
                new int[] { 11,48},
                new int[]{12, 16},
            };
            var problem = new Leetcode_2580_CountWaysToGroupOverlappingRanges_V1();
            var expectedResult = 12;

            //When
            var actualResult = problem.CountWays(ranges);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

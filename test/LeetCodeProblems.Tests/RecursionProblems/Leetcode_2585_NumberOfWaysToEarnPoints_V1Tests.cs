using LeetCodeProblems.RecursionProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.RecursionProblems
{
    [TestClass]
    public class Leetcode_2585_NumberOfWaysToEarnPoints_V1Tests
    {
        [TestMethod]
        public void Given_TargetAndTypes_When_CalculateNumberOfWays_Then_ShouldReturnNumberOfWays()
        {
            //Given
            var types = new int[3][]
            {
                new int[] { 6, 1},
                new int[] { 3, 2},
                new int[] {2, 3}
            };
            var target = 6;
            var problem = new Leetcode_2585_NumberOfWaysToEarnPoints_V1();
            var expectedResult = 7;

            //When
            var actualResult = problem.CalculateNumberOfWays(target, types);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

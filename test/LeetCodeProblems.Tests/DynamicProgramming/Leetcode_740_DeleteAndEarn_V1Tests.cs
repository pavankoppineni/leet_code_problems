using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_740_DeleteAndEarn_V1Tests
    {
        [TestMethod]
        public void Given_Points_When_CalculatMaximumPoints_Then_ShouldReturnMaximumPoints()
        {
            //Given
            var values = new int[] { 3, 4, 2 };
            var problem = new Leetcode_740_DeleteAndEarn_V1();
            var expectedResult = 9;

            //When
            var actualResult = problem.CalculateMaximumPoints(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

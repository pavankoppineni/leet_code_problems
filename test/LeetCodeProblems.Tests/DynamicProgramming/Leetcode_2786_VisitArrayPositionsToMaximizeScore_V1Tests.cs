using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2786_VisitArrayPositionsToMaximizeScore_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMaximumScore_Then_ShouldReturnMaximumScore()
        {
            //Given
            var values = new int[] { 8, 50, 65, 85, 8, 73, 55, 50, 29, 95, 5, 68, 52, 79 };
            var problem = new Leetcode_2786_VisitArrayPositionsToMaximizeScore_V2();
            var expectedResult = 470;

            //When
            var actualResult = problem.CalculateMaximumScore(values, 74);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

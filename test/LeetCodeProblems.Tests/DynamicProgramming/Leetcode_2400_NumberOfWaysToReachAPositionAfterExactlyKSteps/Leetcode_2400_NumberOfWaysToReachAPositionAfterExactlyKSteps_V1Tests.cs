using LeetCodeProblems.DynamicProgramming.Leetcode_2400_NumberOfWaysToReachAPositionAfterExactlyKSteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_2400_NumberOfWaysToReachAPositionAfterExactlyKSteps
{
    [TestClass]
    public class Leetcode_2400_NumberOfWaysToReachAPositionAfterExactlyKSteps_V1Tests
    {
        [TestMethod]
        public void Given_StartAndEndPoistion_When_CalculateNumberOfWays_Then_ShouldReturnNumberOfWays()
        {
            //Given
            var startPosition = 542;
            var endPosition = 413;
            var steps = 267;
            var probelm = new Leetcode_2400_NumberOfWaysToReachAPositionAfterExactlyKSteps_V1();
            var expectedResult = 934081896;

            //When
            var actualResult = probelm.CalculateNumberOfWays(startPosition, endPosition, steps);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

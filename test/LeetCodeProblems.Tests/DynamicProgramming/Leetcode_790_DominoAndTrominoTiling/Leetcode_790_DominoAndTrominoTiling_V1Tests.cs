using LeetCodeProblems.DynamicProgramming.Leetcode_790_DominoAndTrominoTiling;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_790_DominoAndTrominoTiling
{
    [TestClass]
    public class Leetcode_790_DominoAndTrominoTiling_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CalculateNumberOfWays_Then_ShouldReturnNumberOfWays()
        {
            //Given
            var problem = new Leetcode_790_DominoAndTrominoTiling_V1();
            var expectedWays = 10;
            var number = 7;

            //When
            var actualWays = problem.CalculateDominoTiling(number);

            //Then
            Assert.AreEqual(expectedWays, actualWays);
        }
    }
}

using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_2139_MinimumMovesToReachTargetScore_V1Tests
    {
        [TestMethod]
        public void Given_TargetScore_When_CalculateMinimumMoves_Then_ShouldReturnMinimumMoves()
        {
            //Given
            var targetScore = 19;
            var maxDoubles = 2;
            var problem = new Leetcode_2139_MinimumMovesToReachTargetScore_V1();
            var expectedMoves = 7;

            //When
            var actualMoves = problem.CalculateMinimumMoves(targetScore, maxDoubles);

            //Then
            Assert.AreEqual(expectedMoves, actualMoves);
        }
    }
}

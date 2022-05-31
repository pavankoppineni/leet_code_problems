using LeetCodeProblems.BacktrackingProblems.Leetcode_473_MatchsticksToSquare;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_473_MatchsticksToSquare
{
    [TestClass]
    public class Leetcode_473_MatchsticksToSquare_V1Tests
    {
        [TestMethod]
        public void Given_Matchsticks_When_CanMakeSquare_Then_ShouldReturnTrueOrFalse()
        {
            //Given
            var matchSticks = new int[] { 3, 3, 3, 3, 4 };
            var problem = new Leetcode_473_MatchsticksToSquare_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.CanMakeSquare(matchSticks);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

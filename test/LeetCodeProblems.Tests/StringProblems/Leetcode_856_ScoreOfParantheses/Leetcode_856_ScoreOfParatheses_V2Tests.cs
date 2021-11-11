using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_856_ScoreOfParatheses_V2Tests
    {
        [TestMethod]
        public void Given_Parantheses_When_CalculateScore_Then_ShouldReturnScoreOfParantheses()
        {
            //Given
            var parantheses = "{{}{}}";
            var problem = new Leetcode_856_ScoreOfParatheses_V2();
            var expectedScore = 4;

            //When
            var actualScore = problem.CalculateScore(parantheses);

            //Then
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}

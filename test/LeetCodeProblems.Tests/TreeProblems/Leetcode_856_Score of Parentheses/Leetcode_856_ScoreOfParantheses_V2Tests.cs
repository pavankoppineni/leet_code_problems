using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_856_ScoreOfParantheses_V2Tests
    {
        [TestMethod]
        public void Given_ParanthesesString_When_CalculateScore_Then_ShouldReturnScore()
        {
            //Given
            var paranetheses = "{{}{}}{{}}";
            var problem = new Leetcode_856_ScoreOfParantheses_V2();
            var expectedScore = 6;

            //When
            var actualScore = problem.CalculateScore(paranetheses);

            //Then
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}

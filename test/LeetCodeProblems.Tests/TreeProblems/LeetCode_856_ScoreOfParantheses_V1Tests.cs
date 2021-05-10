using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class LeetCode_856_ScoreOfParantheses_V1Tests
    {
        [TestMethod]
        public void Given_BalancedParantheses_When_FindScoreOfParantheses_Then_ShouldReturnScoreOfParantheses()
        {
            //Given
            var parantheses = "{}{}";
            var problem = new LeetCode_856_ScoreOfParantheses_V1();

            //When
            var expectedParanthesesScore = problem.CalculateScoreOfParantheses(parantheses);

            //Then
            Assert.Fail();
        }
    }
}

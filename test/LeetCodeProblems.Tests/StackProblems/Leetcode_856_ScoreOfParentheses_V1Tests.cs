using LeetCodeProblems.StackProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StackProblems
{
    [TestClass]
    public class Leetcode_856_ScoreOfParentheses_V1Tests
    {
        [TestMethod]
        public void Given_Parentheses_When_CalculateScore_Then_ShouldReturnScore()
        {
            //Given
            var parentheses = "(()()(()))(()()(()))";
            var problem = new Leetcode_856_ScoreOfParentheses_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateScore(parentheses);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

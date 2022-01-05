using LeetCodeProblems.StackProblems.Leetcode_150_EvaluateReversePolishNotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StackProblems.Leetcode_150_EvaluateReversePolishNotation
{
    [TestClass]
    public class Leetcode_150_EvaluateReversePolishNotation_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfStrings_When_EvaluateTokens_Then_ShouldReturnValue()
        {
            //Given
            var tokens = new string[] { "2", "1", "+", "3", "*" };
            var problem = new Leetcode_150_EvaluateReversePolishNotation_V1();
            var expectedResult = 9;

            //When
            var actualResult = problem.Evaluate(tokens);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

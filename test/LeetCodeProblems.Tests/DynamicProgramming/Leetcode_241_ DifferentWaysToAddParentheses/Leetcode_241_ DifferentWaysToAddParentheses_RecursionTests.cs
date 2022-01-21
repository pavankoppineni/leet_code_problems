using LeetCodeProblems.DynamicProgramming.Leetcode_241__DifferentWaysToAddParentheses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_241__DifferentWaysToAddParentheses
{
    [TestClass]
    public class Leetcode_241_DifferentWaysToAddParentheses_RecursionTests
    {
        [TestMethod]
        public void Given_StringExpression_When_Evaluate_Then_ShouldReturnValues()
        {
            //Given
            var expression = "2-1-1";
            var problem = new Leetcode_241_DifferentWaysToAddParentheses_Recursion();
            var expectedCount = 2;

            //When
            var actualCount = problem.DiffWaysToCompute(expression);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

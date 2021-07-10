using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_22_GenerateParentheses_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_GenerateParantheses_Then_ShouldGenerateParantheses()
        {
            //Given
            var number = 3;
            var problem = new Leetcode_22_GenerateParentheses_V1();
            var expectedResult = new List<string>();

            //When
            var actualResult = problem.GenerateParantheses(number);

            //Then
            Assert.Fail();
        }
    }
}

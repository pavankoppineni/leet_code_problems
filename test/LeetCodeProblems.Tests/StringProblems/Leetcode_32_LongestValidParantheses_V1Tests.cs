using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_32_LongestValidParantheses_V1Tests
    {
        [TestMethod]
        public void Given_ParanthesesString_When_FindLongestValidParantheses_Then_ShouldReturnLengthOfLongestValidParantheses()
        {
            //Given
            var parantheses = "()";
            var expectedResult = 4;
            var problem = new Leetcode_32_LongestValidParantheses_V1();

            //When
            var actualResult = problem.FindLongestValidParantheses(parantheses);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

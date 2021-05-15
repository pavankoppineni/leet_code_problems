using LeetCodeProblems.MathProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MathProblems
{
    [TestClass]
    public class Leetcode_9_PalindromeNumber_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CheckPalindrome_Then_ShouldReturnTrueForPalindromeNumber()
        {
            //Given
            var number = 121;
            var problem = new Leetcode_9_PalindromeNumber_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.IsPalindrome(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.Greedy.Leetcode_402_RemoveKDigits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_402_RemoveKDigits
{
    [TestClass]
    public class Leetcode_402_RemoveKDigits_V1Tests
    {
        [TestMethod]
        public void Given_NumberAndDigitsToRemove_When_RemoveDigits_Then_ShouldReturnMinimumNumber()
        {
            //Given
            var num = "1231";
            var k = 3;
            var problem = new Leetcode_402_RemoveKDigits_V1();
            var expectedResult = "1219";

            //When
            var actualResult = problem.RemoveKDigits(num, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

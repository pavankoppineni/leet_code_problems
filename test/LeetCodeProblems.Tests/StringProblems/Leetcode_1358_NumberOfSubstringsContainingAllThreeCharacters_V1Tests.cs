using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_1358_NumberOfSubstringsContainingAllThreeCharacters_V1Tests
    {
        [TestMethod]
        public void Given_String_When_CalculateSubStrings_Then_ShouldReturnCount()
        {
            //Given
            var str = "ababcabab";
            var problem = new Leetcode_1358_NumberOfSubstringsContainingAllThreeCharacters_V1();
            var expectedCount = 22;

            //When
            var actualCount = problem.CalculateNumberOfSubstrings(str);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

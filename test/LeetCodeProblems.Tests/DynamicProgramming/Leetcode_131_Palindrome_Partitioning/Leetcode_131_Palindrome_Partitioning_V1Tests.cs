using LeetCodeProblems.DynamicProgramming.Leetcode_131_Palindrome_Partitioning;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_131_Palindrome_Partitioning
{
    [TestClass]
    public class Leetcode_131_Palindrome_Partitioning_V1Tests
    {
        [TestMethod]
        public void Given_String_When_GeneratePalindromes_Then_ShouldReturnPalindromeStrings()
        {
            //Given
            var str = "aab";
            var problem = new Leetcode_131_Palindrome_Partitioning_V1();
            var expectedCount = 2;

            //When
            var actualCount = problem.GeneratePalindromes(str);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

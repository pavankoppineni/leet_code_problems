using LeetCodeProblems.DynamicProgramming.Leetcode_91_DecodeWays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_91_DecodeWays
{
    [TestClass]
    public class Leetcode_91_DecodeWays_RecursionTests
    {
        [TestMethod]
        public void Given_String_When_DecodeWays_Then_ShouldDecodeNumberOfWays()
        {
            //Given
            var str = "226";
            var problem = new Leetcode_91_DecodeWays_Recursion();
            var expectedCount = 3;

            //When
            var actualCount = problem.DecodeWays(str);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

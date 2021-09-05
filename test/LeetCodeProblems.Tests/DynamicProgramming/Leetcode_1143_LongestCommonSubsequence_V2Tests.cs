using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_1143_LongestCommonSubsequence_V2Tests
    {
        [TestMethod]
        public void Given_TwoStrings_When_FindLongestCommonSubsequence_Then_ShouldReturnLongestCommonSubsequence()
        {
            //Given
            var strOne = "abcde";
            var strTwo = "ace";
            var problem = new Leetcode_1143_LongestCommonSubsequence_V2();
            var expectedResult = 3;

            //When
            var actualResult = problem.FindLongestCommonSubsequence(strOne, strTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

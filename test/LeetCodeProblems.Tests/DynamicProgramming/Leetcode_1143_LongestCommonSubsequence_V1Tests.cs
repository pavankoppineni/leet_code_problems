using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_1143_LongestCommonSubsequence_V1Tests
    {
        [TestMethod]
        public void Given_TwoIntegerArrays_When_FindLongestCommonSubsequence_Then_ShouldReturnLongestCommonSubsequence()
        {
            //Given
            var valuesOne = new int[] { 1, 5, 2, 5, 3 };
            var valuesTwo = new int[] { 1, 2, 3 };
            var problem = new Leetcode_1143_LongestCommonSubsequence_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.Calculate(valuesOne, valuesTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

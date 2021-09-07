using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_300_LongestIncreasingSubsequence_V1Tests
    {
        [TestMethod]
        public void Given_SequenceOfIntegers_When_FindLongestIncreasingSequence_Then_ShouldReturnLongestIncreasingSequence()
        {
            //Given
            var values = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            var problem = new Leetcode_300_LongestIncreasingSubsequence_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.FindLongestIncreasingSubsequence(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

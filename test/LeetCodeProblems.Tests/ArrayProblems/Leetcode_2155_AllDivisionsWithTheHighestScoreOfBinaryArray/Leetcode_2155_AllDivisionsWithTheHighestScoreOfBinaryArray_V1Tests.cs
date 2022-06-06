using LeetCodeProblems.ArrayProblems.Leetcode_2155_AllDivisionsWithTheHighestScoreOfBinaryArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2155_AllDivisionsWithTheHighestScoreOfBinaryArray
{
    [TestClass]
    public class Leetcode_2155_AllDivisionsWithTheHighestScoreOfBinaryArray_V1Tests
    {
        [TestMethod]
        public void Given_BinaryArray_When_CalculateMaxScore_Then_ShouldReturnMaxScore()
        {
            //Given
            var binaryArray = new int[] { 1, 1 };
            var problem = new Leetcode_2155_AllDivisionsWithTheHighestScoreOfBinaryArray_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateMaxScore(binaryArray);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}

using LeetCodeProblems.ArrayProblems.Leetcode_2270_NumberOfWaysToSplitArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2270_NumberOfWaysToSplitArray
{
    [TestClass]
    public class Leetcode_2270_NumberOfWaysToSplitArray_V1Tests
    {
        [TestMethod]
        [DataRow(new int[] { 10, 4, -8, 7 }, 2)]
        [DataRow(new int[] { 2, 3, 1, 0 }, 2)]
        public void Given_Values_When_CalculateNumberOfWays_Then_ShouldReturnNumberOfWays(int[] values, int expectedResult)
        {
            //Given
            var problem = new Leetcode_2270_NumberOfWaysToSplitArray_V1();

            //When
            var actualResult = problem.CalculateNumberOfWays(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.BinarySearchProblems.Leetcode_1712_WaysToSplitArrayIntoThreeSubarrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_1712_WaysToSplitArrayIntoThreeSubarrays
{
    [TestClass]
    public class Leetcode_1712_WaysToSplitArrayIntoThreeSubarrays_V1Tests
    {
        [DataRow(new int[] { 8, 3, 2, 0, 0, 6 }, 0)]
        [DataRow(new int[] { 5, 10, 1, 10, 4 }, 2)]
        [DataRow(new int[] { 2, 3, 5, 10 }, 3)]
        [DataRow(new int[] { 1, 2, 2, 2, 5, 0 }, 3)]
        [DataRow(new int[] { 1, 2, 3 }, 1)]
        [DataRow(new int[] { 1, 1, 1 }, 1)]
        [DataRow(new int[] {3, 2, 1}, 0)]
        [DataTestMethod]
        public void Given_ArrayOfIntegers_When_CalculateNumberOfWays_Then_ShouldReturnNumberOfWays(int[] values, int expectedWays)
        {
            //Given
            var problem = new Leetcode_1712_WaysToSplitArrayIntoThreeSubarrays_V1();

            //When
            var actualWays = problem.CalculateNumberOfWays(values);

            //Then
            Assert.AreEqual(expectedWays, actualWays);
        }
    }
}

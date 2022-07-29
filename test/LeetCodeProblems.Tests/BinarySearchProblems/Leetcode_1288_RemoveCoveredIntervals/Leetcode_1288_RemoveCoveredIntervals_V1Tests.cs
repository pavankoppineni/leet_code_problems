using LeetCodeProblems.BinarySearchProblems.Leetcode_1288_RemoveCoveredIntervals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_1288_RemoveCoveredIntervals
{
    [TestClass]
    public class Leetcode_1288_RemoveCoveredIntervals_V1Tests
    {
        [TestMethod]
        public void Given_Intervals_When_FindNonCoveredIntervals_Then_ShouldReturnNonCoveredIntervals()
        {
            //Given
            var intervals = new int[3][]
            {
                new int[] { 3, 7},
                new int[] { 1, 7},
                new int[] { 2, 7}
            };
            var problem = new Leetcode_1288_RemoveCoveredIntervals_V1();
            var actualResult = 2;

            //When
            var expectedResult = problem.CalculateCoveredIntervals(intervals);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

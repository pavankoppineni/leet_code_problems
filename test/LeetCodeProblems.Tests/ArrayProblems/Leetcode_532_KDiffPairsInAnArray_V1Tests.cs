using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_532_KDiffPairsInAnArray_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArrayAndDifference_When_FindPairs_Then_ShouldReturnCountOfPairs()
        {
            //Given
            var values = new int[] { 3, 1, 4, 1, 5 };
            var difference = 2;
            var expectedPairsCount = 2;
            var problem = new Leetcode_532_KDiffPairsInAnArray_V1();

            //When
            var actualPairsCount = problem.FindPairs(values, difference);

            //Then
            Assert.AreEqual(expectedPairsCount, actualPairsCount);
        }
    }
}

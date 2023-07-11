using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_2294_PartitionArraySuchThatMaximumDifferenceIsK_V1Tests
    {
        [TestMethod]
        public void Given_IntergerArray_When_CalculateMinimumNumberSequences_Then_ShouldReturnMinimumSequences()
        {
            //Given
            var values = new int[] { 3, 6, 1, 2, 5 };
            var maxDifference = 2;
            var problem = new Leetcode_2294_PartitionArraySuchThatMaximumDifferenceIsK_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMinimumSequences(values, maxDifference);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

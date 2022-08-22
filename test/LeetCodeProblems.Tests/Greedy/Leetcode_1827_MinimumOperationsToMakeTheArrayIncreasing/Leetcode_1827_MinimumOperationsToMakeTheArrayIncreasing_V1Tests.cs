using LeetCodeProblems.Greedy.Leetcode_1827_MinimumOperationsToMakeTheArrayIncreasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_1827_MinimumOperationsToMakeTheArrayIncreasing
{
    [TestClass]
    public class Leetcode_1827_MinimumOperationsToMakeTheArrayIncreasing_V1Tests
    {
        [TestMethod]
        public void Given_Numbers_When_CalculateMinimumOperations_Then_ShouldReturnMinimumOperations()
        {
            //Given
            var values = new int[] { 1, 5, 2, 4, 1 };
            var problem = new Leetcode_1827_MinimumOperationsToMakeTheArrayIncreasing_V1();
            var expectedResult = 14;

            //When
            var actualResult = problem.CalculateMinimumOperations(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

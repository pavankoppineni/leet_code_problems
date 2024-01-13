using LeetCodeProblems.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BitManipulation
{
    [TestClass]
    public class Leetcode_2997_MinimumNumberOfOperationsToMakeArrayXOREqualToK_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateOperations_Then_ShouldReturnMinOperations()
        {
            //Given
            var nums = new int[] { 1, 2, 3, 4};
            var k = 1;
            var problem = new Leetcode_2997_MinimumNumberOfOperationsToMakeArrayXOREqualToK_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateMinOperations(nums, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

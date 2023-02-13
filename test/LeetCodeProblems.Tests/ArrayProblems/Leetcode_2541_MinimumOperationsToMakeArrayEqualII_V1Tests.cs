using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2541_MinimumOperationsToMakeArrayEqualII_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArrays_When_CalculateMinimumOperations_Then_ShouldReturnMinimumOperations()
        {
            //Given
            var nums1 = new int[] { 10, 5, 15, 20 };
            var nums2 = new int[] { 20, 10, 15, 5 };
            var k = 0;
            var problem = new Leetcode_2541_MinimumOperationsToMakeArrayEqualII_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.MinOperations(nums1, nums2, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

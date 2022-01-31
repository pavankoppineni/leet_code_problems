using LeetCodeProblems.ArrayProblems.Leetcode_1589_MaximumSumObtainedOfAnyPermutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_1589_MaximumSumObtainedOfAnyPermutation
{
    [TestClass]
    public class Leetcode_1589_MaximumSumObtainedOfAnyPermutation_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArrayAndRequests_When_FindMaximumSum_Then_ShouldReturnMaximumSum()
        {
            //Given
            var values = new int[] { 1, 2, 3, 4, 5 };
            var requests = new int[2][]
            {
                new int[]{1,3},
                new int[]{0,1},
            };
            var problem = new Leetcode_1589_MaximumSumObtainedOfAnyPermutation_V1();
            var expectedResult = 19;

            //When
            var actualResult = problem.MaxSumRangeQuery(values, requests);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

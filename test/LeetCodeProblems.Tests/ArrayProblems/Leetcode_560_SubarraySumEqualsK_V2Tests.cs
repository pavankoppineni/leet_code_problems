using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_560_SubarraySumEqualsK_V2Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindNumberOfSubarrays_Then_ShouldReturnNumberOfSubarrays()
        {
            //Given
            var values = new int[] { 23, 2, 4, 6, 7 };
            var problem = new Leetcode_560_SubarraySumEqualsK_V2();
            var expectedResult = 2;
            var sum = 6;

            //When
            var actualResult = problem.FintTotalSubArrayCount(values, sum);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.SlidingWindowProblems.Leetcode_2348_NumberOfZeroFilledSubarrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.SlidingWindowProblems.Leetcode_2348_NumberOfZeroFilledSubarrays
{
    [TestClass]
    public class Leetcode_2348_NumberOfZeroFilledSubarrays_V1Tests
    {
        [DataTestMethod]
        [DataRow(new int[] {1,3,0,0,2,0,0,4 }, 6)]
        [DataRow(new int[] { 0, 0, 0, 2, 0, 0 }, 9)]
        [DataRow(new int[] { 1, 2, 3 }, 0)]
        public void Given_ArrayOfIntegers_When_CalculateNumberOfSubarrays_Then_ShouldReturnCountOfSubarrays(int[] values, int expectedCount)
        {
            //Given
            var problem = new Leetcode_2348_NumberOfZeroFilledSubarrays_V1();

            //When
            var actualCount = problem.CalculateNumberOfSubArrays(values);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

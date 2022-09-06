using LeetCodeProblems.DynamicProgramming.Leetcode_801_MinimumSwapsToMakeSequencesIncreasing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.Leetcode_801_MinimumSwapsToMakeSequencesIncreasing
{
    [TestClass]
    public class Leetcode_801_MinimumSwapsToMakeSequencesIncreasing_V1Tests
    {
        [TestMethod]
        public void Given_TwoArrays_When_CalculateMinimumSwaps_Then_ShouldReturnMinimumSwaps()
        {
            //Given
            var arr1 = new int[] { 1, 3, 5, 4 };
            var arr2 = new int[] { 1, 2, 3, 7 };
            var problem = new Leetcode_801_MinimumSwapsToMakeSequencesIncreasing_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateMinimumSwaps(arr1, arr2);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_2044_CountNumberOfMaximumBitwiseORSubsets_V1Tests
    {
        [TestMethod]
        public void Given_Values_When_CalculateNumberOfSubsets_Then_ShouldReturnMaximumNumberOfSubsets()
        {
            //Given
            var values = new int[] { 3, 2, 1, 5 };
            var problem = new Leetcode_2044_CountNumberOfMaximumBitwiseORSubsets_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.CalculateMaxSubSets(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

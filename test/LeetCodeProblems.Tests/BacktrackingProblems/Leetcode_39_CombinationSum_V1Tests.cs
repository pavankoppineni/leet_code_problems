using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_39_CombinationSum_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GenerateCombinationSum_Then_ShouldReturnListOfCombinations()
        {
            //Given
            var values = new int[] { 2, 3, 6, 7 };
            var problem = new Leetcode_39_CombinationSum_V1();
            var expectedCombinationsCount = 2;
            var sum = 7;

            //When
            var actualCombinations = problem.FindCombinations(values, sum);

            //Then
            Assert.AreEqual(expectedCombinationsCount, actualCombinations.Count);
        }
    }
}

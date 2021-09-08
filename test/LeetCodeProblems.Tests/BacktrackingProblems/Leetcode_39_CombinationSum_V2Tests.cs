using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_39_CombinationSum_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GenerateCombinationSum_Then_ShouldGenerateListOfCombinationSum()
        {
            //Given
            var values = new int[] { 2, 3, 6, 7 };
            var expectedResult = 2;
            var problem = new Leetcode_39_CombinationSum_V2();
            var sum = 7;

            //When
            var actualResult = problem.CalculateCombinationSum(values, sum);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}

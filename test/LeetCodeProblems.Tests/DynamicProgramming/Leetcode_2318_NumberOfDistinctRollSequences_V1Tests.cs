using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2318_NumberOfDistinctRollSequences_V1Tests
    {
        [TestMethod]
        public void Given_NumberOfRolls_When_CalculateDistinctSequences_Then_ShouldReturnDistinctSequences()
        {
            //Given
            var rolls = 4;
            var problem = new Leetcode_2318_NumberOfDistinctRollSequences_V1();
            var expectedResult = 188;

            //When
            var actualResult = problem.CalculateDistinctSequences(rolls);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

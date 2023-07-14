using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_491_NonDecreasingSubsequences_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateNonDecreasingSubsequences_Then_ShouldReturnSubsequences()
        {
            //Given
            var values = new int[] { 4, 6, 7, 7 };
            var problem = new Leetcode_491_NonDecreasingSubsequences_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.FindSubsequences(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}

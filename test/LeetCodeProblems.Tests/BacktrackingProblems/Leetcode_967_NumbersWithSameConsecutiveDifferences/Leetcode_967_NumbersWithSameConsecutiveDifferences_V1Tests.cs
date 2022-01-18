using LeetCodeProblems.BacktrackingProblems.Leetcode_967_NumbersWithSameConsecutiveDifferences;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems.Leetcode_967_NumbersWithSameConsecutiveDifferences
{
    [TestClass]
    public class Leetcode_967_NumbersWithSameConsecutiveDifferences_V1Tests
    {
        [TestMethod]
        public void Given_NumberAndDifference_When_GenerateCombinations_Then_ShouldReturnAllCombinations()
        {
            //Given
            var size = 3;
            var difference = 0;
            var problem = new Leetcode_967_NumbersWithSameConsecutiveDifferences_V1();

            //When
            var actualResult = problem.NumsSameConsecDiff(size, difference);

            //Then
            Assert.Inconclusive();
        }
    }
}

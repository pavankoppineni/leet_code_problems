using LeetCodeProblems.BacktrackingProblems.Leetcode_90_Subsets_II;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems.Leetcode_90_Subsets_II
{
    [TestClass]
    public class Leetcode_90_Subsets_IIV1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_GenerateSubsets_Then_ShouldReturnSubsets()
        {
            //Given
            var values = new int[] { 1, 2, 2 };
            var problem = new Leetcode_90_Subsets_IIV1();
            var expectedSubsetsCount = 4;

            //When
            var actualSubsetsCount = problem.GenerateSubsets(values);

            //Then
            Assert.AreEqual(expectedSubsetsCount, actualSubsetsCount);
        }
    }
}

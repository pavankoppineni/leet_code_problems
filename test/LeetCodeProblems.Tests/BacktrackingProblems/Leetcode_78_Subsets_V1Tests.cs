using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_78_Subsets_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GenerateSubsets_Then_ShouldGenerateSubsets()
        {
            //Given
            var values = new int[] { 1, 2 };
            var problem = new Leetcode_78_Subsets_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.GenerateSubsets(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}

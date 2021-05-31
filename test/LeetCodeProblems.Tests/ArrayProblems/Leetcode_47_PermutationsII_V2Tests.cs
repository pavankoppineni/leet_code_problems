using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_47_PermutationsII_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GeneratePermutations_Then_ShouldReturnPermutations()
        {
            //Given
            var values = new int[] { 1, 1, 2};
            var problem = new Leetcode_47_PermutationsII_V2();
            var expectedResult = new List<int[]>
            {
                new int[]{1, 1, 2},
                new int[]{1, 2, 1},
                new int[]{2, 1, 1}
            };

            //When
            var actualResult = problem.Permutations(values);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
    }
}

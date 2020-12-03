using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_47_PermutationsII_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_Permutate_Then_ShouldGeneratePermutations()
        {
            //Given
            var nums = new int[] { 1, 1, 2 };
            var problem = new Leetcode_47_PermutationsII_V1();
            var expectedResult = new List<List<int>>
            {
                new List<int>{1, 1, 2},
                new List<int>{1, 2, 1},
                new List<int>{2, 1, 1},
            };

            //When
            var actualResult = problem.Permutate(nums);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
    }
}

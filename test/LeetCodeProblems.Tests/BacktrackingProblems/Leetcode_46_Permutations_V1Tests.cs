using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_46_Permutations_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GeneratePermutations_Then_ShouldReturnPermutations()
        {
            //Given
            var values = new int[] { 1, 2, 3 };
            var problem = new Leetcode_46_Permutations_V1();
            var expectedPermutations = new List<IList<int>>
            {
                new List<int>{1, 2, 3 },
                new List<int>{1, 3, 2 },
                new List<int>{2, 1, 3 },
                new List<int>{2, 3, 1 },
                new List<int>{3, 2, 1 },
                new List<int>{3, 1, 2 }
            };

            //When
            var actualPermutations = problem.Permutate(values);

            //Then
            Assert.AreEqual(expectedPermutations.Count, actualPermutations.Count);
            for (var i = 0; i < expectedPermutations.Count; i++)
            {
                var expectedPermutation = expectedPermutations[i];
                var actualPermutation = actualPermutations[i];
                for(var index = 0; index < expectedPermutation.Count; index++)
                {
                    Assert.AreEqual(expectedPermutation[index], actualPermutation[index]);
                }
            }
        }
    }
}

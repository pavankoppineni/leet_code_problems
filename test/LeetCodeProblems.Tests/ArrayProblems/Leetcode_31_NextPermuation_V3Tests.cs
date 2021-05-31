using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_31_NextPermuation_V3Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindNextPermutation_Then_ShouldReturnNextPermutation()
        {
            //Given
            var values = new int[] { 7, 1, 2, 4, 3, 2, 1 };
            var problem = new Leetcode_31_NextPermuation_V3();
            var expectedValues = new int[] { 7, 1, 3, 1, 2, 2, 4 };

            //When
            var actualValues = problem.GetNextPermutation(values);

            //Then
            Assert.AreEqual(expectedValues.Length, actualValues.Length);
            for (var index = 0; index < expectedValues.Length; index++)
            {
                Assert.AreEqual(expectedValues[index], actualValues[index]);
            }
        }
    }
}

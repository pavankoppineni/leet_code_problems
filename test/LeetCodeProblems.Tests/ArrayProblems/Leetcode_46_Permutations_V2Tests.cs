using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_46_Permutations_V2Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GeneratePermutations_Then_ShouldReturnPermutations()
        {
            //Given
            var values = new int[] { 1, 2, 3 };
            var problme = new Leetcode_46_Permutations_V2();
            var expectedValue = 6;

            //When
            var actualValue = problme.GeneratePermutations(values);

            //Then
            Assert.AreEqual(expectedValue, actualValue.Count);
        }
    }
}

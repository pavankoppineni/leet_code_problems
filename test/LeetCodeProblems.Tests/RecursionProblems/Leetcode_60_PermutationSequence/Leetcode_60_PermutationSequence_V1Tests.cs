using LeetCodeProblems.RecursionProblems.Leetcode_60_PermutationSequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.RecursionProblems.Leetcode_60_PermutationSequence
{
    [TestClass]
    public class Leetcode_60_PermutationSequence_V1Tests
    {
        [TestMethod]
        public void Given_LengthOfStringAndNumber_When_GeneratePermutation_Then_ShouldGetPermutation()
        {
            //Given
            var length = 3;
            var number = 3;
            var problem = new Leetcode_60_PermutationSequence_V1();
            var expectedResult = "213";

            //When
            var actualResult = problem.GetPermutation(length, number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

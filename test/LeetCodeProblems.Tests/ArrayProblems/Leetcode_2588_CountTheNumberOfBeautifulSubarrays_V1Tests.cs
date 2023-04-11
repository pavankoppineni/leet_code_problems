using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2588_CountTheNumberOfBeautifulSubarrays_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateBeautifulSubarrays_Then_ShouldReturnNumberOfSubArrays()
        {
            //Given
            var values = new int[] { 1, 1, 1, 1, 1 };
            var problem = new Leetcode_2588_CountTheNumberOfBeautifulSubarrays_V1();
            var expectedCount = 3;

            //When
            var actualCount = problem.CalculateNumberOfBeautifulSubArrays(values);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

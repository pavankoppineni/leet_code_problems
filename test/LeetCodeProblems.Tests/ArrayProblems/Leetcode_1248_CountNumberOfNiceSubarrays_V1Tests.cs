using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1248_CountNumberOfNiceSubarrays_V1Tests
    {
        [TestMethod]
        public void Given_NumbersArray_When_CalculateNumberOfSubArrays_Then_ShouldReturn()
        {
            //Given
            var values = new int[] { 2, 2, 2, 1, 2, 2, 1, 2, 2, 2 };
            var k = 2;
            var expectedResult = 2;
            var problem = new Leetcode_1248_CountNumberOfNiceSubarrays_V1();

            //When
            var actualResult = problem.CalculateNumberOfSubArrays(values, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

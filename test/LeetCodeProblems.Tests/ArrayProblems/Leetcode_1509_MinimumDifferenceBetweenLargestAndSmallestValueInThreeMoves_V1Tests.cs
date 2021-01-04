using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1509_MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMinimumDifference_Then_ShouldReturnDifferenceBetweenMinimumAndMaximumValue()
        {
            //Given
            var values = new int[] { 9, 48, 92, 48, 81, 31 };
            var problem = new Leetcode_1509_MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.FindMinDifference(values);

            //Then
            Assert.Fail();
        }
    }
}

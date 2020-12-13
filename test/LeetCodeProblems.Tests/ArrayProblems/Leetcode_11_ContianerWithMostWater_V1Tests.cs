using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_11_ContianerWithMostWater_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfVerticalLines_When_FindContainerWithMaximumWater_Then_ShouldReturnMaximumWaterContainerCanHold()
        {
            //Given
            var problem = new Leetcode_11_ContianerWithMostWater_V1();
            var heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expectedResult = 49;

            //When
            var actualResult = problem.FindContainerWithMaxWater(heights);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

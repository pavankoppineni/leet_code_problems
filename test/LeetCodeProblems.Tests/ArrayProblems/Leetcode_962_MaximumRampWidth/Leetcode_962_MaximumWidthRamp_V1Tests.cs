using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_962_MaximumWidthRamp_V1Tests
    {
        [TestMethod]
        public void Given_Values_When_FindMaxRampWidth_Then_ShouldReturnMaxRampWidth()
        {
            //Given
            var values = new int[] { 6, 0, 8, 2, 1, 5 };
            var problem = new Leetcode_962_MaximumWidthRamp_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.FindMaximumWidhtRamp(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.ArrayProblems.Leetcode_962_MaximumRampWidth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_962_MaximumRampWidth
{
    [TestClass]
    public class Leetcode_962_MaximumWidthRamp_V3Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindMaximumWidthRamp_Then_ShouldReturnMaximumWidthRamp()
        {
            //Given
            var values = new int[] { 9, 8, 1, 0, 1, 9, 4, 0, 4 };
            var problem = new Leetcode_962_MaximumWidthRamp_V3();
            var expectedResult = 6;

            //When
            var actualResult = problem.FindMaximumWidthRamp(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.MatrixProblems.Leetcode_1292_MaximumSideLengthOfSquareWithSumLessThanOrEqualToThreshold;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_1292_MaximumSideLengthOfSquareWithSumLessThanOrEqualToThreshold
{
    [TestClass]
    public class Leetcode_1292_MaximumSideLengthOfSquareWithSumLessThanOrEqualToThreshold_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_CaluclateMaximumSideLength_Then_ShouldReturnMaximumSideLength()
        {
            //Given
            var matrix = new int[3][]
            {
                new int[] { 1, 1,1},
                new int[] { 1, 1, 1},
                new int[] { 1, 1, 1}
            };
            var threshold = 2;
            var problem = new Leetcode_1292_MaximumSideLengthOfSquareWithSumLessThanOrEqualToThreshold_V1();
            var expectedResult = 0;

            //When
            var actualResult = problem.CalculateMaximumSideLength(matrix, 2);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

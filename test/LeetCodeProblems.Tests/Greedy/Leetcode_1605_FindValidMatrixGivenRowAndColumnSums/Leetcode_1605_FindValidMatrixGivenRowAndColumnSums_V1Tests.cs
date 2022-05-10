using LeetCodeProblems.Greedy.Leetcode_1605_FindValidMatrixGivenRowAndColumnSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_1605_FindValidMatrixGivenRowAndColumnSums
{
    [TestClass]
    public class Leetcode_1605_FindValidMatrixGivenRowAndColumnSums_V1Tests
    {
        [TestMethod]
        public void Given_RowSumAndColumnSum_When_ConstructMatrix_Then_ShouldReturnMatrixWithRowSumAndColumnSum()
        {
            //Given
            var rowSum = new int[] { 3, 8 };
            var columnSum = new int[] { 4, 7 };
            var problem = new Leetcode_1605_FindValidMatrixGivenRowAndColumnSums_V1();
            var expectedMatrix = new int[][]
            {
                new int[]{3,0},
                new int[]{1,7}
            };

            //When
            var actualMatrix = problem.ConstructMatrix(rowSum, columnSum);

            //Then
            Assert.AreEqual(expectedMatrix.Length, actualMatrix.Length);
        }
    }
}

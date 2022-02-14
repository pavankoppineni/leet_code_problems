using LeetCodeProblems.ArrayProblems.Leetcode_1572_MatrixDiagonalSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_1572_MatrixDiagonalSum
{
    [TestClass]
    public class Leetcode_1572_MatrixDiagonalSum_V1Tests
    {
        [TestMethod]
        public void Given_2DArray_When_CalculateDiagonalSum_Then_ShouldReturnDiagonalSum()
        {
            //Given
            var matrix = new int[][]
            {
                new int[]{1,2,3 },
                new int[]{4,5,6 },
                new int[]{7,8,9 },
            };
            var problem = new Leetcode_1572_MatrixDiagonalSum_V1();
            var expectedSum = 25;

            //When
            var actualSum = problem.DiagonalSum(matrix);

            //Then
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}

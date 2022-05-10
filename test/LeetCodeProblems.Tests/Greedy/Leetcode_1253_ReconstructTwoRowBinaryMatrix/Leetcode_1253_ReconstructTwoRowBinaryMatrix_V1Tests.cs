using LeetCodeProblems.Greedy.Leetcode_1253_ReconstructTwoRowBinaryMatrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_1253_ReconstructTwoRowBinaryMatrix
{
    [TestClass]
    public class Leetcode_1253_ReconstructTwoRowBinaryMatrix_V1Tests
    {
        [TestMethod]
        public void Given_RowSumAndColumnSum_When_ConstructBinaryMatrix_Then_ShouldReturnBinaryMatrix()
        {
            //Given
            var upperSum = 5;
            var lowerSum = 5;
            var columnSum = new int[] { 2, 1, 2, 0, 1, 0, 1, 2, 0, 1 };
            var problem = new Leetcode_1253_ReconstructTwoRowBinaryMatrix_V1();
            var expectedMatrixLength = 2;

            //When
            var actualMatrix = problem.ConstructBinaryMatrix(upperSum, lowerSum, columnSum);

            //Then
            Assert.AreEqual(expectedMatrixLength, actualMatrix.Count);
        }
    }
}

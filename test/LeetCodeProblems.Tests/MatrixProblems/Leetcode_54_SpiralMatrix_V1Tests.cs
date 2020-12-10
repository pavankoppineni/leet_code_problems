using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_54_SpiralMatrix_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_SpiralOrder_Then_ShouldReturnItemsInMatrixInSpiralOrder()
        {
            //Given
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 6, 7, 8, 9 };
            matrix[2] = new int[] { 11, 12, 13, 14 };
            var problem = new Leetcode_54_SpiralMatrix_V1();
            var expectedOrder = new int[]
            {
                1, 2, 3, 6, 9, 8, 7, 4, 5
            };

            //When
            var actualOrder = problem.SpiralOrder(matrix);

            //Then
            Assert.Fail();
        }
    }
}

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
            var matrix = new int[1][];
            matrix[0] = new int[] { 1, 2, 3 };
            var problem = new Leetcode_54_SpiralMatrix_V1();
            var expectedOrder = new int[]
            {
                1, 2, 3
            };

            //When
            var actualOrder = problem.SpiralOrder(matrix);

            //Then
            Assert.AreEqual(expectedOrder.Length, actualOrder.Count);
            for (var i = 0; i < expectedOrder.Length; i++)
            {
                Assert.AreEqual(expectedOrder[i], actualOrder[i]);
            }
        }
    }
}

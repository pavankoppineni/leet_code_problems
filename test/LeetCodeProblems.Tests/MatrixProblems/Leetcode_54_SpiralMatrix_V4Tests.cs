using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_54_SpiralMatrix_V4Tests
    {
        [TestMethod]
        public void Given_Matrix_When_TraverseSpiral_Then_ShouldReturnItemsInSpiralOrder()
        {
            //Given
            var matrix = new int[3, 4]
            {
                {1, 2, 3, -1 },
                {4, 5, 6, -2 },
                {7, 8, 9, -3 }
            };
            var problem = new Leetcode_54_SpiralMatrix_V4();
            var expectedOrder = new int[] { 1, 2, 3, -1, -2, -3, 9, 8, 7, 4, 5, 6 };

            //When
            var actualOrder = problem.SpiralOrder(matrix);

            //Then
            for (var index = 0; index < expectedOrder.Length; index++)
            {
                Assert.AreEqual(expectedOrder[index], actualOrder[index]);
            }
        }
    }
}

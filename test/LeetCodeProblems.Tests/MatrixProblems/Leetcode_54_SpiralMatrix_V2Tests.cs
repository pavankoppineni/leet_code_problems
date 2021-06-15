using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_54_SpiralMatrix_V2Tests
    {
        [TestMethod]
        public void Given_Matrix_When_SpiralOrder_Then_ShouldReturnItemsInSpiralOrder()
        {
            //Given
            var matrix = new int[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 },
                {10, 11, 12 }
            };
            var problem = new Leetcode_54_SpiralMatrix_V2();

            //When
            var expectedValues = problem.SpiralOrder(matrix);

            //Then
            Assert.Fail();
        }
    }
}

using LeetCodeProblems.MatrixProblems;
using LeetCodeProblems.MatrixProblems.Leetcode_885_SpiralMatrixIII;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_885_SpiralMatrixIII
{
    [TestClass]
    public class Leetcode_885_SpiralMatrixIII_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_SpiralOrderTraversal_Then_SholdReturnOrderInSpiralOrder()
        {
            //Given
            var rows = 3;
            var columns = 3;
            var startRow = 0;
            var startColumn = 1;
            var problem = new Leetcode_885_SpiralMatrixIII_V1();

            //When
            var actualOrder = problem.SpiralOrder(rows, columns, startRow, startColumn);

            //Then
            Assert.Inconclusive();
        }
    }
}

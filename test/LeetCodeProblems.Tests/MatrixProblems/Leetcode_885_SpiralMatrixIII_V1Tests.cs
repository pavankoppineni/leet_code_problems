using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_885_SpiralMatrixIII_V1Tests
    {
        [TestMethod]
        public void Given_NumberOfRowsAndColumnsAndCurrentRowAndCurrentColumn_When_SpiralMatrix_Then_ShouldReutunArrayContainingSpiralItems()
        {
            //Given
            var rows = 2;
            var columns = 5;
            var currentRow = 1;
            var currentColumn = 2;
            var problem = new Leetcode_885_SpiralMatrixIII_V1();

            //When
            var actualResult = problem.SpiralMatrix(rows, columns, currentRow, currentColumn);

            //Then
            Assert.Fail();
        }
    }
}

using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_1277_CountSquareSubmatricesWithAllOnes_V1Tests
    {
        [TestMethod]
        public void Given_BinaryMatrix_When_CalculateMatrices_Then_ShouldReturnCount()
        {
            //Given
            var matrix = new int[][]
            {
                new int[]{ 0, 1, 1, 1, },
                new int[]{ 1, 1, 1, 1  },
                new int[]{ 0, 1, 1, 1, }
            };
            var problem = new Leetcode_1277_CountSquareSubmatricesWithAllOnes_V1();
            var expectedResult = 15;

            //When
            var actualResult = problem.CountSquares(matrix);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

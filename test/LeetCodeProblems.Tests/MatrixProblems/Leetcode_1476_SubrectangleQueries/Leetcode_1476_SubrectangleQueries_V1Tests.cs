using LeetCodeProblems.MatrixProblems.Leetcode_1476_SubrectangleQueries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_1476_SubrectangleQueries
{
    [TestClass]
    public class Leetcode_1476_SubrectangleQueries_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_QueryMatrix_Then_ShouldReturnResultForQuery()
        {
            //Given
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 1, 2, 3 };
            matrix[2] = new int[] { 1, 2, 3 };
            var expectedResult = 5;
            var problem = new Leetcode_1476_SubrectangleQueries_V1(matrix);

            //When
            problem.UpdateSubrectangle(0, 0, 2, 2, 5);
            var actualResult = problem.GetValue(0, 0);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

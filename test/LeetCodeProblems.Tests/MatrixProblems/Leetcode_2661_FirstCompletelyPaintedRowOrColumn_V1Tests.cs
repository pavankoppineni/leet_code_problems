using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_2661_FirstCompletelyPaintedRowOrColumn_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_CalculateSmallestIndex_Then_ShouldReturnSmallestIndex()
        {
            //Given
            var values = new int[] { 2, 8, 7, 4, 1, 3, 5, 6, 9 };
            var matrix = new int[3][] 
            {
                new int[]{3,2,5},
                new int[]{1,4,6},
                new int[]{8,7,9},
            };
            var problem = new Leetcode_2661_FirstCompletelyPaintedRowOrColumn_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateFirstCompleteIndex(values, matrix);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

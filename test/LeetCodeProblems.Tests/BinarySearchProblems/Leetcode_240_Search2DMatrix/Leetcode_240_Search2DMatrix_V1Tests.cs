using LeetCodeProblems.BinarySearchProblems.Leetcode_240_Search2DMatrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_240_Search2DMatrix
{
    [TestClass]
    public class Leetcode_240_Search2DMatrix_V1Tests
    {
        [TestMethod]
        public void Given_2DMatrix_When_FindElement_Then_ShouldReturnTrueIfElementIsFound()
        {
            //Given
            var matrix = new int[5][]
            {
                new int[] { 1, 4, 7, 11, 15 },
                new int[] { 2, 5, 8, 12, 19 },
                new int[] { 3, 6, 9, 16, 22 },
                new int[] { 10, 13, 14, 17, 24 },
                new int[] { 18, 21, 23, 26, 30 },
            };
            var target = 5;
            var expectedResult = true;
            var problem = new Leetcode_240_Search2DMatrix_V1();

            //When
            var actualResult = problem.SearchMatrix(matrix, target);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

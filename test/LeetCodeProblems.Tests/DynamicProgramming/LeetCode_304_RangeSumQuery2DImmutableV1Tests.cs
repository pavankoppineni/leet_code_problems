using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class LeetCode_304_RangeSumQuery2DImmutableV1Tests
    {
        [TestMethod]
        public void Given_MatrixAndListOfQueries_When_FindRangeSum_Then_ReturnsSumOfAllElementsInGivenQuery()
        {
            //Given
            var rowLength = 3;
            var matrix = new int[rowLength][];
            for (var row = 0; row < rowLength; row++)
            {
                matrix[row] = new int[] { 1, 1, 1 };
            }
            var query = (startRow: 1, endRow: 2, startColumn: 1, endColumn: 2);
            var problem = new LeetCode_304_RangeSumQuery2DImmutableV1(matrix);
            var expectedSum = 4;

            //When
            var actualSum = problem.GetRangeSum(query.startRow, query.endRow, query.startColumn, query.endColumn);

            //Then
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}

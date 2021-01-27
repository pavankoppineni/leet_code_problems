using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class LeetCode_42_UniquePaths_V1Tests
    {
        [TestMethod]
        public void Given_NumberOfRowsAndColumns_When_FindUniquePathCounts_Then_ShouldReturnCountOfUniquePaths()
        {
            //Given
            var numberOfRows = 3;
            var numberOfColumns = 3;
            var problem = new LeetCode_42_UniquePaths_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.FindNumberOfUniquePaths(numberOfRows, numberOfColumns);

            //Then
            Assert.Fail();
        }
    }
}

using LeetCodeProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems
{
    [TestClass]
    public class Leetcode_980_UniquePaths_III_V1Tests
    {
        [TestMethod]
        public void Given_Grid_When_CalculateUniquePaths_Then_ShouldReturnNumberOfUniquePaths()
        {
            //Given
            var grid = new int[3][]
            {
                new int[]{1, 0, 0, 0 },
                new int[]{0,0, 0, 0 },
                new int[]{0,0, 2, -1 },
            };
            var problem = new Leetcode_980_UniquePaths_III_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.CalculateUniquePaths(grid);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

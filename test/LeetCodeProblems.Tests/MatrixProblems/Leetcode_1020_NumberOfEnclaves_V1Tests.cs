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
    public class Leetcode_1020_NumberOfEnclaves_V1Tests
    {
        [TestMethod]
        public void Given_BinaryIsland_When_CalculateEnclaves_Then_ShouldReturnNumberOfEnclaves()
        {
            //Given
            var isLand = new int[][]
            {
                new int[]{0,0,0,0},
                new int[]{1,0,1,0},
                new int[]{0,1,1,0},
                new int[]{0,0,0,0},
            };
            var problem = new Leetcode_1020_NumberOfEnclaves_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.CalculateNumberofEnclaves(isLand);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

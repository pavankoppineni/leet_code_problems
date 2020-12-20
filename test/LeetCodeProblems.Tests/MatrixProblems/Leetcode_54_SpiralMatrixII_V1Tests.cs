using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_54_SpiralMatrixII_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_GenerateSpiralMatrix_Then_ShouldReturnSpiralMatrix()
        {
            //Given
            var number = 2;
            var problem = new Leetcode_54_SpiralMatrixII_V1();
            var expectedSpiralItems = new int[2][];
            expectedSpiralItems[0] = new int[] { 1, 2 };
            expectedSpiralItems[1] = new int[] { 4, 3 };

            //When
            var actualSpiralItems = problem.GenerateMatrix(number);

            //Then
            Assert.AreEqual(expectedSpiralItems.Length, actualSpiralItems.Length);
            for (var row = 0; row < expectedSpiralItems.Length; row++)
            {
                Assert.AreEqual(expectedSpiralItems[row].Length, actualSpiralItems[row].Length);
                for (var index = 0; index < expectedSpiralItems[row].Length; index++)
                {
                    Assert.AreEqual(expectedSpiralItems[row][index], actualSpiralItems[row][index]);
                }
            }
        }
    }
}

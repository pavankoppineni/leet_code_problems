using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCodeProblems.GraphProblems;

namespace LeetCodeProblems.Tests.Graph_Problems
{
    [TestClass]
    public class Leetcode_733_FloodFill_V1Tests
    {
        [TestMethod]
        public void Given_IntegerMatrix_When_CalculateFloodFill_Then_ShouldReturnModifiedFloodFill()
        {
            //Given
            var image = new int[3][]
            {
                new int[]{ 1, 1, 1 },
                new int[]{ 1, 1, 0},
                new int[]{ 1, 0, 1}
            };
            var problem = new Leetcode_733_FloodFill_V1();
            var expectedImage = new int[3][]
            {
                new int[]{2,2,2},
                new int[]{2,2,0},
                new int[]{2,0, 1}
            };
            var row = 1;
            var column = 1;
            var newColor = 2;

            //When
            var actualImage = problem.FloodFill(image, row, column, newColor);

            //Then
            for (var rowItem = 0; row < image.Length; row++)
            {
                for (var columnItem = 0; column < image[0].Length; column++)
                {
                    Assert.AreEqual(expectedImage[rowItem][columnItem], actualImage[rowItem][columnItem]);
                }
            }
        }
    }
}

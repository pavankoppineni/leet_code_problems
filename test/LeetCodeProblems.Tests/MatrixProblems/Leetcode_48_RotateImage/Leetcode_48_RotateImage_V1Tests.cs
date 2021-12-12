using LeetCodeProblems.MatrixProblems.Leetcode_48_RotateImage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_48_RotateImage
{
    [TestClass]
    public class Leetcode_48_RotateImage_V1Tests
    {
        [TestMethod]
        public void Given_Matrix_When_RotateBy90_Then_ShouldRotateMatrixIn90Degree()
        {
            //Given
            var image = new int[][]
            {
                new int[]{1, 2, 3 },
                new int[]{4, 5, 6 },
                new int[]{7, 8, 9 },
            };
            var problem = new Leetcode_48_RotateImage_V1();
            var expectedImage = new int[][]
            {
                new int[]{7, 4, 1 },
                new int[]{8, 5, 2 },
                new int[]{9, 6, 3 },
            };

            //When
            var actualImage = problem.RotateImage(image);

            //Then
            for (var row = 0; row < image.Length; row++)
            {
                for (var col = 0; col < image[row].Length; col++)
                {
                    Assert.AreEqual(expectedImage[row][col], actualImage[row][col]);
                }
            }
        }
    }
}

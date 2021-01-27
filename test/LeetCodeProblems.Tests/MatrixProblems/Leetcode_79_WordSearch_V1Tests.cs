using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_79_WordSearch_V1Tests
    {
        [TestMethod]
        public void Given_MatrixAndWord_When_SearchForWordInMatrix_Then_ShouldReturnTrueWhenWordExistsInMatrix()
        {
            //Given
            var matrix = new char[,]
            {
                {'A','B','C','E' },
                {'S','F','C','S' },
                {'A','D','E','E' }
            };
            var problem = new Leetcode_79_WordSearch_V1();
            var word = "FS";

            //When
            var actualResult = problem.DoesWordExists(matrix, word);

            //Then
            Assert.Fail();
        }
    }
}

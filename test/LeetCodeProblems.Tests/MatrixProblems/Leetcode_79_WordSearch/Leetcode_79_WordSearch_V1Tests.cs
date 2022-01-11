using LeetCodeProblems.MatrixProblems;
using LeetCodeProblems.MatrixProblems.Leetcode_79_WordSearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems.Leetcode_79_WordSearch
{
    [TestClass]
    public class Leetcode_79_WordSearch_V1Tests
    {
        [TestMethod]
        public void Given_MatrixAndWord_When_WordExists_Then_ShouldReturnTrueIfWordExists()
        {
            //Given
            var matrix = new char[3][]
            {
                new char[] { 'A','B','C','E' },
                new char[] { 'S','F','C','S' },
                new char[] { 'A','D','E','E' },
            };
            var problem = new Leetcode_79_WordSearch_V1();
            var expectedResult = true;
            var word = "ABCCED";

            //When
            var actualResult = problem.WordExists(matrix, word);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

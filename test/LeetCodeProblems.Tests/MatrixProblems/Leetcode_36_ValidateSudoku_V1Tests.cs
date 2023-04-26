using LeetCodeProblems.MatrixProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.MatrixProblems
{
    [TestClass]
    public class Leetcode_36_ValidateSudoku_V1Tests
    {
        [TestMethod]
        public void Given_SudokuBoard_When_Validate_Then_ShouldReturnTrueOrFalse()
        {
            //Given
            var values = new char[9][]
            {
                new char[] { '5', '3', '.', '.', '7', '.','.','.','.' },
                new char[] { '6', '.', '.', '1', '9', '5','.','.','.' },
                new char[] { '.', '9', '8', '.', '.', '.','.','6','.' },
                new char[] { '8', '.', '.', '.', '6', '.','.','.','3' },
                new char[] { '4', '.', '.', '8', '.', '3','.','.','1' },
                new char[] { '7', '.', '.', '.', '2', '.','.','.','6' },
                new char[] { '.', '6', '.', '.', '.', '.','2','8','.' },
                new char[] { '.', '.', '.', '4', '1', '9','.','.','5' },
                new char[] { '.', '.', '.', '.', '8', '.','.','7','9' }
            };
            var problem = new Leetcode_36_ValidateSudoku_V1();
            var expectedResult = false;
            
            //When
            var actualResult = problem.Validate(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

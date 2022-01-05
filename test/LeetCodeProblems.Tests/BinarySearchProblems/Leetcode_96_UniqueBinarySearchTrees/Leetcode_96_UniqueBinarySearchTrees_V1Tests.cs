using LeetCodeProblems.BinarySearchProblems.Leetcode_96_UniqueBinarySearchTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_96_UniqueBinarySearchTrees
{
    [TestClass]
    public class Leetcode_96_UniqueBinarySearchTrees_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_CountUniqueBinaryTrees_Then_ShouldReturnCount()
        {
            //Given
            var number = 18;
            var problem = new Leetcode_96_UniqueBinarySearchTrees_V1();
            var expectedResult = 477638700;

            //When
            var actualResult = problem.CreateUniqueBinarySearchTrees(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

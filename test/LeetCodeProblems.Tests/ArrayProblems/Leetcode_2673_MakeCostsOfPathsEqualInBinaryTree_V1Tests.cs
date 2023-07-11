using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2673_MakeCostsOfPathsEqualInBinaryTree_V1Tests
    {
        [TestMethod]
        public void Given_CostsAndBinaryTree_When_CalculateMinimumIncrement_Then_ShouldReturnMinimumIncrement()
        {
            //Given
            var costs = new int[] { 1, 5, 2, 2, 3, 3, 1, 1, 2, 3, 4, 5, 6, 7, 8 };
            var length = 15;
            var problem = new Leetcode_2673_MakeCostsOfPathsEqualInBinaryTree_V1();
            var expectedResult = 8;

            //When
            var actualResult = problem.CalculateMinimumIncrements(length, costs);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

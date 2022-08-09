using LeetCodeProblems.TreeProblems.Leetcode_823_BinaryTreesWithFactors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_823_BinaryTreesWithFactors
{
    [TestClass]
    public class Leetcode_823_BinaryTreesWithFactors_V1Tests
    {
        [DataRow(new int[] { 2, 4, 5, 10 }, 7)]
        [DataRow(new int[] { 2, 4 }, 3)]
        [DataRow(new int[] { 2, 4, 8 }, 8)]
        [DataTestMethod]
        public void Given_Values_When_ConstructTreesWithFactors_Then_ShouldReturnCountOfTreeWithFactors(int[] values, int expectedResult)
        {
            //Given
            var problem = new Leetcode_823_BinaryTreesWithFactors_V1();

            //When
            var actualCount = problem.CalculateBinaryTrees(values);

            //Then
            Assert.AreEqual(expectedResult, actualCount);
        }
    }
}

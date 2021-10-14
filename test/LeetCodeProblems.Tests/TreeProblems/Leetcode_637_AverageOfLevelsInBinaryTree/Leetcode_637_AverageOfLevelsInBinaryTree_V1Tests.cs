using LeetCodeProblems.TreeProblems.Leetcode_637_AverageOfLevelsInBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_637_AverageOfLevelsInBinaryTree
{
    [TestClass]
    public class Leetcode_637_AverageOfLevelsInBinaryTree_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_CalculateAverageLevels_Then_ShouldReturnAverageOfAllLevels()
        {
            //Given
            var root = new Node637V1 { Value = 1 };
            var left = new Node637V1 { Value = 2 };
            var right = new Node637V1 { Value = 3 };
            root.Left = left;
            root.Right = right;
            var problem = new Leetcode_637_AverageOfLevelsInBinaryTree_V1();
            var expectedResult = new double[] { 1, 2.5 };

            //When
            var actualResult = problem.AverageOfLevels(root);

            //Then
            for (var index = 0; index < actualResult.Count; index++)
            {
                Assert.AreEqual(expectedResult[index], actualResult[index]);
            }
        }
    }
}

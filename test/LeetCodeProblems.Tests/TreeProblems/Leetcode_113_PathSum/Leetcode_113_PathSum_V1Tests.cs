using LeetCodeProblems.TreeProblems.Leetcode_113_PathSum;
using LeetCodeProblems.TreeProblems.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_113_PathSum
{
    [TestClass]
    public class Leetcode_113_PathSum_V1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_When_FindPathSums_Then_ShouldReturnListOfPathSums()
        {
            //Given
            var root = new TreeNode(1);
            var left = new TreeNode(2);
            var right = new TreeNode(2);
            root.Left = left;
            root.Right = right;
            var problem = new Leetcode_113_PathSum_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.PathSum(root, 3);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}

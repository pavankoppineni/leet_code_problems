using LeetCodeProblems.TreeProblems.Leetcode_437_PathSumIII;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_437_PathSumIII
{
    [TestClass]
    public class Leetcode_437_PathSumIII_V1Tests
    {
        [TestMethod]
        public void Given_TreeAndPathSum_When_FindCount_Then_ShouldReturnCountOfPathsWithGivenSum()
        {
            //Given
            var problem = new Leetcode_437_PathSumIII_V1();
            var node21 = new TreeNode(1);
            var node22 = new TreeNode(1);
            var root = new TreeNode(0);
            root.left = node21;
            root.right = node22;
            var pathSum = 1;
            var expectedCount = 4;

            //When
            var actualCount = problem.PathSum(root, pathSum);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

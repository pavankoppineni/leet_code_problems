using LeetCodeProblems.TreeProblems;
using LeetCodeProblems.TreeProblems.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_102_BinaryTreeLevelOrderTraversal_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_LevelOrderTraversal_Then_ShouldReturnItemsInLevelOrder()
        {
            //Given
            var tree = new TreeNode(1);

            var node11 = new TreeNode(2);
            var node12 = new TreeNode(3);
            tree.Left = node11;
            tree.Right = node12;

            var node21 = new TreeNode(4);
            var node22 = new TreeNode(5);
            node11.Left = node21;
            node11.Right = node22;

            var node23 = new TreeNode(6);
            var node24 = new TreeNode(7);
            node12.Left = node23;
            node12.Right = node24;

            var problem = new Leetcode_102_BinaryTreeLevelOrderTraversal_V1();
            var expectedResult = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 2, 3 },
                new List<int> { 4, 5, 6, 7 }
            };

            //When
            var actualResult = problem.LevelOrderTraversal(tree);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
            for (var index = 0; index < expectedResult.Count; index++)
            {
                Assert.AreEqual(expectedResult[index].Count, actualResult[index].Count);
                var expectedLevelItems = expectedResult[index];
                var actualLevelItems = actualResult[index];
                for (var innerIndex = 0; innerIndex < expectedResult[index].Count; innerIndex++)
                {
                    Assert.AreEqual(expectedLevelItems[innerIndex], actualLevelItems[innerIndex]);
                }
            }
        }
    }
}

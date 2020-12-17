using LeetCodeProblems.TreeProblems;
using LeetCodeProblems.TreeProblems.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_103_BinaryTreeZigzagLevelOrderTraversal_V1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_When_ZigZagLevelOrderTraversal_Then_ShouldReturnZigZagOrder()
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

            var expectedResult = new List<List<int>>
            {
                new List<int>{ 1},
                new List<int>{3, 2},
                new List<int>{4, 5, 6, 7}
            };
            

            var problem = new Leetcode_103_BinaryTreeZigzagLevelOrderTraversal_V1();

            //When
            var actualResult = problem.ZigzagLevelOrder(tree);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
            for (var index = 0; index < expectedResult.Count; index++)
            {
                var expected = expectedResult[index];
                var actual = actualResult[index];
                Assert.AreEqual(expected.Count, actual.Count);
                for (var i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(expected[i], actual[i]);
                }
            }
        }
    }
}

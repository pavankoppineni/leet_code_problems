using LeetCodeProblems.TreeProblems;
using LeetCodeProblems.TreeProblems.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_226_InvertBinaryTree_V1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_when_InvertBinaryTree_Then_ShouldInvertBinaryTree()
        {
            //Given
            var tree = new TreeNode(1);

            var node11 = new TreeNode(2);
            var node12 = new TreeNode(3);
            tree.Left = node11;
            tree.Right = node12;

            var expectedTree = new TreeNode(1);

            var expectedTreeNode11 = new TreeNode(2);
            var expectedTreeNode12 = new TreeNode(3);
            expectedTree.Left = node11;
            expectedTree.Right = node12;

            var problem = new Leetcode_226_InvertBinaryTree_V1();

            //When
            var actualTree = problem.InvertBinaryTree(tree);

            //Then
            Assert.AreEqual(expectedTree.Value, tree.Value);
            Assert.AreEqual(expectedTree.Left.Value, tree.Right.Value);
            Assert.AreEqual(expectedTree.Right.Value, tree.Left.Value);
        }
    }
}

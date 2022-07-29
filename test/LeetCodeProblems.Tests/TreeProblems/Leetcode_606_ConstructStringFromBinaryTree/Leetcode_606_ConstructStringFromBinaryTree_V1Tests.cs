using LeetCodeProblems.TreeProblems.Leetcode_606_ConstructStringFromBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_606_ConstructStringFromBinaryTree
{
    [TestClass]
    public class Leetcode_606_ConstructStringFromBinaryTree_V1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_When_ConstructString_Then_ShouldReturnString()
        {
            //Given
            var leaf = new TreeNode();
            leaf.val = 4;
            var left = new TreeNode();
            left.val = 2;
            left.left = leaf;
            var right = new TreeNode(); 
            right.val = 3;
            var root = new TreeNode();
            root.val = 1;
            root.left = left;
            root.right = right;
            var actualValue = "1(2(4))(3)";
            var problem = new Leetcode_606_ConstructStringFromBinaryTree_V1();

            //When
            var expectedValue = problem.ConstructString(root);

            //Then
            Assert.AreEqual(expectedValue, actualValue);    
        }
    }
}

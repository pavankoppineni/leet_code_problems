using LeetCodeProblems.TreeProblems.Leetcode_106_ConstructBinaryTreeFromPostorderAndInorderTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_106_ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    [TestClass]
    public class Leetcode_106_ConstructBinaryTreeFromPostorderAndInorderTraversal_V1Tests
    {
        [TestMethod]
        public void Given_PreorderAndInorder_When_BuildBinaryTree_Then_ShouldReturnBinaryTreee()
        {
            //Given
            var preorder = new int[] { 1,2,3,4,5,6,7};
            var inorder = new int[] { 3,2,4,1,6,5,7 };
            var problem = new Leetcode_106_ConstructBinaryTreeFromPostorderAndInorderTraversal_V1();

            //When
            var tree = problem.BuildTree(preorder, inorder);

            //Then
            Assert.Inconclusive();
        }
    }
}

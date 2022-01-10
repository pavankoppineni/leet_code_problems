using LeetCodeProblems.LinkedListProblems.Leetcode_114_FlattenBinaryTreeToLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.LinkedListProblems.Leetcode_114_FlattenBinaryTreeToLinkedList
{
    [TestClass]
    public class Leetcode_114_FlattenBinaryTreeToLinkedList_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_Flatten_Then_ShouldReturnLinkedList()
        {
            //Given
            var treeNode = new TreeNode { val = 1 };
            var left = new TreeNode { val = 2 };
            var right = new TreeNode { val = 3};
            treeNode.left = left;
            treeNode.right = right;
            var problem = new Leetcode_114_FlattenBinaryTreeToLinkedList_V1();
            var expectedResult = new TreeNode { val = 1 };

            //When
            var actualResult = problem.Flatten(treeNode);

            //Then
            Assert.Inconclusive();
        }
    }
}

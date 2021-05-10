using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_108_ConvertSortedArrayToBinarySearchTree_V1Tests
    {
        [TestMethod]
        public void Given_SortedArray_When_ConvertToBinarySearchTree_Then_ShouldReturnBinarySearchTree()
        {
            //Given
            var sortedArray = new int[] { 2, 5, 7 };
            var problem = new Leetcode_108_ConvertSortedArrayToBinarySearchTree_V1();
            var expectedTree = new Node108 { Value = 5 };
            expectedTree.Left = new Node108 { Value = 2 };
            expectedTree.Right = new Node108 { Value = 7 };
            //When
            var node = problem.Convert(sortedArray);

            //Then
            Assert.AreEqual(expectedTree.Value, node.Value);
            Assert.AreEqual(expectedTree.Left.Value, node.Left.Value);
            Assert.AreEqual(expectedTree.Right.Value, node.Right.Value);
        }
    }
}

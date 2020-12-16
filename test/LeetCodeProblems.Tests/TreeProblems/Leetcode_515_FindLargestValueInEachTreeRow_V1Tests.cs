using LeetCodeProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static LeetCodeProblems.TreeProblems.Leetcode_515_FindLargestValueInEachTreeRow_V1;

namespace LeetCodeProblems.Tests.TreeProblems
{
    [TestClass]
    public class Leetcode_515_FindLargestValueInEachTreeRow_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_FindLargestValues_Then_ShouldReturnLargestValues()
        {
            //Given
            var problem = new Leetcode_515_FindLargestValueInEachTreeRow_V1();
            var expectedResult = new int[] { 1, 3, 7 };
            var tree = new TreeNode515(1);

            var node11 = new TreeNode515(2);
            var node12 = new TreeNode515(3);
            tree.Left = node11;
            tree.Right = node12;

            var node21 = new TreeNode515(4);
            var node22 = new TreeNode515(5);
            node11.Left = node21;
            node11.Right = node22;

            var node23 = new TreeNode515(6);
            var node24 = new TreeNode515(7);
            node12.Left = node23;
            node12.Right = node24;

            //When
            var actualResult = problem.FindLargestValues(tree);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Count);
            for (var i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}

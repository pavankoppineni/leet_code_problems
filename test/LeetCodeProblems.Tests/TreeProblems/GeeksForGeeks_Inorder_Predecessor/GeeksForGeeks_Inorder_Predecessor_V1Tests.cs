using LeetCodeProblems.TreeProblems.GeeksForGeeks_Inorder_Predecessor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.GeeksForGeeks_Inorder_Predecessor
{
    [TestClass]
    public class GeeksForGeeks_Inorder_Predecessor_V1Tests
    {
        [TestMethod]
        public void Given_Tree_When_InorderPredecessor_Then_ShouldReturnInorderPredecessor()
        {
            //Given
            var node4 = new GeeksForGeeksNode { Value = 4 };
            var node1 = new GeeksForGeeksNode { Value = 1 };
            var node2 = new GeeksForGeeksNode { Value = 2 };
            var node3 = new GeeksForGeeksNode { Value = 3 };
            var node5 = new GeeksForGeeksNode { Value = 5 };

            node4.Right = node5;
            node4.Left = node2;
            node2.Left = node1;
            node2.Right = node3;

            var problem = new GeeksForGeeks_Inorder_Predecessor_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.FindPredecessor(node4);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

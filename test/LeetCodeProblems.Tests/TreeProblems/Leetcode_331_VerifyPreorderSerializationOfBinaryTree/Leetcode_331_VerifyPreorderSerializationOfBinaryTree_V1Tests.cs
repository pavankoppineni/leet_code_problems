using LeetCodeProblems.TreeProblems.Leetcode_331_VerifyPreorderSerializationOfBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_331_VerifyPreorderSerializationOfBinaryTree
{
    [TestClass]
    public class Leetcode_331_VerifyPreorderSerializationOfBinaryTree_V1Tests
    {
        [TestMethod]
        public void Given_PreorderSerialization_Then_ValidatePreorder_Then_ShouldReturnStatus()
        {
            //Given
            var preorder = "9,#,#,1";
            var problem = new Leetcode_331_VerifyPreorderSerializationOfBinaryTree_V1();
            var expectedResult = false;

            //When
            var actualResult = problem.ValidateSerialization(preorder);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

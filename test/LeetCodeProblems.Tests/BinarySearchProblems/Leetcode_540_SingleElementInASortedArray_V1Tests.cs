using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class Leetcode_540_SingleElementInASortedArray_V1Tests
    {
        [TestMethod]
        public void Given_SortedArray_When_FindSingleElement_Then_ShouldReturnSingleElement()
        {
            //Given
            var values = new int[] { 3, 3, 7, 7, 10, 11, 11 };
            var problem = new Leetcode_540_SingleElementInASortedArray_V1();
            var expectedResult = 10;

            //When
            var actualResult = problem.FindSingleElement(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

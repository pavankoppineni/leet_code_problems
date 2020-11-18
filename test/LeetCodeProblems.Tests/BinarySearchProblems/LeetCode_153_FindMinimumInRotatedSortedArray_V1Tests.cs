using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class LeetCode_153_FindMinimumInRotatedSortedArray_V1Tests
    {
        [TestMethod]
        public void Given_RotatedSortedArray_When_FindMinimum_Then_ShouldReturnMinimumElementFromSortedArray()
        {
            //Given
            var values = new int[] { 3, 4, 5, 1, 2 };
            var problem = new LeetCode_153_FindMinimumInRotatedSortedArray_V1();
            var expectedResult = 1;

            //When
            var actualResult = problem.FindMin(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class Leetcode_81_SearchInRotatedSortedArrayII_V1Tests
    {
        [TestMethod]
        public void Given_RotatedSortedArrayAndTarget_When_SearchForTarget_Then_ShouldReturnTrueWhenTargetExists()
        {
            //Given
            var rotatedSortedArray = new int[] { 2, 5, 6, 0, 0, 1, 2 };
            var target = 0;
            var expectedResult = true;
            var problem = new Leetcode_81_SearchInRotatedSortedArrayII_V1();

            //When
            var actualResult = problem.Search(rotatedSortedArray, target);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

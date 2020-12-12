using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_496_NextGreaterElementI_V1Tests
    {
        [TestMethod]
        public void Given_TwoIntegerArrays_When_NextGreaterElement_Then_ShouldRetrunArrayContainingNextGreaterElements()
        {
            //Given
            var nums1 = new int[] { 4, 1, 2 };
            var nums2 = new int[] { 1, 3, 4, 2};
            var problem = new Leetcode_496_NextGreaterElementI_V1();
            var expectedResult = new int[] { -1, 3, -1 };

            //When
            var actualResult = problem.NextGreaterElement(nums1, nums2);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            for(var i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}

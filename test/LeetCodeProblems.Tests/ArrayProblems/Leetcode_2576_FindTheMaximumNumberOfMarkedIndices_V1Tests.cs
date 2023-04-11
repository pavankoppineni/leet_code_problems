using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2576_FindTheMaximumNumberOfMarkedIndices_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateMarkedIndices_Then_ShouldReturnNumberOfMarkedIndices()
        {
            //Given
            var nums = new int[] { 1, 100, 200, 600};
            var expectedResult = 2;
            var problem = new Leetcode_2576_FindTheMaximumNumberOfMarkedIndices_V1();

            //When
            var actualResult = problem.CalculateMarkedIndices(nums);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

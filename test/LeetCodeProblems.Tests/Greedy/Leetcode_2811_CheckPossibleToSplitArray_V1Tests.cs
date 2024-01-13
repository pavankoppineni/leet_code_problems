using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_2811_CheckPossibleToSplitArray_V1Tests
    {
        [TestMethod]
        public void Given_Array_When_CheckPossibleToSplit_Then_ShouldReturn()
        {
            //Given
            var values = new int[] { 2, 3, 3, 2, 3 };
            var m = 6;
            var problem = new Leetcode_2811_CheckPossibleToSplitArray_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.CanSplitArray(values, m);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

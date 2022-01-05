using LeetCodeProblems.GFG_Problems.CountOfSubsetsWithSumEqualToX;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.GFG_Problems.CountOfSubsetsWithSumEqualToX
{
    [TestClass]
    public class CountOfSubsetsWithSumEqualToX_Recursion_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CountOfSubsetsWithSumEqualToX_Then_ShouldReturnCount()
        {
            //Given
            var arr = new int[] { 1, 2, 3, 3 };
            var problem = new CountOfSubsetsWithSumEqualToX_Recursion_V1();
            var expectedCount = 3;
            var sum = 6;

            //When
            var actualCount = problem.CountOfSubsetsWithSumEqualToX(arr, 6);

            //Then
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

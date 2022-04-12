using LeetCodeProblems.ArrayProblems.Leetcode_2012_SumOfBeautyInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2012_SumOfBeautyInArray
{
    [TestClass]
    public class Leetcode_2012_SumOfBeautyInArrayTests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateSumOfBeauty_Then_ShouldReturnSum()
        {
            //Given
            var nums = new int[] { 9, 9, 3, 8, 7, 9, 6, 10 };
            var problem = new Leetcode_2012_SumOfBeautyInArray_V1();
            var expectedResult = 4;

            //When
            var actualResult = problem.CalculateSumOfBeauties(nums);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

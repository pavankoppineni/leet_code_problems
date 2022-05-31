using LeetCodeProblems.Greedy.Leetcode_1296_DivideArrayInSetsOfKConsecutiveNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_1296_DivideArrayInSetsOfKConsecutiveNumbers
{
    [TestClass]
    public class Leetcode_1296_DivideArrayInSetsOfKConsecutiveNumbers_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_DivideArray_Then_ShouldReturnTrueIfArrayCanBeDivided()
        {
            //Given
            var values = new int[] { 3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11 };
            var problem = new Leetcode_1296_DivideArrayInSetsOfKConsecutiveNumbers_V1();
            var expectedResult = true;
            var subArraySize = 3;

            //When
            var actualResult = problem.IsPossibleDivide(values, subArraySize);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

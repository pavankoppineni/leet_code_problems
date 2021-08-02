using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_287_FindTheDuplicateNumber_V3Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_FindDuplicateNumber_Then_ShoulReturnDuplicateNumber()
        {
            //Given
            var values = new int[] { 3, 1, 3, 4, 2 };
            var problem = new Leetcode_287_FindTheDuplicateNumber_V3();
            var expectedResult = 3;

            //When
            var actualResult = problem.FindDuplicateNumber(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_848_ShiftingLetters_V1Tests
    {
        [TestMethod]
        public void Given_StringAndShiftArray_When_ShiftString_Then_ShouldReturnNewStringAfterShiftOperation()
        {
            //Given
            var problem = new Leetcode_848_ShiftingLetters_V1();
            var str = "abc";
            var shiftArray = new int[] { 5, 6, 7 };
            var expectedResult = "abc";

            //When
            var actualResult = problem.ShiftLetters(str, shiftArray);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            for (var i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}

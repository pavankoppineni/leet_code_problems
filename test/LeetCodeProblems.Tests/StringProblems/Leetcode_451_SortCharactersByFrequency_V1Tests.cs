using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_451_SortCharactersByFrequency_V1Tests
    {
        [TestMethod]
        public void Given_String_When_FrequencySort_Then_ShouldReturnStringSortedByFrequency()
        {
            //Given
            var problem = new Leetcode_451_SortCharactersByFrequency_V1();
            var str = "ppaavan";
            var expectedResult = "aaappnv";

            //When
            var actualResult = problem.FrequencySort(str);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

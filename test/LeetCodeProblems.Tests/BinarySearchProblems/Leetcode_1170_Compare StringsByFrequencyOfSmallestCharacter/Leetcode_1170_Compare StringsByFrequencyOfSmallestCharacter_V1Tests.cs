using LeetCodeProblems.BinarySearchProblems.Leetcode_1170_Compare_StringsByFrequencyOfSmallestCharacter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_1170_Compare_StringsByFrequencyOfSmallestCharacter
{
    [TestClass]
    public class Leetcode_1170_Compare_StringsByFrequencyOfSmallestCharacter_V1Tests
    {
        [TestMethod]
        public void Given_QueriesAndWords_When_CalculateFrequency_Then_ShouldReturnQueryFrequency()
        {
            //Given
            var queries = new string[] { "cbd" };
            var words = new string[] { "a", "ab", "abc" };
            var problem = new Leetcode_1170_Compare_StringsByFrequencyOfSmallestCharacter_V1();
            var expectedResult = new int[] { 0 };

            //When
            var actualResult = problem.CalculateFrequency(queries, words);

            //Then
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }
    }
}

using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_387_FirstUniqueCharacterInString_V1Tests
    {
        private static IEnumerable<object[]> GetTestData()
        {
            var testData = new List<object[]>
            {
                new object[]{ "leetcode", 0}
            };
            return testData;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Given_String_When_FindUniqueCharacter_Then_ShouldReturnIndexOfFirstUniqueCharacter(string text, int expectedResult)
        {
            //Given
            var problem = new Leetcode_387_FirstUniqueCharacterInString_V1();

            //When
            var actualResult = problem.FirstUniqChar(text);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

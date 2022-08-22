using LeetCodeProblems.BacktrackingProblems.Leetcode_2375_ConstructSmallestNumberFromDIString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems.Leetcode_2375_ConstructSmallestNumberFromDIString
{
    [TestClass]
    public class Leetcode_2375_ConstructSmallestNumberFromDIString_V1Tests
    {
        [TestMethod]
        public void Given_String_When_ConstructSmallestNumber_Then_ShouldReturnSmallestNumber()
        {
            //Given
            var pattern = "DD";
            var problem = new Leetcode_2375_ConstructSmallestNumberFromDIString_V1();
            var expectedResult = "123549876";

            //When
            var actualResult = problem.SmallestNumber(pattern);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

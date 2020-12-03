using LeetCodeProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.StringProblems
{
    [TestClass]
    public class Leetcode_76_MinimumWindowSubstring_V1Tests
    {
        [TestMethod]
        public void Given_TextAndPattern_When_FindMinimumString_Then_ShouldReturnMinimumSubStringFromText()
        {
            //Given
            var text = "abdefghbac";
            var pattern = "abc";
            var problem = new Leetcode_76_MinimumWindowSubstring_V1();

            //When
            var actualResult = problem.FindMinimumWindow(text, pattern);

            //Then
            Assert.Fail();
        }
    }
}

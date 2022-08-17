using LeetCodeProblems.BacktrackingProblems.Leetcode_942_DIStringMatch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BacktrackingProblems.Leetcode_942_DIStringMatch
{
    [TestClass]
    public class Leetcode_942_DIStringMatch_V1Tests
    {
        [TestMethod]
        public void Given_String_When_CalculateDIString_Then_ShouldReturnDIString()
        {
            //Given
            var str = "IDID";
            var problem = new Leetcode_942_DIStringMatch_V1();

            //When
            var actualResult = problem.FindStringMatch(str);

            //Then
            Assert.Inconclusive();
        }
    }
}

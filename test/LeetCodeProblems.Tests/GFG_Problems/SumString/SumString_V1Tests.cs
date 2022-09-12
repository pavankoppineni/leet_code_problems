using LeetCodeProblems.GFG_Problems.SumString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.GFG_Problems.SumString
{
    [TestClass]
    public class SumString_V1Tests
    {
        [TestMethod]
        public void Given_SumString_When_CheckForSumString_Then_ShouldReturnTrue()
        {
            //Given
            var str = "122436";
            var problem = new SumString_V1();
            var expectedResult = true;

            //When
            var actualResult = problem.IsSumString(str);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

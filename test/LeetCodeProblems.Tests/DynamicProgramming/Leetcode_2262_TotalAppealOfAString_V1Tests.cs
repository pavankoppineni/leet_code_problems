using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2262_TotalAppealOfAString_V1Tests
    {
        [TestMethod]
        public void Given_String_When_CalculateAppealSum_Then_ShouldReturnAppealSum()
        {
            //Given
            var problem = new Leetcode_2262_TotalAppealOfAString_V1();
            var inputStr = "abcb";
            var expectedResult = 18;

            //When
            var actualResult = problem.CalculateAppealSum(inputStr);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_667_BeautifulArrangementII_V1Tests
    {
        [TestMethod]
        public void Given_NumberAndDifference_When_GetArrangement_Then_ShouldReturnArrangement()
        {
            //Given
            var number = 3;
            var problem = new Leetcode_667_BeautifulArrangementII_V1();
            var count = 2;

            //When
            var expectedValues = problem.ConstructArray(number, 1);

            //Then
            Assert.Fail();
        }
    }
}

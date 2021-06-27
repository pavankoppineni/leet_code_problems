using LeetCodeProblems.HiringChallenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.HiringChallenges
{
    [TestClass]
    public class ChocolateProblem_V1Tests
    {
        [TestMethod]
        public void Given_Number_When_ConstructArray_Then_ShouldConstructArrayWithMaxDifference()
        {
            //Given
            var number = 4;
            var problem = new ChocolateProblem_V1();
            var expectedValue = 7;

            //When
            var actualValue = problem.ConstructArray(number);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

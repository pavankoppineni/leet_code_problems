using LeetCodeProblems.ArrayProblems.Leetcode_2358_MaximumNumberOfGroupsEnteringCompetition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems.Leetcode_2358_MaximumNumberOfGroupsEnteringCompetition
{
    [TestClass]
    public class Leetcode_2358_MaximumNumberOfGroupsEnteringCompetition_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_CalculateNumberOfGroups_Then_ShouldReturnMaximumNumberOfGroups()
        {
            //Given
            var values = new int[] { 10, 6, 12, 7, 3, 5, 100 };
            var problem = new Leetcode_2358_MaximumNumberOfGroupsEnteringCompetition_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.MaxGroups(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_1282_GroupPeopleGivenTheGroupSizeTheyBelongTo_V1Tests
    {
        [TestMethod]
        public void Given_GroupSizes_When_GenerateGroups_Then_ShouldReturnGroups()
        {
            //Given
            var groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };
            var problem = new Leetcode_1282_GroupPeopleGivenTheGroupSizeTheyBelongTo_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.GeneratePeopleGroups(groupSizes);

            //Then
            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}

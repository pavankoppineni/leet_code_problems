using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_2491_DividePlayersIntoTeamsOfEqualSkill_V1Tests
    {
        [TestMethod]
        public void Given_PlayersWithSkill_When_CalculateChemistry_Then_ShouldReturnChemistry()
        {
            //Given
            var players = new int[] { 3, 2, 5, 1, 3, 4 };
            var problem = new Leetcode_2491_DividePlayersIntoTeamsOfEqualSkill_V1();
            var expectedResult = 22;

            //When
            var actualResult = problem.CalculateChemistryOfTeams(players);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using LeetCodeProblems.Greedy.Leetcode_881_BoatsToSavePeople;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_881_BoatsToSavePeople
{
    [TestClass]
    public class Leetcode_881_BoatsToSavePeople_V1Tests
    {
        [TestMethod]
        public void Given_PeopleWithHeightsAndBoatLimit_When_FindMinimumNumberOfBoats_Then_ShouldReturnMinimumNumberOfBoats()
        {
            //Given
            var people = new int[] { 3, 2, 2, 1 };
            var limit = 3;
            var expectedResult = 3;
            var problem = new Leetcode_881_BoatsToSavePeople_V1();

            //When
            var actualResult = problem.NumRescueBoats(people, limit);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

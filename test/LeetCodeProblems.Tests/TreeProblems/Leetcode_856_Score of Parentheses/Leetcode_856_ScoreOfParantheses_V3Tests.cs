using LeetCodeProblems.TreeProblems.Leetcode_856_Score_of_Parentheses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.TreeProblems.Leetcode_856_Score_of_Parentheses
{
    [TestClass]
    public class Leetcode_856_ScoreOfParantheses_V3Tests
    {
        private static IEnumerable<object[]> GetParanthesesDataset()
        {
            var dataset = new List<object[]>();

            var setOne = new object[] { "{}{}", 2 };
            dataset.Add(setOne);

            var setTwo = new object[] { "{{}}", 2 };
            dataset.Add(setTwo);

            var setThree = new object[] { "{{}{}}", 4 };
            dataset.Add(setThree);

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetParanthesesDataset), DynamicDataSourceType.Method)]
        public void Given_Parantheses_When_CalculateScore_Then_ShouldReturnScore(string parantheses, int expectedScore)
        {
            //Given
            var problem = new Leetcode_856_ScoreOfParentheses_V3();

            //When
            var actualScore = problem.ComputeScore(parantheses);

            //Then
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}

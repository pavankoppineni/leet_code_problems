using LeetCodeProblems.SlidingWindowProblems.Leetcode_2024_MaximizeTheConfusionOfExam;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.SlidingWindowProblems.Leetcode_2024_MaximizeTheConfusionOfExam
{
    [TestClass]
    public class Leetcode_2024_MaximizeTheConfusionOfExam_V1Tests
    {
        [TestMethod]
        public void Given_AnswerKey_When_CalculateMaximumConfusion_Then_ShouldReturnMaximumConfusion()
        {
            //Given
            //var answerKey = "TTFTTFTTTT";
            var answerKey = "TTFTTFTTTT";
            var k = 2;
            var problem = new Leetcode_2024_MaximizeTheConfusionOfExam_V1();
            var expectedResult = 7;

            //When
            var actualResult = problem.CalculateMaximumConfusion(answerKey, k);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

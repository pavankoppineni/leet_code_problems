using LeetCodeProblems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeProblems.Tests.DynamicProgramming
{
    [TestClass]
    public class Leetcode_2320_CountNumberOfWaysToPlaceHouses_V1Tests
    {
        [TestMethod]
        public void Given_NumberOfPlots_When_CalculateNumberOfPlacements_Then_ShouldReturnNumberOfPlacements()
        {
            //Given
            var number = 1000;
            var problem = new Leetcode_2320_CountNumberOfWaysToPlaceHouses_V1();
            var expectedResult = 64;

            //When
            var actualResult = problem.CalculateNumberOfPlacements(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

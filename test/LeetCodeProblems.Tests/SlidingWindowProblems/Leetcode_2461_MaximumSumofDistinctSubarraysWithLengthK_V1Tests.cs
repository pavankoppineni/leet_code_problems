using LeetCodeProblems.SlidingWindowProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeProblems.Tests.SlidingWindowProblems
{
    [TestClass]
    public class Leetcode_2461_MaximumSumofDistinctSubarraysWithLengthK_V1Tests
    {
        [TestMethod]
        public void CalculateSubArraySum_ReturnsMaxSum()
        {
            // Arrange
            int[] values = { 1, 5, 4, 2, 9, 9, 9 };
            int size = 3;
            int expectedSum = 12;
            var problem = new Leetcode_2461_MaximumSumofDistinctSubarraysWithLengthK_V1();

            // Act
            int actualSum = problem.CalculateSubArraySum(values, size);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}

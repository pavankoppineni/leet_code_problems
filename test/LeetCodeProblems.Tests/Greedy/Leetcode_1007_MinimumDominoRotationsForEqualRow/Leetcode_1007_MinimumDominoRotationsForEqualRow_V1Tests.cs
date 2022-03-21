using LeetCodeProblems.Greedy.Leetcode_1007_MinimumDominoRotationsForEqualRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Greedy.Leetcode_1007_MinimumDominoRotationsForEqualRow
{
    [TestClass]
    public class Leetcode_1007_MinimumDominoRotationsForEqualRow_V1Tests
    {
        [TestMethod]
        public void Given_TopAndBottomArray_When_FindMinimumRotations_Then_ShouldReturnMinRotations()
        {
            //Given
            var top = new int[] { 2, 1, 2, 4, 2, 2};
            var bottom = new int[] { 5, 2, 6, 2, 3, 2 };
            var problem = new Leetcode_1007_MinimumDominoRotationsForEqualRow_V1();
            var expectedResult = 2;

            //When
            var actualResult = problem.MinDominoRotations(top, bottom);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

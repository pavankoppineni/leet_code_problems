using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_769_MaxChunksToMakeSorted_V1Test
    {
        [TestMethod]
        public void Given_Values_When_CalculateMaxChunks_Then_ShouldReturnMaxChunks()
        {
            //Given
            var values = new int[] { 4, 3, 2, 1, 0 };
            var problem = new Leetcode_769_MaxChunksToMakeSorted_V1();
            var expectedResult = 1;

           //When
           var actualResult = problem.CalculateMaximumChunks(values);

           //Then
           Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

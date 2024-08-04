using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class Leetcode_954_ArrayOfDoubledPairs_V1Tests
    {
        [TestMethod]
        public void Given_Values_When_CheckForDoubledPairs_Then_ShouldReturnTrueIfArrayIsDoubledPairs()
        {
            //Given
            var values = new int[] { 4, 2, 4, 4, 2, -4, 0, -2, 0, 4 };
            var problem = new Leetcode_954_ArrayOfDoubledPairs_V1();
            var expectedResult = false;

            //When
            var acutalResult = problem.CanReorder(values);

            //Then
            Assert.AreEqual(expectedResult, acutalResult);
        }
    }
}

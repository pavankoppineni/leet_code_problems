using LeetCodeProblems.Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Tests.Greedy
{
    [TestClass]
    public class Leetcode_915_PartitionArrayIntoDisjointIntervals_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_PartitionIntoDisjointSets_Then_ShouldReturnLengthOfLeftArray()
        {
            //Given
            var problem = new Leetcode_915_PartitionArrayIntoDisjointIntervals_V1();
            var values = new int[] { 5, 0, 3, 8, 6 };
            var expectedLength = 3;

            //When
            var actualResult = problem.CalculateDisjointInterval(values);

            //Then
            Assert.AreEqual(expectedLength, actualResult);
        }
    }
}

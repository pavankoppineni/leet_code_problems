using LeetCodeProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.ArrayProblems
{
    [TestClass]
    public class LeetCode_307_RangeSumQueryMutable_V1Tests
    {
        [TestMethod]
        public void Given_ArrayOfIntegers_When_GetSumRange_Then_ShouldGetSumOfThatRange()
        {
            //Given
            var values = new int[] { 1, 2, 3 };
            var problem = new LeetCode_307_RangeSumQueryMutable_V1(values);
            var expectedResultBeforeUpdate = 6;
            var expectedResultAfterUpdate = 8;

            //When
            var actualResultBeforeUpdate = problem.SumRange(0, 2);
            problem.Update(0, 3);
            var actualResultAfterUpdte = problem.SumRange(0, 2);

            //Then
            Assert.AreEqual(expectedResultBeforeUpdate, actualResultBeforeUpdate);
            Assert.AreEqual(expectedResultAfterUpdate, actualResultAfterUpdte);

        }
    }
}

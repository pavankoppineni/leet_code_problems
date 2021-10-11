using LeetCodeProblems.DynamicProgramming.RemoveArrayEndElementToMaximizeSumOfProduct;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.DynamicProgramming.RemoveArrayEndElementToMaximizeSumOfProduct
{
    [TestClass]
    public class RemoveArrayEndElementToMaximizeSumOfProduct_V1Tests
    {
        [TestMethod]
        public void Given_IntegerArray_When_FindMaximumSumOfProduct_Then_ShouldReturnMaximumSumOfProduct()
        {
            //Given
            var values = new int[] { 1, 2, 3};
            var problem = new RemoveArrayEndElementToMaximizeSumOfProduct_v1();
            var expectedSum = 14;

            //When
            var actualSum = problem.MaximizeSumOfProduct(values);

            //Then
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}

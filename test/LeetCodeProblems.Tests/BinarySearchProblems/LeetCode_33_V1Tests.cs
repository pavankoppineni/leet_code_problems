using LeetCodeProblems.BinarySearchProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems
{
    [TestClass]
    public class LeetCode_33_V1Tests
    {
        private static IList<object[]> GetTestData()
        {
            var dataset = new List<object[]>();
            //Test Case One : Array is not rotated
            dataset.Add(new object[]
            {
                //Array
                new int[] { 1, 2, 3, 4, 5},

                //Target element
                3,

                //Expected index
                2
            });

            //Test Case Two : Array is rotated, pivot is to the right side of array
            // and target element is to right side of array
            dataset.Add(new object[]
            {
                //Rotated sorted array
                new int[] { 3, 4, 5, 1, 2},

                //Target element
                2,

                //Expected index
                4
            });

            //Test Case Three : Array is rotated, pivot is to the right side of array
            // and target element is to left side of array
            dataset.Add(new object[]
            {
                //Rotated sorted array
                new int[] { 3, 4, 5, 1, 2},

                //Target element
                4,

                //Expected index
                1
            });

            //Test Case Four : Array is rotated, pivot is to the left side of array
            // and target element is to left side of array
            dataset.Add(new object[]
            {
                //Rotated sorted array
                new int[] { 5, 1, 2, 3, 4},

                //Target element
                1,

                //Expected index
                1
            });

            //Test Case Four : Array is rotated, pivot is to the left side of array
            // and target element is to right side of array
            dataset.Add(new object[]
            {
                //Rotated sorted array
                new int[] { 5, 1, 2, 3, 4},

                //Target element
                3,

                //Expected index
                3
            });

            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Given_RotatedSortedArrayAndTargetNumber_When_SearchElement_Then_ShouldReturnIndexOfTargetElement(int[] rotatedArray, int target, int expectedIndex)
        {
            //Given
            var problem = new LeetCode_33_V1();

            //When
            var actualIndex = problem.SearchElement(rotatedArray, target);

            //Then
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}

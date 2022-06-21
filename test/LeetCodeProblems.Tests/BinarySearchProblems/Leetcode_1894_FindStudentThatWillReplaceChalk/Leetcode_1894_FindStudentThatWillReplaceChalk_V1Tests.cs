using LeetCodeProblems.BinarySearchProblems.Leetcode_1894_FindStudentThatWillReplaceChalk;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.BinarySearchProblems.Leetcode_1894_FindStudentThatWillReplaceChalk
{
    [TestClass]
    public class Leetcode_1894_FindStudentThatWillReplaceChalk_V1Tests
    {
        [TestMethod]
        public void Given_StudentsAndCapacity_When_FindStudent_Then_ShouldReturnStudentIndex()
        {
            //Given
            var students = new int[] { 3, 4, 1, 3 };
            var capacity = 22;
            var problem = new Leetcode_1894_FindStudentThatWillReplaceChalk_V1();
            var expectedResult = 0;

            //When
            var actualResult = problem.FindStudent(students, capacity);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

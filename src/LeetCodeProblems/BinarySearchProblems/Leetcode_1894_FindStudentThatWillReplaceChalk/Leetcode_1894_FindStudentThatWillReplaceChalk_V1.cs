using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.BinarySearchProblems.Leetcode_1894_FindStudentThatWillReplaceChalk
{
    /// <summary>
    /// 
    /// </summary>
    public class Leetcode_1894_FindStudentThatWillReplaceChalk_V1
    {
        private int[] _students;
        public int FindStudent(int[] students, int k)
        {
            _students = students;
            for (var index = 1; index < students.Length; index++)
            {
                students[index] += students[index - 1];
            }
            var factor = k / students[students.Length - 1];
            var remaining = k - (factor * students[students.Length - 1]);
            if (remaining < students[0])
            {
                return 0;
            }

            return FindStudent(0, students.Length - 1, remaining);
        }

        private int FindStudent(int start, int end, int value)
        {
            if (start == end)
            {
                return start;
            }
            var mid = start + (end - start) / 2;

            //Case 1 : When mid is equal to value
            if (_students[mid] == value)
            {
                return mid + 1;
            }

            //Case 2 : When mid is greater than value
            if (value > _students[mid])
            {
                return FindStudent(mid + 1, end, value);
            }
            return FindStudent(start, mid, value);
        }
    }
}

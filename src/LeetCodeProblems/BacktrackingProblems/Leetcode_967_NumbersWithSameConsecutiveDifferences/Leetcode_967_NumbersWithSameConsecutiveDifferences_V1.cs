using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_967_NumbersWithSameConsecutiveDifferences
{
    /// <summary>
    /// https://leetcode.com/problems/numbers-with-same-consecutive-differences/
    /// </summary>
    public class Leetcode_967_NumbersWithSameConsecutiveDifferences_V1
    {
        private IList<int> _numbers;
        private int _size;
        private int _difference;

        public int[] NumsSameConsecDiff(int size, int difference)
        {
            _size = size;
            _difference = difference;
            _numbers = new List<int>();
            for (var number = 1; number < 10; number++)
            {
                Calcualte(1, number, number);
            }
            return _numbers.ToArray();
        }

        private void Calcualte(int index, int number, int reminder)
        {
            if (index >= _size)
            {
                _numbers.Add(number);
                return;
            }

            if (_difference == 0)
            {
                Calcualte(index + 1, (number * 10) + reminder, reminder);
                return;
            }

            var left = reminder - _difference;
            if (left >= 0)
            {
                Calcualte(index + 1, number * 10 + left, left);
            }

            var right = reminder + _difference;
            if (right < 10)
            {
                Calcualte(index + 1, number * 10 + right, right);
            }
        }
    }
}

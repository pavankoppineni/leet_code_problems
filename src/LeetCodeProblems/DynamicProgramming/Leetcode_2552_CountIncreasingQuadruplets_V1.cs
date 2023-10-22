using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/count-increasing-quadruplets/
    /// </summary>
    public class Leetcode_2552_CountIncreasingQuadruplets_V1
    {
        private int[] _values;
        private int[] _quadruplet;
        private IDictionary<string, long> _wakeup;
        public long CountNumberOfQuadruplets(int[] values)
        {
            _values = values;
            _quadruplet = new int[4];
            _wakeup = new Dictionary<string, long>();
            long count = 0;
            for (var index = 0; index < _values.Length; index++)
            {
                _quadruplet[0] = _values[index];
                count += CountNumberOfQuadruplets(index + 1, 1);
            }
            return count;
        }

        private long CountNumberOfQuadruplets(int index, int level)
        {
            if (level == 4)
            {
                return 1;
            }

            if (index >= _values.Length)
            {
                return 0;
            }
            var key = $"{level}-{index}";
            if (_wakeup.ContainsKey(key))
            {
                return _wakeup[key];
            }

            long count = 0;
            for (var currentIndex = index; currentIndex < _values.Length; currentIndex++)
            {
                _quadruplet[level] = _values[currentIndex];
                CountNumberOfQuadruplets(currentIndex + 1, level + 1);
                if (level == 2)
                {
                    if (_quadruplet[2] > _quadruplet[3])
                    {
                        count += 1;
                    }
                }
                else if (level == 1)
                {
                    if (_quadruplet[1] < _quadruplet[3] && _quadruplet[1] > _quadruplet[2])
                    {
                        count += 1;
                    }
                }
            }
            _wakeup.Add(key, count);
            return count;
        }
    }
}

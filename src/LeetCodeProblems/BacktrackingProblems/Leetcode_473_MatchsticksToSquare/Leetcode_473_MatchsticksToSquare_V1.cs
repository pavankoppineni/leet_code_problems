using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.BacktrackingProblems.Leetcode_473_MatchsticksToSquare
{
    /// <summary>
    /// https://leetcode.com/problems/matchsticks-to-square/
    /// </summary>
    public class Leetcode_473_MatchsticksToSquare_V1
    {
        private IDictionary<int, int> _sides;
        private int[] _matchSticks;
        private bool _isValid;
        public bool CanMakeSquare(int[] matchSticks)
        {
            _isValid = false;
            _matchSticks = matchSticks;
            _sides = new Dictionary<int, int>()
            {
                { 0, 0 },
                { 1, 0 },
                { 2, 0 },
                { 3, 0 }
            };
            CanMakeSquare(0);
            return _isValid;
        }

        private void CanMakeSquare(int index)
        {
            if (_isValid)
            {
                return;
            }

            if (index == _matchSticks.Length)
            {
                _isValid = _sides.Values.GroupBy(i => i).Count() == 1;
                return;
            }

            var count = 0;
            while (count < 4)
            {
                _sides[count] += _matchSticks[index];
                CanMakeSquare(index + 1);
                _sides[count] -= _matchSticks[index];
                count++;
            }
        }
    }
}

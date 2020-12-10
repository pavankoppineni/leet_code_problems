using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.StringProblems
{
    /// <summary>
    /// https://leetcode.com/problems/shifting-letters/
    /// </summary>
    public class Leetcode_848_ShiftingLetters_V1
    {
        public string ShiftLetters(string str, int[] shifts)
        {
            if (shifts.Length == 0)
            {
                return str;
            }

            var newStr = new char[shifts.Length];
            var offsetShift = 0;
            for(var i = shifts.Length - 1; i >=0; i--)
            {
                var shiftPosition = shifts[i] % 26;
                var newChar = ShiftCharacter(str[i], shiftPosition + offsetShift);
                newStr[i] = newChar;
                offsetShift += shiftPosition;
            }

            return new string(newStr);
        }

        private char ShiftCharacter(char charItem, int shiftPosition)
        {
            //Base case
            if (shiftPosition == 0)
            {
                return charItem;
            }

            var offset = charItem - 'a';
            shiftPosition %= 26;
            // Case 1: Shiftposition is zero
            // Action : Return same chanracter
            if (shiftPosition == 0)
            {
                return charItem;
            }

            //Case 2: New shiftposition is greater than 25
            var newShiftPosition = offset + shiftPosition;
            if (newShiftPosition > 25)
            {
                newShiftPosition %= 26;
                return Convert.ToChar(newShiftPosition + 'a');
            }

            //Case 3 : New shiftposition is less than or equal to 25
            return Convert.ToChar(newShiftPosition + 'a');
        }
    }
}

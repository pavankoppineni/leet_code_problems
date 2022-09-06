using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DynamicProgramming.Leetcode_131_Palindrome_Partitioning
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-partitioning/
    /// </summary>
    public class Leetcode_131_Palindrome_Partitioning_V1
    {
        private string _str;
        public IList<IList<string>> GeneratePalindromes(string str)
        {
            _str = str;
            return GeneratePalindromes(0, str.Length - 1);
        }

        private IList<IList<string>> GeneratePalindromes(int start, int end)
        {
            if (start > end)
            {
                return new List<IList<string>>();
            }

            IList<IList<string>> palindromes = new List<IList<string>>();
            for (var index = start; index <= end; index++)
            {
                if (!IsPalindrome(start, index))
                {
                    continue;
                }
                var downStreamPalindromes = GeneratePalindromes(index + 1, end);
                if (downStreamPalindromes.Count == 0)
                {
                    var currentPalindromes = new List<string>
                    {
                        _str.Substring(start, index - start + 1)
                    };
                    palindromes.Add(currentPalindromes);
                }
                else
                {
                    var currentString = _str.Substring(start, index - start + 1);
                    foreach (var palindrome in downStreamPalindromes)
                    {
                        palindrome.Add(currentString);
                    }
                    palindromes = downStreamPalindromes;
                }
            }
            return palindromes;
        }

        private bool IsPalindrome(int start, int end)
        {
            while (start <= end)
            {
                if (_str[start] != _str[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}

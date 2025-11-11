using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.DynamicProgramming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-score-words-formed-by-letters/description/
    /// </summary>
    public class Leetcode_1255_MaximumScoreWords_V1
    {
        private int _maxScore;
        private string[] _words;
        private IDictionary<char, LetterInfo> _lettersLookup;
        public int MaxScoreWords(string[] words, string[] letters, int[] score)
        {
            _words = words;
            _lettersLookup = new Dictionary<char, LetterInfo>();
            for (var index = 0; index < letters.Length; index++)
            {
                var letter = letters[index];
                var letterChar = letter[0];
                if (_lettersLookup.ContainsKey(letterChar))
                {
                    _lettersLookup[letterChar].Count++;
                    continue;
                }

                var letterInfo = new LetterInfo
                {
                    Letter = letterChar,
                    Score = score[letterChar - 'a'],
                    Count = 1
                };
                _lettersLookup.Add(letterChar, letterInfo);
            }

            CalculateScore(0, new Dictionary<char, int>());
            return _maxScore;
        }

        private int CalculateScore(int index, IDictionary<char, int> lettersLookup)
        {
            if (index >= _words.Length)
            {
                var score = 0;
                foreach (var letterEntry in lettersLookup)
                {
                    if (letterEntry.Value == 0)
                    {
                        continue;
                    }

                    if (!_lettersLookup.ContainsKey(letterEntry.Key))
                    {
                        return 0;
                    }

                    var letterInfo = _lettersLookup[letterEntry.Key];
                    if (letterEntry.Value > letterInfo.Count)
                    {
                        return 0;
                    }

                    score += letterEntry.Value * letterInfo.Score;
                }

                _maxScore = Math.Max(_maxScore, score);
                return score;
            }

            var scoreWithoutCurrentWord = CalculateScore(index + 1, lettersLookup);
            foreach (var letter in _words[index])
            {
                if (lettersLookup.ContainsKey(letter))
                {
                    lettersLookup[letter] += 1;
                }
                else
                {
                    lettersLookup.Add(letter, 1);
                }
            }
            var scoreWithCurrentWord = CalculateScore(index + 1, lettersLookup);

            // Backtrack step
            foreach (var letter in _words[index])
            {
                lettersLookup[letter] -= 1;
            }
            return Math.Max(scoreWithoutCurrentWord, scoreWithCurrentWord);
        }
    }

    public class LetterInfo
    {
        public char Letter { get; set; }
        public int Count { get; set; }
        public int Score { get; set; }
    }
}

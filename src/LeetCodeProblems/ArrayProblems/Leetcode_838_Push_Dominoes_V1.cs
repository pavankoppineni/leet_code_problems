using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.ArrayProblems
{
    /// <summary>
    /// https://leetcode.com/problems/push-dominoes/description
    /// </summary>
    public class Leetcode_838_Push_Dominoes_V1
    {
        public string PushDominoes(string dominoes)
        {
            var states = new DominoState[dominoes.Length];
            DominoPointer dominoPointer = null;
            for (var index = 0; index < dominoes.Length; index++)
            {
                var domino = dominoes[index];
                switch (domino)
                {
                    case '.':
                        var state = new DominoState
                        {
                            Left = dominoPointer
                        };
                        states[index] = state;
                        break;
                    case 'R':
                        dominoPointer = DominoPointer.Right(index);
                        break;
                    case 'L':
                        dominoPointer = DominoPointer.Left(index);
                        break;
                }
            }

            dominoPointer = null;
            for (var index = dominoes.Length - 1; index >= 0; index--)
            {
                var domino = dominoes[index];
                switch (domino)
                {
                    case '.':
                        states[index].Right = dominoPointer;
                        break;
                    case 'R':
                        dominoPointer = DominoPointer.Right(index);
                        break;
                    case 'L':
                        dominoPointer = DominoPointer.Left(index);
                        break;
                }
            }

            var result = new char[dominoes.Length];
            for (var index = 0; index < dominoes.Length; index++)
            {
                if (dominoes[index] == '.')
                {
                    continue;
                }
                result[index] = dominoes[index];
            }
            return string.Empty;
        }
    }

    public enum DominoType
    {
        Left,
        Right
    }

    public class DominoState
    {
        public DominoPointer Left {  get; set; }
        public DominoPointer Right { get; set; }
    }

    public class DominoPointer
    {
        public DominoType Type { get; set; }
        public int Index { get; set; }

        public static DominoPointer Right(int index)
        {
            return new DominoPointer { Index = index, Type = DominoType.Right };
        }

        public static DominoPointer Left(int index)
        {
            return new DominoPointer { Index = index, Type = DominoType.Left };
        }
    }
}

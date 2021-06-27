using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.HiringChallenges
{
    /// <summary>
    /// Mr. Ramanujan is a mathematics teacher in Atmanirbhar School. 
    /// He is considered the best mathematics teacher because of his teaching 
    /// methods and interesting problems. He brings interesting problems for 
    /// students and provides a chocolate to the student who answers it correctly as a prize. 
    /// Thus, these problems have become popular as Chocolate problems.
    /// Mr.Ramanujan has brought N cards with him and has an integer written on each one of them.
    /// The integers on cards are numbered from 1 to N.He has asked students to arrange the cards
    /// in a linear manner.The problem is not simple though as the cards should be arranged in a
    /// manner such that the summation of absolute differences between the cards and their neighbours
    /// is maximum.The students got confused with the problem and asked Mr. Ramanujan for help.
    /// Mr.Ramanujan provides the below example to help the students.
    /// </summary>
    public class ChocolateProblem_V1
    {
        public int ConstructArray(int n)
        {
            var values = new int[n];
            var index = 1;
            var seed = 1;
            while (index < n)
            {
                values[index] = seed;
                index += 2;
                seed += 1;
            }
            return -1;
        }
    }
}

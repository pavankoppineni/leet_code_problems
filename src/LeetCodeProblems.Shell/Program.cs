using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace LeetCodeProblems.Shell
{
    public class Program
    {
        public static void Main()
        {
            Calculate(0, 10);
        }

        public static void Calculate(int startIndex, int length)
        {
            if (startIndex > length)
            {
                return;
            }

            for (var index = startIndex; index < length; index++)
            {
                Calculate(index + 2, length);
            }
        }
    }
}

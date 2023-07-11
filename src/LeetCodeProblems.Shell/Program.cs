using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;

namespace LeetCodeProblems.Shell
{
    public class Program
    {
        public static void Main()
        {
            var livePortals = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\leet_code_problems\src\LeetCodeProblems.Shell\Files\live-portals.txt");
            var livePortalsLookup = new HashSet<string>();
            foreach (var livePortal in livePortals)
            {
                livePortalsLookup.Add(livePortal.ToUpper());
            }

            var inprogressPortals = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\leet_code_problems\src\LeetCodeProblems.Shell\Files\inprogress-portals.txt");
            var inprogressPortalsLookup = new List<string>();
            foreach(var inprogressPortal in inprogressPortals)
            {
                if(livePortalsLookup.Contains(inprogressPortal.ToUpper()))
                {
                    inprogressPortalsLookup.Add(inprogressPortal);
                }
            }

            var completedPortals = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\leet_code_problems\src\LeetCodeProblems.Shell\Files\completed-portals.txt");
            var completedPortalsLookup = new List<string>();
            foreach (var completedPortal in completedPortals)
            {
                if (livePortalsLookup.Contains(completedPortal.ToUpper()))
                {
                    completedPortalsLookup.Add(completedPortal);
                }
            }

            var notStartedPortals = File.ReadAllLines(@"C:\Users\pkoppineni\source\repos\leet_code_problems\src\LeetCodeProblems.Shell\Files\Notstarted-portals.txt");
            var notStartedPortalsLookup = new List<string>();
            foreach (var notStartedPortal in notStartedPortals)
            {
                if (livePortalsLookup.Contains(notStartedPortal.ToUpper()))
                {
                    notStartedPortalsLookup.Add(notStartedPortal);
                }
            }

            var inprogressPortalNames = "";
            foreach(var item in completedPortalsLookup)
            {
                inprogressPortalNames += "\r\n" + item;
            }
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

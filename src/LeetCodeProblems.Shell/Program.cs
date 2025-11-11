using Confluent.Kafka;
using LeetCodeProblems.ArrayProblems;
using LeetCodeProblems.BacktrackingProblems;
using LeetCodeProblems.DynamicProgramming;
using LeetCodeProblems.Greedy;
using LeetCodeProblems.MatrixProblems;
using LeetCodeProblems.SlidingWindowProblems;
using LeetCodeProblems.TreeProblems;
using LeetCodeProblems.TreeProblems;
using LeetCodeProblems.TwoPointers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
    {
        var prices = new List<int> { 2, 5 };
        var special = new List<IList<int>>
        {
            new List<int> {3,0,5 },
            new List<int> {1,2,10 },
        };
        var needs = new List<int> { 3, 2 };
        var problem = new Leetcode_638_ShoppingOffers_V1();
        var result = problem.ShoppingOffers(prices, special, needs);
    }

    public static void Play_1695()
    {
        var values = new int[]
        {
            449,154,934,526,429,732,784,909,884,805,635,660,742,209,742,272,669,449,766,904,698,434,280,332,876,200,333,464,12,437,269,355,622,903,262,691,768,894,929,628,867,844,208,384,644,511,908,792,56,872,275,598,633,502,894,999,788,394,309,950,159,178,403,110,670,234,119,953,267,634,330,410,137,805,317,470,563,900,545,308,531,428,526,593,638,651,320,874,810,666,180,521,452,131,201,915,502,765,17,577,821,731,925,953,111,305,705,162,994,425,17,140,700,475,772,385,922,159,840,367,276,635,696,70,744,804,63,448,435,242,507,764,373,314,140,825,34,383,151,602,745
        };

        var problem = new Leetcode_1695_MaximumErasureValue_V1();
        var result = problem.FindMaximumUniqueSubarray(values);
    }
}

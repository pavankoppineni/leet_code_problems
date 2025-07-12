using Confluent.Kafka;
using LeetCodeProblems.Greedy;
using Newtonsoft.Json;
using System.Threading;

public class Program
{
    public static void Main()
    {
        var problem = new Leetcode_945_MinimumIncrementToMakeArrayUnique_V1();
        var a = problem.Calculate(new int[] {7,7,8,8});
    }
}

public class AnalyticsDatasetIndexingMessage
{
    public string DatasetName { get; set; }
    public string Provider { get; set; }
    public string RequestedBy { get; set; }
    public string Reason { get; set; }
    public string RequestSource { get; set; }
    public string CorrelationId { get; set; }
}

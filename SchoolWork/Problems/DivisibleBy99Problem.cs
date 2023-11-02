using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace SchoolWork;

public class DivisibleBy99Problem : Problem
{
    private bool DistinctInt(int inp)
    {
        if (inp % 99 != 0)
            return false;
        
        string cast = inp.ToString();
        if (cast.Contains('0'))
            return false;

        if (cast.Distinct().Count() == cast.Length)
        {
            Console.WriteLine(inp);
            Environment.Exit(inp);
        }
        return false;
    }
    private long Lowest99()
    {
        var evalTime = new Stopwatch();
        evalTime.Start();
        for (int i = 123456789; i < 123999999; i++)
        {
            if (DistinctInt(i))
            {
                Console.WriteLine(i);
                break;
            }
        }
        evalTime.Stop();
        return evalTime.Elapsed.Nanoseconds;
    }
    public override void RunProblem()
    {
        List<long> times = new List<long>();
        var benchBenchZeit = new Stopwatch();
        benchBenchZeit.Start();
        for (int i = 0; i < 10000000; i++)
        {
            times.Add(Lowest99());
        }
        benchBenchZeit.Stop();
        
        var benchStatBench = new Stopwatch();
        benchStatBench.Start();
        double average = times.Average();
        
        double sum = times.Sum(d => Math.Pow(d-average, 2));
        double stdDev = Math.Sqrt(sum / times.Count - 1);
        benchStatBench.Stop();
        
        Console.WriteLine($"Average: {average}ns");
        Console.WriteLine($"Deviation: {stdDev}");
        Console.WriteLine($"Time to benchmark: {benchBenchZeit.Elapsed}");
        Console.WriteLine($"Time get stats: {benchStatBench.Elapsed}");
    }
}
using System.Diagnostics;

namespace SchoolWork;

public class EulerSieveProblem : Problem
{
    private List<int> ListOfPrimesUnderN(int n)
    {
        var range = Enumerable.Range(2,n-1)
            //.Where(x=>x%2!=0)
            .ToList();
        for(int i = 2; i < range.Count/2; i++)
        {
            for (int j = i; j < range.Count; j++)
            {
                if(range[j] % i == 0)
                    range.RemoveAt(j);
            }
        }
        return range;
    }
    public override void RunProblem()
    {
        var sw = new Stopwatch();
        sw.Start();
        var primes = ListOfPrimesUnderN(500000);
        sw.Stop();
        primes.ForEach(Console.WriteLine);
        Console.WriteLine(sw.Elapsed.ToString());
    }
}
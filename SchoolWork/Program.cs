using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;

namespace SchoolWork
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Running");
            List<int> results = new();
            var lot = new LotkaVolterra();
            // for (int i = 0; i < 10000; i++)
            // {
            //     results.Add(lot.WeeksForLotteryWin(10, 20, 30));
            // }
            // Console.WriteLine(results.Average());
            Console.WriteLine(LotkaVolterra.PredatorPrey(30, 5, 0.8f, 0.5f, 0.1f, 0.3f));
        }
    }
}


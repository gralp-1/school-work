using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;

namespace SchoolWork
{
    class Program
    {
        private static void Main()
        {
            // float A = 0.8f; // prey reproduction rate
            // float B = 0.9f;
            // float C = 0.1f;
            // float D = 0.3f;
            // int initalPredators = 5;
            // int initalPrey = 30;
            // var data = LotkaVolterra.PredatorPrey(initalPredators, initalPrey, A,B,C,D);
            // convert the list of generations into a csv
            new TimeSheetProblem().RunProblem();
            // data.ForEach(Console.WriteLine);
            
        }
        /*
        private static void Main()
        {
            var problems = new Dictionary<string, Problem>();
            problems.Add("ball pit", new BallPitProblem());
            problems.Add("carpet", new CarpetProb());
            problems.Add("characters", new CharactersProb());
            problems.Add("circle", new CirclePropertiesProb());
            problems.Add("dice", new DiceProb());
            problems.Add("energy bill", new EnergyBillProb());
            problems.Add("fish tank", new FishTankProb());
            problems.Add("hello world", new HelloWorldProb());
            problems.Add("magnification", new MagnificationProb());
            problems.Add("temperature", new TemperatureProblem());
            problems.Add("day format", new DayFormatProblem());
            problems.Add("max", new MaxProblem());
            problems.Add("water states", new StatesOfWaterProblem());
            problems.Add("periodic table", new PeriodicTableProblem());
            problems.Add("nitrates", new NitrateProblem());
            problems.Add("exam grade", new ExamGradeProblem());
            problems.Add("driving test", new DrivingTestProblem());
            problems.Add("currency", new CurrencyConverterProblem());
            problems.Add("career quote", new CareerQuoteProblem());
            
            Console.WriteLine("\"quit\" to exit");
            string? res;
            do
            {
                res = Console.ReadLine();
                Console.Clear();
                try
                {
                    problems[res].RunProblem();
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine($"Could not find problem {res}, needs to be one of [{string.Join(", ", problems.Keys)}].", Console.Error);
                }
            } while (res != "quit");
        }
    */
    }
}


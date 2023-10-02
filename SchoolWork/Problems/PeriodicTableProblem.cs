using System.Runtime.CompilerServices;

namespace SchoolWork;

public class PeriodicTableProblem : Problem
{
    public string PeriodicTable(string? sym)
    {
        // just branch on the symbol
        switch (sym.ToLower()) 
        {
            case "h":
            {
                return @"
Element H:
    Name:   Hydrogen
    Weight: 1.008
    Group:  Reactive non metals";
            }
            case "he":
            {
                return @"
Element He:
    Name:   Helium
    Weight: 4.00
    Group:  Noble gasses";
            }
            case "li":
            {
                return @"
Element Li:
    Name:   Lithium
    Weight: 6.94
    Group:  Alkali metals";
            }
        }
        throw new ArgumentException($"{sym} is not a valid argument");
    }

    public override void RunProblem()
    {
        string? symbol = Console.ReadLine();
        try
        {
            Console.WriteLine(PeriodicTable(symbol));
        }
        catch (ArgumentException _)
        {
            Console.Error.WriteLine($"{symbol} is not a valid element symbol yet");
        }
    }
}
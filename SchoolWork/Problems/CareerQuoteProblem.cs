using Microsoft.VisualBasic;

namespace SchoolWork;

public class CareerQuoteProblem : Problem
{
    private static string CareerQuote(string job)
    {
        // branch on job name
        switch (job.ToLower())
        {
            case "engineer": {
                return "The engineer has been, and is, the maker of history.";
            }
            case "developer":
            {
                return "Logical thinking, passion and perseverance is the paint on your palette.";
            }
            case "analyst":
            {
                return "Seeing what other people can't gives you great vision";
            }
        }
        return "I'm sorry. We could not find a quote for your job.";
    }

    public override void RunProblem()
    {
        Console.WriteLine(CareerQuote("developer"));
    }
}
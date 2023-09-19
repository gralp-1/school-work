namespace SchoolWork;

public class NitrateProblem : Problem
{
    private static double Nitrates(double nitrate)
    {
        return nitrate > 10 ?
            3 : 
            nitrate > 2.5 ? // we already know it's not more than 10
                2 :
                nitrate > 1 ? // we already know it's not more than 2.5
                    1 : 
                    0.5;
    }

    public override void RunProblem()
    {
        double nitrate = 4;
        Console.WriteLine($"For {nitrate} dose {Nitrates(nitrate)} ml");
    }
}
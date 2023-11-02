namespace SchoolWork;

public class CompoundInterestProblem : Problem
{
    int Compound(double desired, double balance, double rate)
    {
        // input rate is the percentage as a decimal so .04 for 4%
        // we need to convert this to 1.04 so we can multiply
        int terms = 1;
        rate += 1d;
        while(balance < desired)
        {
            balance *= rate;
            terms += 1;
        }
        return terms;
    }
    public override void RunProblem()
    {
        Console.WriteLine(Compound(200, 100, 0.04));
    }
}
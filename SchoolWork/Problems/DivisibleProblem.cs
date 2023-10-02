namespace SchoolWork;

public class DivisibleProblem : Problem
{
    bool Divisible(double first, double second)
    {
        return second != 0 && first % second == 0;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
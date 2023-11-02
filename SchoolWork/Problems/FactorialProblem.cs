namespace SchoolWork;

public class FactorialProblem : Problem
{
    private int Factorial(int n)
    {
        return n switch
        {
            0 | 1 => 1,
            _ => n * Factorial(n - 1)
        };
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
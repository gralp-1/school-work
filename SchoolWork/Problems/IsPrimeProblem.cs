namespace SchoolWork;

public class IsPrimeProblem : Problem
{
    private bool IsPrime(int n)
    {
        bool isPrime = true;

        for (int i = 2; i < n/2; i++)
        {
            isPrime = n % i == 0;
        }
        
        return isPrime;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
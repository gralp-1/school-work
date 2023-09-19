namespace SchoolWork;

public class MaxProblem : Problem
{
    private int Max(int first, int second)
    {
        // simple ternary to return the highest
        return first > second ? first : second;
    }
    public override void RunProblem()
    {
        Console.WriteLine($"Max of 20 and 40 is {Max(20, 40)}");
    }
    
}
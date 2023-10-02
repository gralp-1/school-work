namespace SchoolWork;

public class MaxProblem : Problem
{
    
    private int Max(int f, int s) => new List<int> { f, s }.Max();
    
    
    public override void RunProblem()
    {
        Console.WriteLine($"Max of 20 and 40 is {Max(20, 40)}");
    }
    
}
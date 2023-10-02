namespace SchoolWork;

public class DrivingTestProblem : Problem
{
    private static string DrivingTest(int faults) => faults > 16 ? "fail" : "pass";
    
    
    public override void RunProblem()
    {
        Console.WriteLine(DrivingTest(16));
    }
}
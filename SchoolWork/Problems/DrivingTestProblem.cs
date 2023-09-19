namespace SchoolWork;

public class DrivingTestProblem : Problem
{
    private static bool DrivingTest(int minorFaults)
    {
        return minorFaults < 16; // returns true if the score is less than 16, else returns false
    }
    public override void RunProblem()
    {
        // outputs the result in a pass / fail format
        Console.WriteLine(DrivingTest(16) ? "pass" : "fail");
    }
}
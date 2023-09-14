namespace SchoolWork;

public class HelloWorldProb : Problem
{
    private static void OutputText()
    {
        Console.WriteLine("Hello World!");
    }

    public override void RunProblem()
    {
        OutputText();
    }
}
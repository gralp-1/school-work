namespace SchoolWork;

public class CharactersProb : Problem
{
    public static void OutputDigits()
    {
        string outputString = @"The digits are: 0123456789
The characters are: abcdABCD@#!£
The alphanumerics are: 0123456789 abcdABCD@#!£";
        Console.WriteLine(outputString);
    }

    public override void RunProblem()
    {
        OutputDigits();
    }
}
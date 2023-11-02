namespace SchoolWork;

public class ASCIIArtProblem : Problem
{
    private string ASCIIArt(string inp)
    {
        string topString = $"{string.Concat(Enumerable.Repeat("+-", inp.Length))}+";
        string text = "\n";
        for (int i = 0; i < inp.Length; i++)
        {
            text += $"|{inp[i]}";
        }
        text += "|\n";
        return topString + text + topString;
    }
    public override void RunProblem()
    {
        Console.WriteLine(ASCIIArt("hello"));
    }
}
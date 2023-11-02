namespace SchoolWork;

public class ROT13Problem : Problem
{
    private string ROT13Encode(string input)
    {
        // encode the input string using ROT13 (remember to wrap around)
        // return the encoded string
        return input.Select(c => (char)(c + 13)).ToString();
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
using System.Text;

namespace SchoolWork;

public class CharactersetProblem : Problem
{
    public int CharacterCode(char input, string characterSet)
    {
        return characterSet.ToLower() switch
        {
            "ascii" => Encoding.ASCII.GetBytes(input.ToString())[0],
            "ebdic" => Encoding.GetEncoding("IBM037").GetBytes(input.ToString())[0],
            _ => throw new ArgumentException("Encoding must be ASCII or EBDIC")
        };
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
namespace SchoolWork;

public class NameConventionsProblem : Problem
{
    private string CapitaliseAll(string[] input)
    {
        string res = "";
        foreach (string word in input)
        {
            res += word[0].ToString().ToUpper();
            res += word[1..];
        }
        return res;
    }
    private string NamingConventionsProblem(string text, string convention)
    {
        string[] parts = text.Split(" ");
        switch (convention)
        {
            case "kebab":
                return string.Join('-', parts);
            case "snake":
                return string.Join('_', parts);
            case "pascal":
                return CapitaliseAll(parts);
            case "camel":
                return parts[0].ToUpper() + CapitaliseAll(parts[1..]);
            default:
                throw new ArgumentException("convention argument needs to be kebab, snake, camel or pascal");
        }
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
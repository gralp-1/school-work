namespace SchoolWork;

public class UsernameProblem : Problem
{
    private void Username()
    {
        Console.WriteLine("Enter your full name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter date of birth (dd/mm/yyyy)");
        string dob = Console.ReadLine();
        
        string lowerName = name.ToLower().Remove(' ');
        string year = dob.Split('/')[2];
        Console.WriteLine($"Suggestion 1: {lowerName}_1");
        Console.WriteLine($"Suggestion 1: {lowerName}{year}");
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
namespace SchoolWork;

public class SurnameProblem : Problem
{
    private string FormatName(string inital, string surname)
    {
        return $"{inital[0].ToString().ToUpper()} {surname.ToUpper()}";
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
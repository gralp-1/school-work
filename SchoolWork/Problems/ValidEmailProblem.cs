namespace SchoolWork;

public class ValidEmailProblem : Problem
{
    public bool ValidEmail(string email)
    {
        string[] parts = email.Split("@");
        if (parts.Length != 2)
            return false;
        if (parts[1].Contains('.'))
            return true;
        return false;

    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
namespace SchoolWork;

public class PasswordProblem : Problem
{
    private bool IsPasswordValid(string password)
    {
        return password.Length < 8
               && password.Any(char.IsUpper)
               && password.Any(char.IsNumber);
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
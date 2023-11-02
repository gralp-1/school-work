namespace SchoolWork;

public class PasswordIndexProblem : Problem
{
    public string PasswordIndex(string password)
    {
        string vowels = "aeiou";
        string res = "";
        for (int i = 0; i < password.Length; i++)
        {
            if (vowels.Contains(password[i]))
                res += i.ToString();
        }

        return res;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
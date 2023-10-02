namespace SchoolWork;

public class TeacherCodeProblem : Problem
{
    public string TeacherCode(string first, string middle, string last)
    {
        string CapFirst(string inp) => inp == "" ? "Z" : inp[0].ToString().ToUpper();
        return CapFirst(first) + CapFirst(middle) + CapFirst(last);
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
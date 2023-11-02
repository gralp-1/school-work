namespace SchoolWork;

public class PlayerProblem : Problem
{
    private Func<string,string,bool> Exists = (inv, item) => inv.Contains(item);
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
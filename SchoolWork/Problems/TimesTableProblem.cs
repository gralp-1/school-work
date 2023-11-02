namespace SchoolWork;

public class TimesTableProblem : Problem
{
    private string TimesTables(int table)
    {
        string res = "";
        foreach (int i in Enumerable.Range(1,12))
        {
            res += $"{i}x{table} = {i * table}\n";
        }

        return res;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
namespace SchoolWork;

public class PlayerProblem : Problem
{
    public bool Exists(string item, string inventory)
    {
        return inventory.Split(",").Contains(item);
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
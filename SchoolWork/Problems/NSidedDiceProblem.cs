namespace SchoolWork;

public class NSidedDiceProblem : Problem
{
    private static Func<int, int> DiceRoll = sides => new Random().Next()%sides;
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
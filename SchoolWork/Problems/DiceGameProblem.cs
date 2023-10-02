namespace SchoolWork;

public class DiceGameProblem : Problem
{
    int DiceGame(int d1, int d2, int d3)
    {
        bool d1d2Equal = d1 == d2;
        bool d2d3Equal = d2 == d3;
        bool d1d3Equal = d1 == d3;

        if (d1d2Equal && d2d3Equal)
        {
            return d1 * 3; // they're all equal
        }
        if (d1d2Equal)
        {
            return d1 + d2 - d3;
        }
        if (d2d3Equal)
        {
            return d2 + d3 - d1;
        }
        if (d1d3Equal)
        {
            return d1 + d3 - d2;
        }
        return 0;
    }

    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
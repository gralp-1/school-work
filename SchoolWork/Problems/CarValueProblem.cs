namespace SchoolWork;

public class CarValueProblem : Problem
{
    private int CarValue(int year, double value, double minResaleValue)
    {
        value *= 0.7;
        int terms = 0;
        while (value > minResaleValue)
        {
            value *= 0.8;
            terms += 1;
        }

        return year - terms;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
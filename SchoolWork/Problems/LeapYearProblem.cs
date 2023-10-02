namespace SchoolWork;

public class LeapYearProblem : Problem
{
    bool LeapYear(uint year)
    {
        if (year % 4 == 0)
            return true;
        if (year % 100 == 0)
            return false;
        if (year % 400 == 0)
            return true;
        return false;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
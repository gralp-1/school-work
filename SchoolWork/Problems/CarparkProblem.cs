namespace SchoolWork;

public class CarparkProblem : Problem
{
    private double CarparkPrice(string start, string end, bool disabled)
    {
        uint startHour = Convert.ToUInt32(start.Split(':')[0]);
        uint endHour = Convert.ToUInt32(end.Split(':')[0]);
        uint hours = endHour - startHour;
        // free parking between 8pm and 6am
        if (startHour > 20)
        {
            hours -= 20 - startHour;
        }
        else if (endHour < 6)
        {
            hours -= endHour - 6;
        }
        if (disabled)
        {
            hours -= 3;
        }

        return hours switch
        {
            < 1 => 1.5,
            < 2 => 2.9,
            < 3 => 3.9,
            < 4 => 4.5,
            > 4 => 8.0
        };
    }
    
    
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
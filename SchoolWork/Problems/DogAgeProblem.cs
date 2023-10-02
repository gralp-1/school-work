namespace SchoolWork;

public class DogAgeProblem : Problem
{
    int DogAge(double years)
    {
        if (double.IsNegative(years))
            throw new ArgumentException("Years must be greater than 0");
        return (int)double.Floor(
            years < 2d ? // if years is less than two
            12 * years : // return 12 * years
            24 + 6 * (years - 2) // else return 12 + 6 * years
            );
    }
    
    
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
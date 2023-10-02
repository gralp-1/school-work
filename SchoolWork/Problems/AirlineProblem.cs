namespace SchoolWork;

public class AirlineProblem : Problem
{
    public string JourneyCode(string city1, string city2)
    {
        string ToCode(string inp) => inp[..4].ToUpper();
        return $"{ToCode(city1)}-{ToCode(city2)}";
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
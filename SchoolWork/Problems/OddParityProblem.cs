namespace SchoolWork;

public class OddParityProblem : Problem
{
    private bool OddParity(string binaryInput)
    {
        return binaryInput.Count(c => c == '1') % 2 == 0;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
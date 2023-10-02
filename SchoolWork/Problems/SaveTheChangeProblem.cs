namespace SchoolWork;

public class SaveTheChangeProblem : Problem
{
    private double SaveTheChange(double cost)
    {
        return cost-(double.Floor(cost)+1d);
    }
    public override void RunProblem()
    {
        double price = 1.2;
        double change = SaveTheChange(price);
        Console.WriteLine($@"
Price:  {price}
Change: {change}");
    }
}
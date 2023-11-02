namespace SchoolWork;

public class DiscountProblem : Problem
{
    public static List<int> Discounts()
    {
        // we need to evenly cover 50,
        // gen a random number mod 50 and add it 50/x times
        int step = new Random().Next() % 50;
        Console.WriteLine(step);
        List<int> steps = new List<int>();
        for (int i = 10; i < step/50; i += step)
        {
            steps.Add(i+10);
        }

        return steps;
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
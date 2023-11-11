namespace SchoolWork;

public class DiscountProblem : Problem
{
    public static List<int> Discounts(int target)
    {
        // we need to evenly cover 50,
        // gen a random number mod 50 and add it 50/x times
        int start = 10;
        int step = new Random().Next(1,10);
        List<int> steps = new List<int>();
        for (int i = start; i<=target-step; i++)
        {
            int.Clamp(start += step, 0, target);
            steps.Add(start);
        }
        return steps;
    }
    public override void RunProblem()
    {
        Discounts(60).ForEach(Console.WriteLine);
    }
}
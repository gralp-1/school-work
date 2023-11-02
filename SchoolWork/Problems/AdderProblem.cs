using System.Linq.Expressions;

namespace SchoolWork;

public class AdderProblem
{
    public void Adder()
    {
        List<int> res = new();
        int input;
        do
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
                res.Add(input);
        } while (input > 0);
        Console.WriteLine(res.Sum());
        Console.WriteLine(res.Count);
        Console.WriteLine(res.Average());
    }
}
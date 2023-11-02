namespace SchoolWork;

public class FizzBuzzProblem : Problem
{
    private void FizzBuzz(int n)
    {
        for (int i = 0; i < n; i++)
        {
            string fizzBuzz = (++i % 3 != 0 ? "" : "Fizz") + (i % 5 != 0 ? "" : "Buzz");
            Console.WriteLine(fizzBuzz == "" ? i : fizzBuzz);
        }
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
namespace SchoolWork;

public class StrongNumberProblem
{
    private int SafeFactorial(int n)
    {
        if (n == 0)
            return 1;
        return n * SafeFactorial(n - 1);
    }
    public void IsStrongNumber()
    {
        Console.WriteLine("Enter number:");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            bool isStrong = number == number
                .ToString()
                .Select(i => int.Parse(i.ToString()))
                .Select(SafeFactorial)
                .Sum();
            Console.WriteLine(isStrong ? "Strong Number" : "Not Strong Number");
        } catch (OverflowException)
        {
            Console.WriteLine("Number too big");
        }
        
    }
}
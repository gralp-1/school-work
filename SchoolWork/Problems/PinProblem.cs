namespace SchoolWork;

public class PinProblem
{
    public void EnterPin()
    {
        int target = 2353;
        int count = 0;
        while (count < 3)
        {
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == target)
            {
                Console.WriteLine("Correct");
                return;
            }
            Console.WriteLine("Incorrect");
            count++;
        }
        Console.WriteLine("Locked out");
    }
}
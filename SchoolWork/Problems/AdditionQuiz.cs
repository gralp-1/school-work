
namespace SchoolWork;

public class AdditionQuiz
{
    public void AdditionGame()
    {
        Console.Clear();
        var rng = new Random();
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            int first = rng.Next(10, 100);
            int second = rng.Next(10, 100);
            Console.WriteLine($"{first} + {second} = ?");
            int answer = int.Parse(Console.ReadLine());
            if (answer == first + second)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
        Console.WriteLine($"You scored {score} out of 5!");
        Thread.Sleep(3000);
        AdditionGame();
    }
}
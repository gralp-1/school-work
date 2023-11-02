namespace SchoolWork;

public class GuessTheNumberProblem : Problem
{
    private int GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    private void GuessTheNumber()
    {
        int answer = new Random().Next(1, 100);
        int guess;
        do
        {
            guess = GetInput("Guess a number between 1 and 100");
            if (guess > answer)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < answer)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        } while (guess != answer);
    }
    public override void RunProblem()
    {
        throw new NotImplementedException();
    }
}
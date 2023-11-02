namespace SchoolWork;

public class RockPaperScissorsProblem
{
    private int _playerWins = 0;
    private int _CPUWins = 0;

    private void EvaluatePair(string playerChoice, string CPUChoice)
    {
        if (playerChoice == CPUChoice)
            Console.WriteLine("Tie");
        switch (playerChoice, CPUChoice)
        {
            case ("rock", "scissors"):
                Console.WriteLine("Player wins");
                _playerWins++;
                break;
            case ("paper", "rock"):
                Console.WriteLine("Player wins");
                _playerWins++;
                break;
            case ("scissors", "paper"):
                Console.WriteLine("Player wins");
                _playerWins++;
                break;
            default:
                Console.WriteLine("CPU wins");
                _CPUWins++;
                break;
        }
    }
    private void RockPaperScissorsRound()
    {
        Console.WriteLine("Rock, paper, or scissors?");
        string playerChoice = Console.ReadLine().ToLower();
        string CPUChoice = new List<string>{"rock", "paper", "scissors"}[new Random().Next() % 3];
        EvaluatePair(playerChoice, CPUChoice);
    }
    
    public void RockPaperScissors()
    {
        while (_playerWins != 10 && _CPUWins != 10)
        {
            RockPaperScissorsRound();
        }
        Console.WriteLine($"Player score: {_playerWins}, CPU score: {_CPUWins}");
        Console.WriteLine(_playerWins > _CPUWins ? "Player wins" : "CPU wins");
    }
}
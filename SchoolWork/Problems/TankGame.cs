namespace SchoolWork;

public class TankGame
{
    // initialize the board
    enum TileState
    {
        Empty,
        EmptyShot,
        Tank,
        TankShot
    }
    TileState[,] board = new TileState[8,8];

    public TankGame()
    {
        // place 10 tanks randomly in the board
        var rng = new Random();
        List<(int, int)> positions = new();
        int x;
        int y;
        for (int i = 0; i < 10; i++)
        {
            do
            {
                x = rng.Next(0, 8);
                y = rng.Next(0, 8);
            } while (positions.Contains((x, y)));
            board[x, y] = TileState.Tank;
        }
    }

    private void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2 3 4 5 6 7");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(i);
            for (int j = 0; j < 8; j++)
            {
                switch (board[i, j])
                {
                    case TileState.Empty:
                        Console.Write("  ");
                        break;
                    case TileState.EmptyShot:
                        Console.Write("X ");
                        break;
                    case TileState.Tank:
                        Console.Write("  ");
                        break;
                    case TileState.TankShot:
                        Console.Write("O ");
                        break;
                }
            }
        }
    }

    public void PlayTankGame()
    {
        Console.WriteLine("Enter position in form x,y");
        string input;
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("\nEnter Position: ");
            input = Console.ReadLine();
            var parts = input.Split(",");
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);
            if (board[x, y] == TileState.Tank)
            {
                board[x, y] = TileState.TankShot;
                Console.WriteLine("Hit!");
                
            }
            else
            {
                board[x, y] = TileState.EmptyShot;
                Console.WriteLine("Miss!");
            }
            PrintBoard();
            // if there are no tanks left, end the game
            if (!board.Cast<TileState>().Contains(TileState.Tank))
            {
                Console.WriteLine("You win!");
                break;
            }
        }
    }
}
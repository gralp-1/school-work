namespace SchoolWork;

public class LotteryProblem
{
    public int WeeksForLotteryWin(int first, int second, int third)
    {
        int weeks = 0;
        var RNG = new Random(Environment.TickCount);
        while (true)
        {
            int randNum1 = RNG.Next(1, 31);
            int randNum2 = RNG.Next(1, 31);
            int randNum3 = RNG.Next(1, 31);
            if (first == randNum1 && second == randNum2 && third == randNum3)
            {
                return weeks;
            }
            weeks++;
        }

    }
}
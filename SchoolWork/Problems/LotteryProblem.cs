namespace SchoolWork;

public class LotteryProblem
{
    public int WeeksForLotteryWin(int first, int second, int third)
    {
        int weeks = 0;
        var RNG = new Random();
        long randNum1, randNum2, randNum3;;
        do
        {
            randNum1 = RNG.NextInt64(0, 30);
            randNum2 = RNG.NextInt64(0, 30);
            randNum3 = RNG.NextInt64(0, 30);
            weeks++;
        } while (first != randNum1 && second != randNum2 && third != randNum3);

        return weeks;
    }
}
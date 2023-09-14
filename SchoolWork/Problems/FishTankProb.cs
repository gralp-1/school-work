using System.Net.Mail;

namespace SchoolWork;

public class FishTankProb : Problem
{
    public static void FishTankVolume(double w, double h, double d)
    {
        var convertedVolume = (w * h * d) / 1000.0;
        Console.WriteLine($"Fish tank volume: {convertedVolume}");
    }

    public override void RunProblem()
    {
        FishTankVolume(100f, 200f, 20f);
    }
}
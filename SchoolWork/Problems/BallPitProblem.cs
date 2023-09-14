using System.Security.Cryptography.X509Certificates;

namespace SchoolWork;

public class BallPitProblem : Problem
{
    private static double BallPitVolume(double height, double radius)
    {
        // volume of a cylinder = pi*r^2*h
        return double.Pi * radius * radius * height;
    }

    private static double BallVolume(double rad)
    {
        // volume of a sphere: 4/3*pi*r^3
        return double.Pi * double.Pow(rad, 3.0) * 4.0/3.0;
    }

    public override void RunProblem()
    {
        // Parameters defined by question
        double ballPitRadius = 1.0;
        double ballPitHeight = 0.2;
        double ballRadius = 0.05;
        double packingDensity = 0.75;
        
        // find the number of balls that can fit in the ball pit (perfectly packed)
        double ballsInPit = BallPitVolume(ballPitHeight, ballPitRadius) / BallVolume(ballRadius);
        
        ballsInPit *= packingDensity; // adjust for packing density
        Console.WriteLine($"The ball pit can fit {ballsInPit:F} balls"); // output: 900
    }
}
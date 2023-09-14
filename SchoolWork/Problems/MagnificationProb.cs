namespace SchoolWork;

public class MagnificationProb : Problem
{
    // Calculates the magnification factor for a given image size and real size
    public static void Magnification(double imageSize, double realSize)
    {
        Console.WriteLine($"Magnification: {imageSize/realSize}");
    }

    public override void RunProblem()
    {
        Magnification(10f, 1.2e-10);
    }
}
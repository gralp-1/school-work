namespace SchoolWork;

public class CirclePropertiesProb : Problem
{
    public static (double,double,double,double) OutputCircleProperties(double diameter, double arcAngle)
    {
        double radius = diameter / 2.0;
        double area = double.Pi * double.Pow(radius, 2.0);
        double circumference = double.Pi * diameter;
        double arcLength = circumference * arcAngle / 360.0;
        return (radius, area, circumference, arcLength);
    }

    public override void RunProblem()
    {
        var (radius, area, circumference, arcLength) = OutputCircleProperties(1231f, 45f);
        Console.WriteLine($"Circle radius: {radius}");
        Console.WriteLine($"Circle area: {area}");
        Console.WriteLine($"Circle circumference: {circumference}");
        Console.WriteLine($"Circle arc length: {arcLength}");
    }
}
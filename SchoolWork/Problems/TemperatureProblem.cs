namespace SchoolWork;

public class TemperatureProblem : Problem
{
    public static double CentigradeToFarenheit(double centigrade)
    {
        return centigrade * 1.8 + 32.0;
    }

    public static double FarenheitToCentigrade(double farenheit)
    {
        return (farenheit - 32.0) / 1.8;
    }

    public override void RunProblem()
    {
        Console.WriteLine(CentigradeToFarenheit(100f));
    }

}
namespace SchoolWork;

public class EnergyBillProb : Problem
{
    public static double EnergyBillPrice(double previousReading, double currentReading, double calorificValue)
    {
        // find how many new units have been consumed
        double unitsUsed = currentReading - previousReading;
        // adjust with the magic constants
        double kWh = unitsUsed * calorificValue * 1.033 / 3.6; 
        // adjust for price
        return 2.84 * kWh;
    }

    public override void RunProblem()
    {
        Console.WriteLine($"{EnergyBillPrice(2321f, 23131f, 192.0):C}");
    }
}
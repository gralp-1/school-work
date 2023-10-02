using System.Runtime.InteropServices.ComTypes;

namespace SchoolWork;

public class ElectricCarProblem : Problem
{
    static (double price, int points) Points(int minutes)
    {
        double price = 0.2 * minutes; // charging fee (20p per minute)
        price += 1; // £1 session fee
        price = double.Max(4d, price);// check against 15 minute min (£4)

        int points = (int)double.Floor(
            double.Max( // take the highest number of
                1.5 * minutes, // the points of the amount of time taken
                22d) // and the 15 minute minimum
            );

        return (price, points);
    }
    public override void RunProblem()
    {
        const int minutes = 30;
        var (price, points) = Points(minutes);
        Console.WriteLine($"{minutes} minutes is {price:C} and you get {points} points");
    }
}
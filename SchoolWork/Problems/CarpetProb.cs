namespace SchoolWork;

public class CarpetProb : Problem
{
    public static double CarpetCost(double width, double length, double price)
    {
        var area = width * length;
        var carpetCost = area * price;
        var underlayCost = 3.0 * area;
        var gripperCost = 2.0 * (width + length); // 2w + 2l = 2(w + l)
        var fixedInstallationCost = 50.0;
        return fixedInstallationCost + underlayCost + gripperCost + carpetCost;
    }

    public override void RunProblem()
    {
        double totalPrice = CarpetCost(7f, 6f, 16f);
        Console.WriteLine($"Total installation cost is {totalPrice:C}");
    }
}
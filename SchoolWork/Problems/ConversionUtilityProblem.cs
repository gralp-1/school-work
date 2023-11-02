namespace SchoolWork;

public class ConversionUtilityProblem
{
    public void ConversionUtility()
    {
        string from = Console.ReadLine();
        string to = Console.ReadLine();
        // we convert everything to meters first, then to the desired unit
        var Conversions = new Dictionary<string, float>();
        Conversions.Add("cm", 100);
        Conversions.Add("m", 1);
        Conversions.Add("km", 0.001f);
        Conversions.Add("dm", 10);
        Conversions.Add("mm", 1000);
        Conversions.Add("ft", 3.280839895f);
        Conversions.Add("yd", 1.0936132983f);
        Conversions.Add("mi", 0.0006213712f);
        Conversions.Add("in", 39.3700787402f);

        float toMeters;
        float toUnit;
        try
        {
            toMeters = Conversions[from];
            toUnit = Conversions[to];
        }
        catch (KeyNotFoundException)
        {
            throw new Exception($"The units must be one of {string.Join(", ", Conversions.Keys)}");
        }
        float multiplier = toUnit / toMeters;
        Console.WriteLine($"multiply by {multiplier}");
    }
}
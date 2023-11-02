namespace SchoolWork;

[Serializable]
public class UndergroundProblem
{
    public void UndergroundDistance(string arriv, string dest)
    {
        List<string> stops = new()
        {
            "Brixton", "Stockwell", "Vauxhall", "Pimlico", "Victoria", "Green Park", "Oxford Circus",
            "Warren Street", "Euston", "King's Cross", "Highbury & Islington", "Finsbury Park", "Seven Sisters",
            "Tottenham Hale", "Blackhorse Road", "Walthamstow Central"
        };
        int start = stops.IndexOf(arriv);
        int end = stops.IndexOf(dest);
        int distance = Math.Abs(start - end);
        Console.WriteLine($"You are travelling from {arriv} to {dest}");
        Console.WriteLine($"You will travel {distance} stops");
    }
}
namespace SchoolWork;

public class ProcGenProblem
{
    public void ProcGen(int planetNum)
    {
        var rng = new Random(planetNum);
        
        int creatureIndex = rng.Next(0, 3);
        int colourIndex = rng.Next(0, 3);
        int characteristicIndex = rng.Next(0, 3);
        
        string creature = new []{ "lizards", "humanoids", "insects" }[creatureIndex];
        string characteristic = new []{ "shy", "angry", "docile"}[characteristicIndex];
        string colour = new []{ "red", "green", "blue" }[colourIndex];
        
        
        Console.WriteLine($"{characteristic} {colour} {creature}");
        
    }
}
namespace SchoolWork;

public class StatesOfWaterProblem : Problem
{
    public string StatesOfWater(double temperature)
    {
        return temperature >= 100d ?
            "gas" :
            temperature > 0 ? 
                "liquid" :
                "solid";
    }
    
    public override void RunProblem()
    {
        double temp = 37.5d;
        Console.WriteLine($"{temp}C water is a {StatesOfWater(temp)}");
    }
}
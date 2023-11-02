namespace SchoolWork;

public class AnimalFeederProblem
{
    public void AnimalFeeder()
    {
        string DinnerType = Console.ReadLine().ToLower();
        (bool, bool) hoppers = DinnerType switch
        {
            "breakfast" => (true, false),
            "lunch" => (true, true),
            "dinner" => (true, true),
            _ => (false, false),
        };
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            if (hoppers.Item1)
            {
                Console.WriteLine("Hopper 1");
            }
            if (hoppers.Item2)
            {
                Console.WriteLine("Hopper 2");
            }
        }
    }
}